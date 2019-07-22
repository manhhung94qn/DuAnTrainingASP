var url_string = window.location.href; //window.location.href
var hrefLink = new URL(url_string);
var idGastation = hrefLink.pathname.split("/")[3];
var startText = $(".content-feedback").html();
$(document).ready(function () {


    renderData(idGastation);
})


let renderData = (_idGas, _page = 1) => {

    $(".content-feedback").html(renderWating())

    let dataSend = {
        Id: _idGas,
        page: _page
    }

    $.ajax({
        type: "POST",
        url: "../getFeedback",
        data: { data: JSON.stringify(dataSend) },
        dataType: "json",
        success: function (response) {
            if (response.length > 0) {
                setTimeout(function(){
                    $(".content-feedback").html(renderListFeedback(response))
                }, 500);
            } else {
                $(".content-feedback").html(startText)
            }
        }
    })
}
var curentPage = 1;
$(".page-item").click(function () {
    let setPage;

    if ($(this).hasClass("controll") && !$(this).hasClass("disabled")) {
        if ($(this).hasClass("controllerPre")) {
            setPage = curentPage - 1;
        } else { setPage = curentPage + 1 }
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
            $($listPageItem[0]).addClass("disabled")
        } else { $($listPageItem[0]).removeClass(" disabled") }
        if (setPage == $listPageItem.length - 2) {
            $($listPageItem[$listPageItem.length - 1]).addClass("disabled")
        } else { $($listPageItem[$listPageItem.length - 1]).removeClass("disabled") }
        curentPage = setPage;
        renderData(idGastation, curentPage);
    }



    // renderData(idGastation, getPage);
})


let renderListFeedback = (listFeedback) => {
    let result = ``;
    for (const item of listFeedback) {
        result += `
            <div class="card w-100">
                <div class="card-body">
                    <h5 class="card-title">${convertTime(item.FeedbackAt)}</h5>
                    <p class="card-text">${item.Feedback}</p>
                </div>
            </div>
        `
    }
    return result;
}
let convertTime = (_time) => {
    let time = new Date(_time);
    return time.getFullYear() + "年" + time.getMonth() + "月" + time.getDate() + "日"
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