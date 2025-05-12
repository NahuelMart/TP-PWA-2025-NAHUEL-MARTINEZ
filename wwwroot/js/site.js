// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function mostrarToastConRedireccion() {
    const toastEl = document.getElementById('toastPizza');
    if (!toastEl) return;

    const toast = new bootstrap.Toast(toastEl);
    toast.show();

    setTimeout(() => {
        window.location.href = "/Pizza";
    }, 1000);
}
