let url = "/api/Member";

$(document).ready(function () {

    function onDelete(id) {
        alert(`Delete ${id}`);
    }
    $.getJSON(url, (members) => {

        members.forEach(member => {

            $('#memberTable tbody').append(`<tr>
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