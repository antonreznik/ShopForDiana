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
}

let sizeAdmin = new WorkWithSize();
sizeAdmin.addEventListenerOnCreateCategory();