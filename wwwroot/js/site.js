// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function changeLight() {
    var source = document.getElementById("darkToggle");
    
    if (document.body.classList.contains("darkLight")) {
        source.innerHTML = "Light Theme"
    } else {
        source.innerHTML = "Dark Theme"
    }

    darkMode();

}

function darkMode() {
    const wasDarkMode = localStorage.getItem('theme') === 'true';
    localStorage.setItem('theme', !wasDarkMode);
    const element = document.body
    element.classList.toggle('darkLight', !wasDarkMode);
}

function onload() {
    document.body.classList.toggle('darkLight', localStorage.getItem('theme') === 'true')
}