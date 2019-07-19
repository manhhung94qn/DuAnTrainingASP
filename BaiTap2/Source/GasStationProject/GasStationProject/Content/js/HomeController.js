$(document).ready(function () {
    let token = $("[name=__RequestVerificationToken]").val();
    renderData(token);
    $("#map").hide();

})

$("#search-with-query").click(function () {
    let token = $("[name=__RequestVerificationToken]").val();
    renderData(token);
})

$(".name-gasStation").click(function () {
    console.log("OKI")
})

{
    var pageCurent = 1;
    $(".select-page").click(function () {        
        for (const item of $(".page-item")) {
            $(item).removeClass("active");
        }
        let token = $("[name=__RequestVerificationToken]").val();
        pageCurent = parseInt($(this).text());
        renderData(token, pageCurent);
        $(this).parent().addClass("active");
    })
}

let renderData = (token, page=1) => {
    $(".body-table").html('');
    $(".container_table_gas").append(renderWating());
    let dataSend = {
        gasName: $("#input-name-gas").val(),
        gasType: $("input[name='selectTypeGas']:checked").val() ? $("input[name='selectTypeGas']:checked").val() : null,
        districtID: $("#selectDistrict").val() ? $("#selectDistrict").val() : null,
        selectPage: parseInt(page)
    }
    $.ajax({
        type: "POST",
        url: "../Home/gastationFillter",
        data: { __RequestVerificationToken: token, data: JSON.stringify(dataSend) },
        dataType: "json",
        success: function (response) {
            if (response) {
                $(".body-table").html(renderTableBody(response));
            } else {
                $(".body-table").html(`<p>登録しました。</p>`);                
            }
            $(".ui-layout").remove();
        }
    }
    );
}

let renderTableBody = (listGasVM) => {
    let result = ``;
    for (let item of listGasVM) {
        result += ` 
            <tr>
                <td class="name-gasStation w-25" data-long=${item.Longitude} data-lati=${item.Latitude}> ${item.GasStationName} </td>
                <td> ${item.GasType} </td>
                <td> ${item.DistrictName} </td>
                <td> ${item.Longitude}, ${item.Latitude} </td>
                <td> ${item.Rating} </td>
                <td class="d-flex  justify-content-between" >
                    <a href="../Gasstation/edit/${item.GasStationId}" class="btn btn-info">Edit</a>
                    <a href="../Gasstation/delete/${item.GasStationId}" class="btn btn-danger">Del</a>
                </td>
            </tr>
        `
    }
    return result;
}

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

{
    var longiTude = 150.644;
    var latiTude = -34.397;
    function initMap() {
        var uluru = { lat: latiTude, lng: longiTude };
        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 8,
            center: uluru
        });
        var marker = new google.maps.Marker({
            position: uluru,
            map: map,
            icon: "https://developers.google.com/maps/documentation/javascript/examples/full/images/library_maps.png"
        });
    }

    let ishowMap = false;
    $("body").delegate(".name-gasStation", "mouseover", function (e) {
        longiTude = $(this).data().long;
        latiTude = $(this).data().lati;
        initMap();
        $("#map").css("left", e.pageX - $("#map").width() / 2).css("top", e.pageY - $("#map").height() + 2);
        $("#map").show();
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
            $("#map").hide();
        }
    });
}