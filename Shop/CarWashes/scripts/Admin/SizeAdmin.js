class WorkWithSize {

    constructor() { };

    addEventListenerOnCreateSize() {
        document.getElementById("add_size").addEventListener("click", function () {
            $.ajax({
                url: "/Size/CreateSize",
                success: function (result) {
                    $("#modal_content").html(result);
                    $('#modal_window').width("35%").openModal();

                    //add event listener on create size button in modal window
                    document.getElementById("create_size_button").addEventListener("click", function () {
                        event.preventDefault();
                        let size = $("#sizeName").val();
                        $.ajax({
                            url: "/Size/CreateSize",
                            method: "POST",
                            data: { "Name": size },
                            success: function (result) {
                                if (result.indexOf("form") > 0) {
                                    $("#modal_content").html(result);
                                }
                                else {
                                    $("#modal_window").closeModal();
                                }
                            }
                        })
                    });
                }
            });
        });
    };

    addEventListenerOnEditSize() {
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

            input.setAttribute("disabled", "disabled");
            $(editButton).removeClass("disabled");
            $(saveButton).addClass("disabled");

            saveButton.removeEventListener("click", saveButtonListener);
            editButton.addEventListener("click", editButtonListener)

            $.ajax({
                url: "/Size/UpdateSize",
                method: "POST",
                data: { "Id": inputDataAttr, "Name": input.value }
            })
        }

        document.getElementById("edit_size").addEventListener("click", function () {
            $.ajax({
                url: "/Size/UpdateSize",
                success: function (result) {
                    $("#modal_content").html(result);
                    $('#modal_window').width("45%").openModal();

                    //add event listener on every edit button
                    let editButtons = document.querySelectorAll("button[value='editButton']");
                    editButtons.forEach(function (button) {
                        button.addEventListener("click", editButtonListener);
                    });
                }
            });
        });
    };
}

let sizeAdmin = new WorkWithSize();
sizeAdmin.addEventListenerOnCreateSize();
sizeAdmin.addEventListenerOnEditSize();