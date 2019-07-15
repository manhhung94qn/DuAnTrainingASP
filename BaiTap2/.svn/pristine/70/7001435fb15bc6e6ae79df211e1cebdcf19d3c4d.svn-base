using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GasStationProject.App_Core
{
    public abstract class WebViewPageExtention<T> : WebViewPage<T>
    {
        public override void InitHelpers()
        {
            base.InitHelpers();
        }

        public override void Execute()
        {
        }


        public IHtmlString RawEncode(string value)
        {
            return Html.Raw(Html.Encode(value));
        }

    }
}