using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LatihanSerenity.MasterData.PelanggaranRow>;
using MyRow = LatihanSerenity.MasterData.PelanggaranRow;

namespace LatihanSerenity.MasterData
{
    public interface IPelanggaranRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PelanggaranRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPelanggaranRetrieveHandler
    {
        public PelanggaranRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}