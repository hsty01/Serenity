using Serenity.Services;
using System;
using System.Collections.Generic;

namespace LatihanSerenity.Administration
{
    public class UserRoleUpdateRequest : ServiceRequest
    {
        public Int32? UserID { get; set; }
        public List<Int32> Roles { get; set; }
    }
}