﻿using System.Web;
using System.Web.Mvc;

namespace LabThurs0717
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
