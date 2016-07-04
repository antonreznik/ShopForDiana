class WorkWithCategory {
    constructor() { };

    addEventListenerOnEditButtons() {
        let editButtons = document.querySelectorAll("button[value='editButton']");
        editButtons.forEach(function (button) {
            button.addEventListener("click", function () {
                alert("hello");
            })
        });
    }

    addEventListenerOnCreateCategory() {
        document.getElementById("add_category").addEventListener("click", function () {
            $.ajax({
                url: "/Category/CreateCategory",
                success: function (result) {
                    $("#modal_content").html(result);
                }
            });

            $('#modal_window').openModal();
        });
    }
};

let categoryAdmin = new WorkWithCategory();
categoryAdmin.addEventListenerOnEditButtons();
categoryAdmin.addEventListenerOnCreateCategory();


