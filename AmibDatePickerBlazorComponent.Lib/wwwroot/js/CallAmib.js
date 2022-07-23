window.callAmib = (elementId, objectReference) => {
    new AMIB.persianCalendar(elementId, {
        onchange: function (pdate) {
			if(!pdate) return;
			// console.log({ elementId, pdate });
			objectReference.invokeMethodAsync("OnInputFieldChanged", pdate.join( '/' ));            
        }
    });
}