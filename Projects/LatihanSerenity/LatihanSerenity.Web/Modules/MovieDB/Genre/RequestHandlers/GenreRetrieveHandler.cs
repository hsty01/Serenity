using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LatihanSerenity.MovieDB.GenreRow>;
using MyRow = LatihanSerenity.MovieDB.GenreRow;

namespace LatihanSerenity.MovieDB
{
    public interface IGenreRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class GenreRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreRetrieveHandler
    {
        public GenreRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}