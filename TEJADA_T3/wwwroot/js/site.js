function cargarRaza() {
    var $raza = $('select#IdRaza');
    var $especie = $('select#IdEspecie');
    $.ajax({
        url: '/home/Raza?IdEspecie=' + $especie.val(),
        type: 'get'
    }).done(function (items) {
        var options = '<option value="">-- Seleccione una raza --</option>';
        for (var i = 0; i < items.length; i++) {
            options += `<option value="${items[i].id}">${items[i].nombre}</option>`
        }
        $raza.html(options);
    })
}