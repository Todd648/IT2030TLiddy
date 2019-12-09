function EventFailed() {
    $("#searchresults").html("Unable to locate Event");
}

$(function () {
    $(".RemoveLink").click(function () {
        var id = (this).attr("data-id")
        $.post("/OrderCart/RemoveOrder", { "id": id }, function (data) {
            $("#update-message").text(data.Message);
            $("#item-count" + data.DeleteID).text(data.ItemCount);
            if (ItemCount < 1) {
                $("#record-" + data.DeleteID).fadeOut();
            }
        });
    })
});
