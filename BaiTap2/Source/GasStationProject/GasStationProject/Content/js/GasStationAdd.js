$(document).ready(function () {
    writeValueDistrict(); writeValueRating();
});

function writeValueRating(){
    let value = ( $("input[name='rating-gas']:checked").val() ) ;
    $("#Rating").val(value);
}
function writeValueDistrict(){
    let value = $("#selectDistrict").val();
    $("#District").val(value);
}
function writeValueGastype(){
    let list = $("input[name='selectTypeGas']:checked");
    let value ="" ;
    for (const item of list) {
        if(value !=""){
            value += ", "+ $(item).val();
        } else {value += $(item).val();}
    }
    $("#Gatype").val(value);
}

$(".group-gastype").click(function(){
    writeValueGastype();
})
$(".rating-gas").click(function(){
    writeValueRating();
})
$("#selectDistrict").change(function(){
    writeValueDistrict();
})
