using System.Collections.Generic;

namespace Core.Infrastructure.Data.Results
{
    public class ApiErrorResult
    {
        public List<ErrorData> data { get; set; }
        public class ErrorData
        {
            public string field { get; set; }
            public string message { get; set; }
        }
    }

}
