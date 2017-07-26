$(".subscribeButton").click(
    function () {

        if ($(this).text() === 'Subscribed') {
            $(this).text('Unsubscribed');
            $(this).addClass("btn-danger");
            $(this).removeClass("btn-success");
        } else {
            $(this).text('Subscribed');
            $(this).addClass("btn-success");
            $(this).removeClass("btn-danger");
        }



    });

