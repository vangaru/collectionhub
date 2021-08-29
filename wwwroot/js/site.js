$(document).ready(function () {
    $(".autocomplete").autocomplete({
        source: '/api/tagapi/autocomplete'
    });
});

let dropZone = document.getElementById('drop-zone')
let fileInput = document.getElementById('file-input')
let label = document.getElementById('file-input-label')
let gallery = document.getElementById('gallery')
    
fileInput.onchange = () => {
    previewFile(fileInput.files)
}    
    
;['dragenter', 'dragover', 'dragleave', 'drop'].forEach(event => {
    dropZone.addEventListener(event, preventDefaults, false)
})

function preventDefaults(e) {
    e.preventDefault()
    e.stopPropagation()
}

;['dragenter', 'dragover'].forEach(event => {
    dropZone.addEventListener(event, highlight, false)
})

;['dragleave', 'drop'].forEach(event => {
    dropZone.addEventListener(event, unhighlight, false)
})

function highlight() {
    dropZone.classList.add('highlight')
}

function unhighlight() {
    dropZone.classList.remove('highlight')
}

dropZone.addEventListener('drop', uploadAndPreviewFile, false)


function uploadAndPreviewFile(e) {
    fileInput.files = e.dataTransfer.files
    previewFile(fileInput.files)
}

function previewFile(files) {
    const [file] = files
    if (file) {
        let img = document.createElement('img')
        img.classList.add('img-fluid', 'img-thumbnail')
        img.src = URL.createObjectURL(file)
        if (gallery.childElementCount === 0) {
            gallery.appendChild(img)
        } else {
            gallery.innerHTML = ""
            gallery.appendChild(img)
        }
    }
}



