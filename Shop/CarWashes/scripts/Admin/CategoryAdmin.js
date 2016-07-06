class WorkWithCategory {
    constructor() { };

    addEventListenerOnEditButtons() {
        let editButtons = document.querySelectorAll("button[value='editButton']");
        editButtons.forEach(function (button) {
            button.addEventListener("click", function () {
                alert("hello");
            })
        });
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
};

let categoryAdmin = new WorkWithCategory();
categoryAdmin.addEventListenerOnEditButtons();
categoryAdmin.addEventListenerOnCreateCategory();


