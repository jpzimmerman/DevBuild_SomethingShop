var formErrorStrings = []

function ClientSideValidation() {
    var requiredElements = document.getElementsByClassName("user-entry-required");
    debugger;
    for (var i = 0; i < requiredElements.length; i++) {
        if (requiredElements[i].value === "") {
            debugger;
            formErrorStrings.push("Please enter " + requiredElements[i].name + "\n");
        }
    }
    if (formErrorStrings.length > 0) {
        alert(formErrorStrings);
    }
}

function CheckForEmptyField(elementObj) {
    debugger;
    alert("inside the forEach");
    if (elementObj.value === "") {
        debugger;
        formErrorStrings.push("Please enter " + elementObj + "\n");
    }
}