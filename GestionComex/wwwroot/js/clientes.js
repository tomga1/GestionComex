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

        // Si borró todo
        if (cuit === "") {
            clearValidation();
            $razon.val("");
            // Mostrar mensaje de CUIT inexistente
            $cuit.addClass("is-invalid");
            $cuitError.text("CUIT inexistente");
            return;
        }

        // Longitud incorrecta
        if (cuit.length !== 11) {
            clearValidation();
            $razon.val("");
            $cuit.addClass("is-invalid");
            $cuitError.text("El CUIT debe tener 11 dígitos");
            return;
        }

        // Longitud OK, limpiamos errores previos
        clearValidation();

        // AJAX al endpoint local
        $.ajax({
            url: '/Clientes/ObtenerRazonSocial',
            type: 'GET',
            data: { cuit: cuit },
            success: function (data) {
                // data puede venir vacío o con '@nombre'
                if (data && data.length > 0 && data !== "@nombre") {
                    $razon.val(data);
                } else {
                    // CUIT no existe o servicio devolvió '@nombre'
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
