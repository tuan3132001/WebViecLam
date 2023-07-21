function deleteJob(id) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Jobs/DeleteConfirmed',
        data: { id: id },
        success: function (data) {
            console.log("xoa thanh cong")
            window.location.href = 'https://localhost:44381/jobs';
        },
        error: function (error) {
            console.log(":)");
            console.log(error);
        }
    });
};

