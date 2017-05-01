$(document).ready(function () {

    $('.test-json').click(function () {

        $.ajax({
            url: "/Home/TestJson",
            type: "POST",
            });

    });


});




    