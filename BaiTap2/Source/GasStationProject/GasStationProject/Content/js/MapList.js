$(document).ready(function () {
    let token = $("[name=__RequestVerificationToken]").val();
    renderData(token);


})

$("#search-with-query").click(function () {
    let token = $("[name=__RequestVerificationToken]").val();
    curentPage = 1;
    renderData(token);
    renderPagination();
})

//get data and render data
let renderData = (token, page = 1) => {
    $(".body-table").html('');
    $(".container_table_gas").append(renderWating());
    let dataSend = {
        gasName: $("#input-name-gas").val().toLowerCase(),
        gasType: gasType ? gasType : null,
        districtID: $("#selectDistrict").val() ? $("#selectDistrict").val() : null,
        selectPage: parseInt(page)
    }
    $.ajax({
        type: "POST",
        url: "../Home/gastationFillter",
        data: { __RequestVerificationToken: token, data: JSON.stringify(dataSend) },
        dataType: "json",
        success: function (response) {
            console.log(response)
            if (response) {
                renderMap(response)
            } else {
                $("#map-result").html(`<p>登録しました。</p>`);
            }
        }
    });

}

//Render table body


let renderMap = (listGasVM) => {
    
    function initMap() {  
        var map = new google.maps.Map(document.getElementById('map-result'), {
          zoom: 10,
          center: new google.maps.LatLng(listGasVM[0].Latitude, listGasVM[0].Longitude),
          mapTypeId: google.maps.MapTypeId.ROADMAP
        });
  
        var infowindow = new google.maps.InfoWindow();
  
        var marker, i;
        console.log(listGasVM[1].Latitude)
        for (i = 0; i < listGasVM.length; i++) {
            console.log(listGasVM[i].Latitude)
          marker = new google.maps.Marker({
            position: new google.maps.LatLng(listGasVM[i].Latitude, listGasVM[i].Longitude),
            map: map
          });

          google.maps.event.addListener(marker, 'click', (function (marker, i) {
            return function () {
                window.location = `/Feedback/Detail/${listGasVM[i].GasStationId}`
            }})(marker, i));

            google.maps.event.addListener(marker, 'mouseout', (function (marker, i) {
                return function () {
                  infowindow.setContent(null);
                  infowindow.open(map, marker);
                }})(marker, i));
  
          google.maps.event.addListener(marker, 'mouseover', (function (marker, i) {
            return function () {
              infowindow.setContent(listGasVM[i].GasStationName);
              infowindow.open(map, marker);
            }})(marker, i));


        }
    }
    initMap();

}



//render preload
let renderWating = () => {
    return (`
    <div class="ui-layout">
        <div class="ui-layout__sections">
            <div class="ui-layout__section ui-layout__section--primary">
                <div class="ui-layout__item">
                    <!-- *** YO *** -->
                    <!-- start rendering 'admin/reports/summary_cards/report_summary' with locals '[:section]'-->
                    <!-- start ui_card -->
                    <section class="ui-card reports-index-card">
                        <!-- SKELETON LOADING -->
                        <div class="loading-wrapper">
                            <div class="title-block">
                                <div class="loading title"></div>
                                <div class="loading content"></div>
                                <div class="loading content last-row"></div>
                            </div>
                            <div class="title-block">
                                <div class="loading title"></div>
                                <div class="loading content"></div>
                                <div class="loading content last-row"></div>
                            </div>
                            <div class="list-block">
                                <div class='loading content line-item'></div>
                                <div class='loading content line-item-last'></div>
                            </div>
                        </div>
                        <!-- END OF SKELETON LOADING -->
                    </section>
                    <!-- finish rendering ui_card -->
                </div>
            </div>
        </div>
    </div>    
    `);
}


