// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('#ctrleffectivedate').datepicker({
    format: 'mm-dd-yyyy'
});

$('#ctrlexpirationdate').datepicker({
    format: 'mm-dd-yyyy'
});

$('#ctrleffectivedate').on('changeDate', function (ev) {
    $(this).datepicker('hide');
});

$('#ctrlexpirationdate').on('changeDate', function (ev) {
    $(this).datepicker('hide');
}); 

