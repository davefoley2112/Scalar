window.onload = function () {
    draw();
}

//
// Canvas 
//
function draw() {
    var canvas = document.getElementById('canvasFretboard');

    var strings = 6;
    var frets = 20;

    if (canvas.getContext) {
        var ctx = canvas.getContext("2d");

        for (var i = 0; i < strings; i++) {
            var yOff = i + 1;
            for (var j = 0; j < frets; j++) {
                var xOff = j + 1;
                ctx.fillRect(xOff * 35, yOff * 35, 30, 30);
                ctx.clearRect((xOff * 35) + 5, (yOff * 35) + 5, 20, 20);
            }
        }
    }
}

//
// SVG
//
function doCircle(evt) {
    var theCircle = evt.target;
    var radius = theCircle.getAttribute("r");

    if (radius == 50) {
        radius = 75;
    }
    else {
        radius = 50;
    }

    theCircle.setAttribute("r", radius);
}