﻿using System.Web;
using System.Web.Mvc;

namespace ErrorHandling
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new Helpers.CustomErrorHandlingAttribute());
          filters.Add(new HandleErrorAttribute());

        }
    }
}
