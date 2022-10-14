$(document).ready(function () {

    $("#btnSaveCar").click(function () {
        console.log("inside the click event");
        var car = {
            "Brand": $("#brandrk").val(),
            "Model": $("#model").val(),
            "Cost": $("#cost").val(),
        };
        $.ajax({
            url: "AddNewCarJson",
            type: "POST",
            data: car,
            success: function (result) {
                $("#status").text(result);
            }
        });
    });

   

});
