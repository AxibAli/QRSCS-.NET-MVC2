$(document).ready(function () {

    $("#prof").click(function () {
        var url = "/Admin/UpdateUserProfile?User_ID=" + $("#prof").val();
            $("#ModalTitle").html("Update User");
        $("#MyModal").modal("show");
        $.ajax({
            type: "GET",
            url: url,

            success: function (data) {
                var obj = JSON.parse(data);
                $("#Full_Name").val(obj.StudentId);
                
            }
        })
        });
        });
