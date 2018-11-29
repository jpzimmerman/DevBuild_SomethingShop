var formErrorStrings = []
const errorFeedbackString = "ErrorFeedback"
const checkMarkCharacter = '\u2713';
const xMarkCharacter = '\u2715';

function ClientSideValidation() {
    var requiredElements = document.getElementsByClassName("user-entry-required");
    for (var i = 0; i < requiredElements.length; i++) {
        if (requiredElements[i].value === "") {
            document.getElementById(requiredElements[i].name + errorFeedbackString).innerText = xMarkCharacter + " " + "Please enter " + requiredElements[i].name;
            requiredElements[i].classList.add("form-problem");
            formErrorStrings.push("Please enter " + requiredElements[i].name + "\n");
        }
        else {
            document.getElementById(requiredElements[i].name + errorFeedbackString).innerText = '\u2713';
            requiredElements[i].classList.add("form-correct");
        }
        
    }
    if (formErrorStrings.length > 0) {
        alert(formErrorStrings);
    }
}

function CheckForEmptyField(elementObj) {
    debugger;
    if (elementObj.value === "") {
        debugger;
        formErrorStrings.push("Please enter " + elementObj + "\n");
    }
}