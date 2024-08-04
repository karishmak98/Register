var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "User/GetAll",
            "type": "GET",
            "dataType":"json"
        },
        "columns": [
            { "data": "name", "width": "20%" },
            { "data": "email", "width": "30%" },
            { "data": "imageURL", "width": "30%" },
            {
                "data": "id", "width": "40%",
                "render": function (data) {
                    return `
                    <div class="text-center">
                    <a href="User/Upsert?id=${data}" class="btn btn-info"><i class ="fas fa-edit"></i></a>
                    <a onclick=Delete("User/Delete/${data}") class="btn btn-danger"><i class ="fas fa-trash"></i></a>
                    </div>
                    `
                }
            }
        ]
    })
}

function Delete(url) {
    swal({
        title: "Want to delete data?",
        text: "Delete Information!!!",
        buttons: true,
        icon: "warning",
        dangerModel: true,
    }).then((willdelete) => {
        if (willdelete) {
            $.ajax({
                url: url,
                type: "Delete",
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}