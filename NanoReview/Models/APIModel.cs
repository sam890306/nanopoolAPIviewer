using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NanoReview.Models
{
    public class ApiModel
    {
        public bool Status { get; set; }
        public string Data { get; set; }
        public string Error { get; set; }
    }

    public class ApiModelAverageHashrate
    {
        public bool Status { get; set; }
        public Data DataActual { get; set; }

        public class Data
        {
            public decimal H1Decimal { get; set; }
            public decimal H2Decimal { get; set; }
            public decimal H3Decimal { get; set; }
            public decimal H4Decimal { get; set; }

        }

        public string Error { get; set; }
    }

    public class ApiModelChartData
    {
        public bool Status { get; set; }
        public Data DataActual { get; set; }
        public class Data
        {
            public decimal H1Decimal { get; set; }
            public decimal H2Decimal { get; set; }
            public decimal H3Decimal { get; set; }
            public decimal H4Decimal { get; set; }

        }

        public string Error { get; set; }
    }



}