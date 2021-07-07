var x,n=0;
function myFunction(x) {
    if (x == "Increase") {
        document.getElementById("quantity").innerHTML = ++n;
    }

    if (x == "Decrease" && n > 1) {
        document.getElementById("quantity").innerHTML = --n;        
    }
}