// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

document.addEventListener('DOMContentLoaded', () => {
    document.querySelectorAll('.close-alert').forEach((button) => {
        button.addEventListener('click', () => {
            const alert = button.closest('.alert');

            if (!alert) {
                return;
            }

            alert.classList.remove('show');
            alert.addEventListener('transitionend', () => alert.remove(), { once: true });
        });
    });
});
