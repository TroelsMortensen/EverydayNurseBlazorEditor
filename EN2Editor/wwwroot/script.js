window.helpers = {
    getBoundingClientRect : function(elId) {
        var testDiv = document.getElementById(elId);
        return [testDiv.offsetLeft, testDiv.offsetTop];
    }
}