$("document").ready(function(){
$("#clear").click(function(){
 $("#age").val("")
$("#result").val("")
$("#display").val("")
});

    
     $("#display").val(result);
    });

 
 function calculate() {
   var age= new Date(document.getElementById("age").value);
   if(age=="Invalid Date") {
    alert("Please Enter DOB");
   }
   else{
  
   var d1 = age.getDate();
   var m1 = 1 + age.getMonth();
   var y1 = age.getFullYear();
   var date = new Date();
  var d2 = date.getDate();
  var m2 = 1 + date.getMonth();
  var y2 = date.getFullYear();
  var month = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

  if(d1 > d2){
    d2 = d2 + month[m2 - 1];
    m2 = m2 - 1;
  }
  if(m1 > m2){
    m2 = m2 + 12;
    y2 = y2 - 1;
  }
  var d = d2 - d1;
  var m = m2 - m1;
  var y = y2 - y1;
  $("#display").val(y+'YEAR\t'+m+'MONTHS');
  } 
}
    