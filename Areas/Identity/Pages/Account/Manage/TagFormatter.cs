using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollectionHub.Data;
using CollectionHub.Models;

namespace CollectionHub.Areas.Identity.Pages.Account.Manage
{
    public class TagFormatter
    {
        private readonly ApplicationDbContext _dbContext;

        public TagFormatter(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<string> RemoveRepeatableTags(string tagsString)
        {
            return tagsString.Split(' ').Distinct();
        }

        public async Task<List<Tag>> AddOrIncrementTags(IEnumerable<string> tagStrings)
        {
            var tagsList = new List<Tag>();
            
            foreach (var tagString in tagStrings)
            {
                var tag = _dbContext.Tags.FirstOrDefault(t => t.Name == tagString);
                if (tag == null)
                {
                    var tagToAdd = new Tag() { Name = tagString };
                    _dbContext.Tags.Add(tagToAdd);
                    tagsList.Add(tagToAdd);
                }
                else
                {
                    var tagName = tag.Name;
                    var tagCount = ++tag.Count;
                    _dbContext.Tags.Remove(tag);
                    tagsList.Add(new Tag() { Name = tagName, Count = tagCount });
                }

                await _dbContext.SaveChangesAsync();
            }

            return tagsList;
        }

        public List<Tag> CreateTagListIfTagsExist(string tagsString)
        {
            if (!TagsExist(tagsString)) 
                throw new ArgumentException(null, nameof(tagsString));
            var tagStrings = tagsString.Split(' ');
            return tagStrings.Select(tagString => _dbContext.Tags.FirstOrDefault(t => t.Name == tagString)).ToList();
        }

        public bool TagsExist(string tagsString)
        {
            var tagList = tagsString.Split(' ');
            return TagsExist(tagList);
        }

        public bool TagsExist(IEnumerable<string> tagList)
        {
            return tagList.All(TagExists);
        }

        public bool TagExists(string tagString)
        {
            return _dbContext.Tags.Any(t => t.Name == tagString);
        }

        public string GetTagsString(List<Tag> tagsList)
        {
            return tagsList.Aggregate(" ", (current, tag) => current + (tag.Name + " ")).Trim();
        }
    }
}