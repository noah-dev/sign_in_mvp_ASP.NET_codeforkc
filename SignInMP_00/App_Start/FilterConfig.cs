﻿using System.Web;
using System.Web.Mvc;

namespace SignInMP_00
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
