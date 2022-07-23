window.activateDatePicker = {
    enableDatePicker: function (element, objectReference) {
        element.addEventListener('change', function (evt) {
            objectReference.invokeMethodAsync("OnInputFieldChanged", this.value);
        });
    }
};