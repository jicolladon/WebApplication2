


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

function valida_envia() {
    //Creamos un objeto 
    object = document.fvalida.email;
    valueForm = object.value;

    // Patron para el correo
    var patron = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/;
    if (valueForm.search(patron) != 0) {
        alert("Mail incorrecto")
        object.style.color = "#f00";
        return 0;
    }

    //valido el nombre 
    if (document.fvalida.nombre.value.length == 0) {
        alert("Tiene que escribir su nombre")
        object.style.color = "#f00";
        document.fvalida.nombre.focus()
        return 0;
    }

    if (document.fvalida.razon.value.length == 0) {
        alert("Tiene que escribir una razon")
        object.style.color = "#f00";
        document.fvalida.razon.focus()
        return 0;
    }

    //el formulario se envia 
    alert("Muchas gracias por enviar el formulario");
    document.fvalida.submit();
}