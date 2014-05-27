


$(function () {
    $("#btnAlert").on("click", function () {
        if ($("#alertDetalle").isVisible()) {
            $("#alertDetalle").hidden();
        }
        else {
            $("#alertDetalle").show();
        }
    });
});