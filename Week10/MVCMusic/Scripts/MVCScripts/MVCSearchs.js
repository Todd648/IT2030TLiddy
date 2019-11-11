function ArtistFailed() {
    $("#searchresults").html("Unable to locate Artist");
}

$(function () {
    $(".RemoveLInk").click(function () {
        var id = $(this).attr("data-id")
        $.post("/ShoppingCart/RemoveFromCart", { "id": id }, function (data) {
            $("#update-message").text(data.Message);
            $("#cart-total").text(data.CartTotal);
            $("#item-count-" + data.DeleteID).text(data.ItemCount);
            if (data.ItemCount < 1) {
                $("record-" + data.DeleteID).fadeOut();
            }
        });
    })
});