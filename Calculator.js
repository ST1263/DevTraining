$("document").ready(function(){
  $(".math").click(function(){
   var fnum=$("#fnum").val();
      var snum=$("#snum").val();
var id=$("input[name='math']:checked").val();

      let result ;
   if(id=="add")
{
result=parseInt(fnum) + parseInt(snum);
}
else if(id=="sub"){
result=parseInt(fnum) - parseInt(snum);
}
else if(id=="multi"){
result=parseInt(fnum) * parseInt(snum);
}
else if(id=="div"){
result=parseInt(fnum) / parseInt(snum);
}
else
{
  alert("Select one Option for Perform task");
}

     $("#result").val(result);
     $("#display").val(result);
});
$("#clear").click(function(){
 $("#fnum").val("")
$("#snum").val("")
$("#result").val("")
$("#display").val("")
});
});
 

  function calculate() {
    var fnum=document.getElementById("fnum").value;
    if(fnum==""){
      alert(" Enter 1st Number");
    return false;
  } 

var snum=document.getElementById("snum").value;
if(snum==""){
      alert(" Enter 2nd Number");
    return false;
  }  

      var fnum=$("#fnum").val();
      var snum=$("#snum").val();
var id=$("input[name='math']:checked").val();

      let result ;
   if(id=="add")
{
result=parseInt(fnum) + parseInt(snum);
}
else if(id=="sub"){
result=parseInt(fnum) - parseInt(snum);
}
else if(id=="multi"){
result=parseInt(fnum) * parseInt(snum);
}
else if(id=="div"){
result=parseInt(fnum) / parseInt(snum);
}
else
{
  alert("Select one Option for Perform task");
}

     $("#result").val(result);
     $("#display").val(result);
    };



 