let url = "/api/Member";


function onDelete(id) {
    if (confirm(`Delete ${id}?`)) {

        // use the fetch api instead?  
        $.ajax({
            url: `${url}/${id}`, 
            method: 'delete',

            success: () => {
                //alert("deleted");

                // update the table to reflect the new list
                $(`#tr-${id}`).remove();
            }, 
            error: (error) => {
                alert(error);
            }
        });
    }
}
$(document).ready(function () {
    $.getJSON(url, (members) => {

        members.forEach(member => {

            $('#memberTable tbody').append(`<tr id="tr-${member.id}">
                            <td>${member.id}</td>
                            <td>${member.name}</td>
                            <td>${member.email}</td>
                            <td>${member.active ? "Active" : "Inactive"}</td>
                            <td><button
                                class="btn btn-danger"
                                onclick="onDelete(${member.id})">
                                    Delete
                                </button>
                            </td>
                        </tr>`)
        });
    });
})