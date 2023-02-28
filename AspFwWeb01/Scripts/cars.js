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


    $("#btnUpdateCar").click(function () {
        console.log("inside the click event");
        var car = {
            "Id": $("#hdnCarId").val(),
            "Brand": $("#brandrk").val(),
            "Model": $("#model").val(),
            "Cost": $("#cost").val(),
        };
        $.ajax({
            url: "UpdateCar",
            type: "POST",
            data: car,
            success: function (result) {
                //alert("Car updated successfull
                $('#successModal').modal('show');
                // window.location.href = "/home";
            }
        });
    });

    $('#successModal').on('hidden.bs.modal', function () {
        window.location.href = "/home";
    });
});
