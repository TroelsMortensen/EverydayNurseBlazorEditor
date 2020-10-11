window.helpers = {
    getBoundingClientRect: function (elId) {
        var testDiv = document.getElementById(elId);
        return [testDiv.offsetLeft, testDiv.offsetTop];
    },

    getBoundingClientRectangle: function (elId) {
        var testDiv = document.getElementById(elId);
        return testDiv.getBoundingClientRect();
    },

    drawBezier: function (elId, sX, sY, eX, eY) {
        this.canvas = document.getElementById(elId);
        var ctx = this.canvas.getContext("2d");
        ctx.beginPath();
        ctx.moveTo(sX, sY);
        ctx.bezierCurveTo(
            sX + 20, sY,
            eX-20, eY,
            eX, eY
            );
        ctx.stroke();
    }
}