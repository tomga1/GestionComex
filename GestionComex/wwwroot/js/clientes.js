$(document).ready(function () {
    var $cuit = $("#cuit");
    var $razon = $("#razonSocial");
    var $cuitError = $('span[data-valmsg-for="CUIT"]');

    function clearValidation() {
        $cuit.removeClass("is-invalid");
        $cuitError.text("");
    }
    $cuit.on('blur', function () {
        var cuit = $cuit.val().trim();

        if (cuit === "") {
            clearValidation();
            $razon.val("");
            $cuit.addClass("is-invalid");
            $cuitError.text("CUIT inexistente");
            return;
        }

        if (cuit.length !== 11) {
            clearValidation();
            $razon.val("");
            $cuit.addClass("is-invalid");
            $cuitError.text("El CUIT debe tener 11 dígitos");
            return;
        }

        clearValidation();

        $.ajax({
            url: '/Clientes/ObtenerRazonSocial',
            type: 'GET',
            data: { cuit: cuit },
            success: function (data) {
                if (data && data.length > 0 && data !== "@nombre") {
                    $razon.val(data);
                } else {
                    clearValidation();
                    $razon.val("");
                    $cuit.addClass("is-invalid");
                    $cuitError.text("CUIT inexistente");
                }
            },
            error: function () {
                clearValidation();
                $razon.val("");
                $cuit.addClass("is-invalid");
                $cuitError.text("Error al buscar la razón social");
            }
        });
    });
});
