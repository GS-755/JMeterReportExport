namespace JMeterReportExport.Models
{
    public class ReportNode
    {
        public string Label { get; set; }
        public int Samples { get; set; }
        public double Average { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double StdDev { get; set; }
        public double ErrorPercentage { get; set; }
        public double Throughput { get; set; }
        public double ReceivedKBPerSec { get; set; }
        public double SentKBPerSec { get; set; }
        public double AvgBytes { get; set; }
    }
}
