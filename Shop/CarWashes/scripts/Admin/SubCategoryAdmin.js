class WorkWithSubCategory {
    constructor() {

    };

    AddEventListenerOnCreateSubCategory() {
        document.getElementById("add_subcategory").addEventListener("click", function () {
            $.ajax({
                url: "/SubCategory/CreateSubCategory",
                success: function (result) {
                    $("#modal_content").html(result);
                    $('#modal_window').width("35%").modal().modal("open");

                    //add event listener on create category button in modal window
                    document.getElementById("create_subCategory_button").addEventListener("click", function () {
                        event.preventDefault();
                        let categoryId = $("#Categories").val();
                        let subCategoryName = $("#subCategoryName").val();
                        $.ajax({
                            url: "/SubCategory/CreateSubCategory",
                            method: "POST",
                            data: { "CategoryId": categoryId, "Name" : subCategoryName },
                            success: function (result) {
                                if (result.indexOf("form") > 0) {
                                    $("#modal_content").html(result);
                                }
                                else {
                                    $("#modal_window").modal("close");
                                }
                            }
                        })
                    });
                }
            });
        });        
    }
}

let subCategoryAdmin = new WorkWithSubCategory();
subCategoryAdmin.AddEventListenerOnCreateSubCategory();