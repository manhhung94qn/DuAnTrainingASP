$(document).ready(function(){
    let token = $("[name=__RequestVerificationToken]").val();
    renderData(token);  

})

$("#search-with-query").click(function(){
    let token = $("[name=__RequestVerificationToken]").val();
    renderData(token);
})


let renderData = (token)=>{
    $(".body-table").html('');
    $(".container_table_gas").append(renderWating());
    let dataSend = {
        gasName: $("#input-name-gas").val() ,
        
        gasType:  $("input[name='selectTypeGas']:checked").val()?$("input[name='selectTypeGas']:checked").val(): null ,
        districtID: $("#selectDistrict").val() ?  $("#selectDistrict").val(): null

    }
    $.ajax({
        type: "POST",
        url: "../Home/gastationFillter",
        data: {__RequestVerificationToken: token, data: JSON.stringify(dataSend)},
        dataType: "json",
        success: function (response) {
            $(".body-table").html( renderTableBody(response) );
            $(".ui-layout").remove();
        }}
        );
}

let renderTableBody = (listGasVM)=> {
    let result = ``;
    for (let item of listGasVM) {
        result += ` 
            <tr>
                <td> ${item.GasStationName} </td>
                <td> ${item.GasType} </td>
                <td> ${item.DistrictName} </td>
                <td> ${item.Longitude}, ${item.Latitude} </td>
                <td> ${item.Rating} </td>
                <td>
                    <button class="btn btn-info">Edit</button>
                    <button class="btn btn-danger">Del</button>
                </td>
            </tr>
        `
    }
    return result;
}


let renderWating = ()=>{
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


