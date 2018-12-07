var formErrorStrings = []
const errorFeedbackString = "ErrorFeedback"
const checkMarkCharacter = '\u2713';
const xMarkCharacter = '\u2715';

function ClientSideValidation() {
    var requiredElements = document.getElementsByClassName("user-entry-required");
    for (var i = 0; i < requiredElements.length; i++) {
        
        var errorFeedbackElement = document.getElementById(requiredElements[i].name + errorFeedbackString);
        if (errorFeedbackElement !== null) {
            if (requiredElements[i].value === "") {
                errorFeedbackElement.innerText = xMarkCharacter + " " + "Please enter " + requiredElements[i].name;
                if (!errorFeedbackElement.classList.contains("form-problem")) {
                    errorFeedbackElement.classList.add("form-problem");
                }
                if (errorFeedbackElement.classList.contains("form-correct")) {
                    errorFeedbackElement.classList.remove("form-correct");
                }
                formErrorStrings.push("Please enter " + requiredElements[i].name + "\n");
            }
            else {
                errorFeedbackElement.innerText = '\u2713';
                if (!errorFeedbackElement.classList.contains("form-correct")) {
                    errorFeedbackElement.classList.add("form-correct");
                }
                if (errorFeedbackElement.classList.contains("form-problem")) {
                    errorFeedbackElement.classList.remove("form-problem");
                }
            }
        }   
    }
}

function CheckForEmptyField(elementObj) {
    debugger;
    if (elementObj.value === "") {
        debugger;
        formErrorStrings.push("Please enter " + elementObj + "\n");
    }
}