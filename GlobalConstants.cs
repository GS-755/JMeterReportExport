namespace JMeterReportExport
{ 
    using System;
    using System.IO;
    using System.Reflection;
    using OSVersionExtension;

    public class GlobalConstants
    {
        public static readonly string OS_VERSION =
            $"{OSVersion.GetOperatingSystem()} (Build {OSVersion.GetOSVersion().Version.Major}." +
            $"{OSVersion.GetOSVersion().Version.Minor}." +
            $"{OSVersion.GetOSVersion().Version.Build})";
        public static readonly string APP_NAME = "JMeter Report Export"; 
        public static readonly string APP_VERSION = "1.0.3-final";
        public static readonly string 
            APP_COPYRIGHT = $"{DateTime.Now.Year} @GS-755. Licensed under MIT License";
        public static readonly string
            EXCEL_TEMPLATE = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\Templates\\Template.xlsx"; 
    }
}
