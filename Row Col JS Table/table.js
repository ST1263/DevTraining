
function editRow(){
 
 var mytable=document.getElementById("mytable");
 mytable.rows[parseInt(document.getElementById("row").value)].cells[document.getElementById("col").value].innerHTML=document.getElementById("cdata").value;

};
