$(document).ready(function () {
    GetCountry();
    $('#Country').on('change', function () {
        var id = $(this).val();
        $('#State').empty();
        $('#State').append('<Option>----Select----</OPtion>');
        $.ajax({
            url: '/cascading/State?id=' + id,
            success: function (Result) {
                $.each(Result, function (i, data) {

                    $('#State').append('<Option value=' + data.id + '>' + data.stateName + '</Option>');
                });
            }
        });
    });

    $('#State').on('change', function () {
        var id = $(this).val();
        $('#City').empty();
        $('#City').append('<Option>----Select----</OPtion>');
        $.ajax({
            url: '/cascading/City?id=' + id,
            success: function (Result) {
                $.each(Result, function (i, data) {

                    $('#City').append('<Option value=' + data.id + '>' + data.cityName + '</Option>');
                });
            }
        });
    });
});

function GetCountry() {
    $.ajax({
        url: '/cascading/Country',
        success: function (result) {
            $.each(result, function (i, data) {
                $('#Country').append('<Option value=' + data.id + '>' + data.countryName + '<Option>');
            });
        }
    });
}
