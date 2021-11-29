const newDiv = document.createElement("div");
newDiv.setAttribute("id","1");
const newP = document.createElement("p");
const newContent = document.createTextNode("Testing some javascript manipulatoins");
newP.appendChild(newContent);
newDiv.appendChild(newP);
document.getElementById("0").appendChild(newDiv);


const newDiv1 = document.createElement("div");
newDiv1.setAttribute("id","2");
const newP1 = document.createElement("p");
const newContent1 = document.createTextNode("Testing some javascript manipulatoins");
newP1.appendChild(newContent1);
newDiv1.appendChild(newP1);
document.getElementById("0").appendChild(newDiv1);



const newDiv2 = document.createElement("div");
newDiv2.setAttribute("id","3");
const newP2 = document.createElement("p");
const newContent2 = document.createTextNode("Testing some javascript manipulatoins");
newP2.appendChild(newContent2);
newDiv2.appendChild(newP2);
document.getElementById("0").appendChild(newDiv2);



document.getElementById("1").style.fontSize = "x-large";
document.getElementById("2").classList.add('MyClass');
var image = document.createElement("img");
var imageParent = document.getElementById("3");
image.src = "images/test.png"
imageParent.appendChild(image);
document.getElementById("0").style.textAlign = "center";



var add = document.getElementById('add');
var del = document.getElementById('del');

add.onclick = function(){
    const freshDiv = document.createElement("div");
    freshDiv.setAttribute("id","x");
    const freshP = document.createElement("P");
    const freshContent = document.createTextNode("Testing some javascript manipulatoins");
    freshP.appendChild(freshContent);
    freshDiv.appendChild(freshP);
    document.getElementById("0").appendChild(freshDiv);
};

del.onclick = function(){
    var rem = document.getElementById('x');
    rem.remove(); 
};