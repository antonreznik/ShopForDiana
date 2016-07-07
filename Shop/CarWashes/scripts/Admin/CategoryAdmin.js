class WorkWithCategory {
    constructor() {

    };

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
        let editButtonListener = function (event) {
            let editButton = event.currentTarget;
            let inputDataAttr = editButton.dataset.editbtn;
            let input = document.querySelector(`input[data-input="${inputDataAttr}"]`);
            let saveButton = document.querySelector(`button[data-savebtn="${inputDataAttr}"]`);

            input.removeAttribute("disabled");
            $(editButton).addClass("disabled");
            $(saveButton).removeClass("disabled");

            editButton.removeEventListener("click", editButtonListener);
            saveButton.addEventListener("click", saveButtonListener);
        }
        let saveButtonListener = function (event) {
            let saveButton = event.currentTarget;
            let inputDataAttr = saveButton.dataset.savebtn;
            let input = document.querySelector(`input[data-input="${inputDataAttr}"]`);
            let editButton = document.querySelector(`button[data-editbtn="${inputDataAttr}"]`);

            input.setAttribute("disabled","disabled");
            $(editButton).removeClass("disabled");
            $(saveButton).addClass("disabled");

            saveButton.removeEventListener("click", saveButtonListener);
            editButton.addEventListener("click", editButtonListener)
            alert("save");
            $.ajax({
                url: "/Category/CreateCategory",
                method: "POST",
                data: { "Id": inputDataAttr, "Name": input.value }
            })
        }

        document.getElementById("edit_category").addEventListener("click", function () {
            $.ajax({
                url: "/Category/EditCategory",
                success: function (result) {
                    $("#modal_content").html(result);

                    //add event listener on every edit button
                    let editButtons = document.querySelectorAll("button[value='editButton']");
                    editButtons.forEach(function (button) {
                        button.addEventListener("click", editButtonListener);
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

