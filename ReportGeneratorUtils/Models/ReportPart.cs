﻿namespace ReportGeneratorUtils
{
    using System.Collections.Generic;

    public class ReportPart : IReportPart
    {
        public ReportPart(
            ReportSectionDisplayType reportPartType,
            string groupHeader,
            string groupFooter)
        {
            this.ReportPartType = reportPartType;
            this.GroupHeader = groupHeader;
            this.GroupFooter = groupFooter;
        }

        public string GroupHeader { get; }
        public IList<object> Parts { get; } = new List<object>();
        public string GroupFooter { get; }
        public ReportSectionDisplayType ReportPartType { get; }
    }
}
