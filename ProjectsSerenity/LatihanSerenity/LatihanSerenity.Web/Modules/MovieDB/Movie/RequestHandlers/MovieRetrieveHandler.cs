using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LatihanSerenity.MovieDB.MovieRow>;
using MyRow = LatihanSerenity.MovieDB.MovieRow;

namespace LatihanSerenity.MovieDB
{
    public interface IMovieRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieRetrieveHandler
    {
        public MovieRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}