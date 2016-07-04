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
};

let categoryAdmin = new WorkWithCategory();
categoryAdmin.addEventListenerOnEditButtons();
