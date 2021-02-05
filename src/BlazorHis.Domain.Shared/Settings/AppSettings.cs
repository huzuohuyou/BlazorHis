using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorHis.Settings
{
    public class _Default
    {
        public string BaseUrl { get; set; }
    }
    public class _RemoteServices
    {
        public _Default Default { get; set; }
    }

    public class AppSettings
    {
        public _RemoteServices RemoteServices { get; set; }
    }
}
