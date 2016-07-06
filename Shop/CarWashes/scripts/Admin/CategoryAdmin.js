class WorkWithCategory {
    constructor() { };

    addEventListenerOnCreateCategory() {
        document.getElementById("add_category").addEventListener("click", function () {
            $.ajax({
                url: "/Category/CreateCategory",
                success: function (result) {
                    $("#modal_content").html(result);

                    //add event listener on create category button in modal window
                    document.getElementById("create_category_button").addEventListener("click", function () {
                        event.preventDefault();
                        let category = $("#Name").value;
                        $.ajax({
                            url: "/Category/CreateCategory",
                            method: "POST",
                            data: category,
                            success: function (result) {
                                $("#modal_content").html(result);
                            }
                        })
                    });
                }
            });
            $('#modal_window').width("35%").openModal();
        });
    };
    addEventListenerOnEditCategory() {
        document.getElementById("edit_category").addEventListener("click", function () {
            $.ajax({
                url: "/Category/EditCategory",
                success: function (result) {
                    $("#modal_content").html(result);

                    let editButtons = document.querySelectorAll("button[value='editButton']");
                    editButtons.forEach(function (button) {
                        button.addEventListener("click", function (event) {
                            let input = event.currentTarget.dataset.editbtn;
                            let field = document.querySelector(`input[data-input="${input}"]`);
                            field.removeAttribute("disabled");
                            event.currentTarget.className += "disabled";
                        })
                    });
                }
            });
            $('#modal_window').width("65%").openModal();
        });
    };
};

let categoryAdmin = new WorkWithCategory();
categoryAdmin.addEventListenerOnCreateCategory();
categoryAdmin.addEventListenerOnEditCategory();


