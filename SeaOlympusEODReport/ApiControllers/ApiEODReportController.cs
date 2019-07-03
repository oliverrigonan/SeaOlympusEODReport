using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SeaOlympusEODReport.ApiControllers
{
    public class ApiEODReportController : ApiController
    {
        // Data Context


        // List EOD Report
        [Authorize, HttpGet, Route("api/EODReport/list")]
        public List<Entities.EODReport> ListEODReport()
        {
            // Code here...

            return new List<Entities.EODReport>();
        }
    }
}
