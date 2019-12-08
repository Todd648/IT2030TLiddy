function EventFailed() {
    $("#searchresults").html("Unable to locate Event");
}

$(function () {
    $(".RemoveLink").click(function () {
        //alert("Link Clicked");
        var id = $(this).attr("data-id")
        $.post("/OrderCart/RemoveOrder", { "id": id }, function (data) {
            $("#update-message").text(data.Message);
            $("#cart-total").text(data.CartTotal);
            $("#item-count-" + data.DeleteID).text(data.ItemCount);
            if (data.ItemCount < 1) {
                $("record-" + data.DeleteID).fadeOut();
            }
        });
    })
});