//Setup for map
{
    var longiTude = 150.644;
    var latiTude = -34.397;
    function initMap() {
        var uluru = { lat: latiTude, lng: longiTude };
        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 12,
            center: uluru
        });
        var marker = new google.maps.Marker({
            position: uluru,
            map: map,
            icon: "https://developers.google.com/maps/documentation/javascript/examples/full/images/library_maps.png"
        });
    }

    let ishowMap = false;
    var cleartime = null;
    $("body").delegate(".name-gasStation", "mouseover", function (e) {
        $("#map").hide();
        longiTude = $(this).data().long;
        latiTude = $(this).data().lati;
        initMap();
        $("#map").css("left", e.pageX - $("#map").width() / 2).css("top", e.pageY - $("#map").height() - 20);
        cleartime = setTimeout(function () { $("#map").show() }, 500);
    });

    $("body").delegate("#map", "mouseout", function (e) {
        ishowMap = true;
    });
    $("body").delegate("#map", "mouseout", function (e) {
        setTimeout(function () { if (ishowMap) { ishowMap = false; } }, 500);
        $("#map").hide();
    });

    $("body").delegate(".name-gasStation", "mouseout", function (e) {
        if (!ishowMap) {
            clearTimeout(cleartime);
            $("#map").hide();
        }
    });
}

var curentPage = 1;

$("body").delegate( ".page-item" , "click", function () {
    let setPage;
    if ($(this).hasClass("controll")) {
        if (!$(this).hasClass("disabled")) {
            if ($(this).hasClass("controllerPre")) {
                setPage = curentPage - 1;
            }
            if ($(this).hasClass("controllerNext")) {
                setPage = curentPage + 1
            }
            if ($(this).hasClass("controllerFirst")) {
                setPage = 1
            }
            if ($(this).hasClass("controllerLast")) {
                setPage = $(".page-item").length - 4;
            }
        } else { return }

    } else {
        setPage = parseInt($(this).children().html()) ? parseInt($(this).children().html()) : curentPage;
    }

    if (setPage != curentPage) {
        let $listPageItem = $(".page-item");
        for (const item of $listPageItem) {
            if ($(item).children().html() == setPage) {
                $(item).addClass("active")
            } else { $(item).removeClass("active") }
        }
        if (setPage == 1) {
            $($listPageItem[0]).addClass("disabled");
            $($listPageItem[1]).addClass("disabled");
        } else { $($listPageItem[0]).removeClass(" disabled"); $($listPageItem[1]).removeClass(" disabled") }
        if (setPage == $listPageItem.length - 4) {
            $($listPageItem[$listPageItem.length - 2]).addClass("disabled");
            $($listPageItem[$listPageItem.length - 1]).addClass("disabled")
        } else {
            $($listPageItem[$listPageItem.length - 2]).removeClass("disabled");
            $($listPageItem[$listPageItem.length - 1]).removeClass("disabled")
        }
        curentPage = setPage;
        let token = $("[name=__RequestVerificationToken]").val();
        renderData(token, curentPage);
    }
});



let renderPagination = () => {
    $.ajax({
        type: "POST",
        url: "Home/getCountPage",
        success: function (response) {
            console.log(response.page)
            $(".pagination-box").html(setPagination(response.page));
        }
    });
}

let setPagination = (countPage) => {
    let result = `
    <nav aria-label="...">
        <ul class="pagination">
            <li class="page-item disabled  controll controllerFirst">
                <span class="page-link">First</span>
            </li>
            <li class="page-item disabled  controll controllerPre">
                <span class="page-link">Previous</span>
            </li>
            <li class="page-item active"><span class="page-link">1</span></li>   `;
    if (countPage > 1) {
        console.log(countPage);
        for (let i = 2; i <= Math.ceil(countPage/10) ; i++) {
            result += `<li class="page-item"><span class="page-link">${i}</span></li>`
        }
    }

    if (countPage <= 10) {
        result += `
        <li class="page-item disabled controll controllerNext">
            <span class="page-link">Next</span>
        </li>
        <li class="page-item disabled  controll controllerLast">
            <span class="page-link">Last</span>
        </li> `
    } else {
        result += `
        <li class="page-item controll controllerNext">
            <span class="page-link">Next</span>
        </li>
        <li class="page-item  controll controllerLast">
            <span class="page-link">Last</span>
        </li>
        `
    }
    result += ` </ul> </nav>`

    return result;
}

var gasType = "";
function writeValueGastype(){
    let list = $("input[name='selectTypeGas']:checked");
    let value ="" ;
    for (const item of list) {
        if(value !=""){
            value += ", "+ $(item).val();
        } else {value += $(item).val();}
    }
    gasType = value;
}

$(".group-gastype").click(function(){
    writeValueGastype();
})

//Show mape

    


