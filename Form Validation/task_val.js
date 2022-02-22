function myfun(){
    var fname = document.val.fname;
	var lname = document.val.lname;
	var mob = document.val.mob;
	var email = document.val.email;
	var gender = document.val.gender;
	var add = document.val.add;
	var Country = document.val.Country;
	var state = document.val.state;
	var city = document.val.city;
	var pin = document.val.pin;
	var sameadd = document.val.sameadd;
	var adhar = document.val.adhar;
	var pan = document.val.pan;
if (fname.value.length <=0) {
	alert("Name Required");
	fname.focus();
	return false;
}
if (lname.value.length <=0) {
	alert("Last Name Required");
	lname.focus();
	return false;
}
if (mob.value.length !=10) {
    alert("Mobile Invalid");
	mob.focus();
	return false;
	
}
if (fname.value.length <=0  ) {
	alert("Name Required");
	fname.focus();
	return false;
}
if (email.value.length <=0) {
	alert("Email Required");
	email.focus();
	return false;
}
if (gender.value.length <=0) {
	alert("gender Required");
	gender.focus();
	return false;
}
if (add.value.length <=0) {
	alert("Address Required");
	address.focus();
	return false;
}
if (Country.value.length <=0) {
	alert("Country Required");
	Country.focus();
	return false;
}
if (state.value.length <=0) {
	alert("State Required");
	state.focus();
	return false;
}
if (city.value.length <=0) {
	alert("city Required");
	city.focus();
	return false;
}
if (pin.value.length !=6) {
	alert("Pin Invalid");
	pin.focus();
	return false;
}

if (adhar.value.length !=12) {
	alert("adhar Number Invalid");
	fname.focus();
	return false;
}
if (pan.value.length <=0) {
	alert("pan card Required");
	pan.focus();
	return false;
}
var check =false;
for (var i = sameadd.length - 1; i >= 0; i--) {
	if(sameadd[i].checked){
		check = true;
	}
}
if (check==false) {
	alert("Sameaddress Required")
	return false;
}
};
