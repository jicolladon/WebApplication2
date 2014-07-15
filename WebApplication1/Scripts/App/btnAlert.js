


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
    object = document.fvalid    a.email;
    valueForm = object.value;
    var b = false;
    // Patron para el correo
    var patron = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/;
    if (valueForm.search(patron) != 0) {
        alert("Mail incorrecto")
        object.style.color = "#f00";
        b = true;
    }

    //valido el nombre 
    if (document.fvalida.nombre.value.length == 0) {
        alert("Tiene que escribir su nombre")
        object.style.color = "#f00";
        document.fvalida.nombre.focus()
        b = true;
    }

    if (document.fvalida.razon.value.length == 0) {
        alert("Tiene que escribir una razon")
        object.style.color = "#f00";
        document.fvalida.razon.focus()
        b = true;
    }
    if (b == true)
        return 0;
    //el formulario se envia 
    alert("Muchas gracias por enviar el formulario");
    document.fvalida.submit();
}