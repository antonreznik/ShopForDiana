class WorkWithSize {

    constructor() { };

    addEventListenerOnCreateCategory() {
        document.getElementById("add_size").addEventListener("click", function () {
            $.ajax({
                url: "/Size/CreateSize",
                success: function (result) {
                    $("#modal_content").html(result);
                    $('#modal_window').width("35%").openModal();

                    //add event listener on create size button in modal window
                    document.getElementById("create_size_button").addEventListener("click", function () {
                        event.preventDefault();
                        let size = $("#Name").value;
                        $.ajax({
                            url: "/Size/CreateSize",
                            method: "POST",
                            data: size,
                            success: function (result) {
                                $("#modal_content").html(result);
                            }
                        })
                    });
                }
            });
        });
    };
}

let sizeAdmin = new WorkWithSize();
sizeAdmin.addEventListenerOnCreateCategory();