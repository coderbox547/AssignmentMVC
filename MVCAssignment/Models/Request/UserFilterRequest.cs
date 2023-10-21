using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models.Request
{
    public class UserFilterRequest
    {
        public string FieldName { get; set; }
        public string Value { get; set; }
    }
}