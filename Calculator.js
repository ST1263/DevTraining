$("document").ready(function(){
  $(".math").click(function(){
   var fnum=$("#fnum").val();
      var snum=$("#snum").val();
var id=$("input[name='math']:checked").val();

      let result;

      switch(id){
       
        case 'add':
        
        result=parseInt(fnum) + parseInt(snum);
        break;
         case 'sub':
        

        result=parseInt(fnum) - parseInt(snum);
        break;
         case 'multi':
        

        result=parseInt(fnum) * parseInt(snum);
        break;
         case 'div':
         

        result=parseInt(fnum) / parseInt(snum);
        break;

        default:
        alert("Select one Option for Perform task");
        break;
      }

   if (isNaN(result))  {
    alert("Enter Integer Value");

   }
   else{
     $("#result").val(result);
     $("#display").val(result);
   }
});
$("#clear").click(function(){
 $("#fnum").val("")
$("#snum").val("")
$("#result").val("")
$("input[type=radio][name=math]").prop('checked', false);
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
    switch(id){
       
        case 'add':
        
        result=parseInt(fnum) + parseInt(snum);
        break;
         case 'sub':
        

        result=parseInt(fnum) - parseInt(snum);
        break;
         case 'multi':
        

        result=parseInt(fnum) * parseInt(snum);
        break;
         case 'div':
         

        result=parseInt(fnum) / parseInt(snum);
        break;
        default:
        alert("Select one Option for Perform task");
        break;

      }
if (isNaN(result))  {
    alert("Enter Integer Value");

   }
   else{
     $("#result").val(result);
     $("#display").val(result);
   }
    };



 