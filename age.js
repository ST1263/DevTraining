$("document").ready(function(){
$("#clear").click(function(){
 $("#age").val("")
$("#result").val("")
$("#display").val("")
});

 

     

     $("#result").val(result);
     $("#display").val(result);
    });

 
 function calculate() {
   
    var age= new Date(document.getElementById("age").value);
     var today = new Date();
  var a = today.getFullYear();

    if(age==""){
      alert(" Enter DOB");
    return false;
  } 
  else if(today > age){
    var display = a - age.getFullYear();
   $("#display").val(display);

  }
  else
  {
    alert("Invalid");
  }
   
  

 
  

 

}