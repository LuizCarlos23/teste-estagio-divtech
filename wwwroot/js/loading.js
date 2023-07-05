function showLoading() {
    let loogindElement = document.getElementsByClassName("spinner-border")[0]
    loogindElement.style.visibility = 'visible'
}

function hideLoading() {
    let loogindElement = document.getElementsByClassName("spinner-border")[0]
    loogindElement.style.visibility = 'hidden'
}