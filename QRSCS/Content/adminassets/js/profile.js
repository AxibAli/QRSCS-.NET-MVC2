$(document).ready(function () {

    $("#prof").click(function () {
        var url = "/Admin/UpdateUserProfile?User_ID=" + $("#prof").val();
        $("#ModalTitle").html("Personal Details");
        $("#MyModal").modal("show");
        $.ajax({
            type: "GET",
            url: url,

            success: function (data) {
                var obj = JSON.parse(data);                
                $("#Full_Name").val(obj.Full_Name);
                $("#Father_Name").val(obj.Father_Name);
                $("#NIC").val(obj.NIC);              
                $("#Gen").val(obj.Gender);
                var a = obj.DOB;
                var ab = a.split("T");
                $("#Date_of_Birth").val(ab[0]);
                
                $("#Contact").val(obj.Contact_Number);
                $("#Rank").val(obj.Rank);
                $("#Designation").val(obj.Desigation_Role);
                $("#Address").val(obj.Address);
                $("#City").val(obj.City);
                $("#State").val(obj.State);
                $("#username").val(obj.UserName);
                $("#Password").val(obj.Password);

            }
        })
    });

    $("#saverecord").click(function () {
        alert($('#pics').attr('src'));
        var data = {
            User_ID: $("#prof").val(),
            Full_Name:$("#Full_Name").val(),
            Father_Name:$("#Father_Name").val(),
            NIC:$("#NIC").val(),
            Gender: $("#Gen").val(),
            DOB:$("#Date_of_Birth").val(),
            Contact_Number:$("#Contact").val(),
            Rank:$("#Rank").val(),
            Desigation_Role:$("#Designation").val(),
            Address:$("#Address").val(),
            City:$("#City").val(),
            State:$("#State").val(),
            UserName:$("#username").val(),
            Password: $("#Password").val(),
            Picture: $('#pics').attr('src')

        }

 
        $.ajax({
            type: "Post",
            url: "/Admin/SaveDataInDatabase",
            data: data,
            success: function (result) {
                alert("Successfully Updated....");
                window.location.href = "/Admin/Index";
                $("#MyModal").modal("hide");
            }
        })
    })
});
