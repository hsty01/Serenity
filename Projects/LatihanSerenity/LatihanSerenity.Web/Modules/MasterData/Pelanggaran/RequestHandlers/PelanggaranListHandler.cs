using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LatihanSerenity.MasterData.PelanggaranRow>;
using MyRow = LatihanSerenity.MasterData.PelanggaranRow;

namespace LatihanSerenity.MasterData
{
    public interface IPelanggaranListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PelanggaranListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPelanggaranListHandler
    {
        public PelanggaranListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}