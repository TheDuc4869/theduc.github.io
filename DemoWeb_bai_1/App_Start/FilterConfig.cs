﻿using System.Web;
using System.Web.Mvc;

namespace DemoWeb_bai_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
