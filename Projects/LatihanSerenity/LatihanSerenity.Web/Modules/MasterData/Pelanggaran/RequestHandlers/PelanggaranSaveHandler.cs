using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<LatihanSerenity.MasterData.PelanggaranRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LatihanSerenity.MasterData.PelanggaranRow;

namespace LatihanSerenity.MasterData
{
    public interface IPelanggaranSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PelanggaranSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPelanggaranSaveHandler
    {
        public PelanggaranSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}