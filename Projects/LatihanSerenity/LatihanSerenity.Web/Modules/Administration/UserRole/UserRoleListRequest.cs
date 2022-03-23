using Serenity.Services;

namespace LatihanSerenity.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}