var startY = 1900;
var endY = new Date().getFullYear();
var options = "";
for(var year = startY ; year <=endY; year++){
  options += "<option>"+ year +"</option>";
}
document.getElementById("datePickerYear").innerHTML = options;

var startM = 1;
var endM = 12;
var options = "";
for(var year = startM ; year <=endM; year++){
  options += "<option>"+ year +"</option>";
}
document.getElementById("datePickerMonth").innerHTML = options;

var startD = 1;
var endD = 31;
var options = "";
for(var year = startD ; year <=endD; year++){
  options += "<option>"+ year +"</option>";
}
document.getElementById("datePickerDay").innerHTML = options;