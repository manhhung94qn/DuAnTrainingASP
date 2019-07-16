$(document).ready(function(){
    console.log("HIHIHI");

    // $("body").click(function(){
    //     $.ajax({
    //         type: "POST",
    //         url: "../Gasstation/listGasstation",
    //         data: {  },
    //         dataType: "json",
    //         success: function (response) {
    //             console.log(response);
    //         }
    //     });
    // });

})

var renderTable = (listGas)=> {
    

}

var renderWating = ()=>{
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

