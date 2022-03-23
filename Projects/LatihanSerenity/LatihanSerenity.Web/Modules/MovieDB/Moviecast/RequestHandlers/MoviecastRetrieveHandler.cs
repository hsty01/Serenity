using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LatihanSerenity.MovieDB.MoviecastRow>;
using MyRow = LatihanSerenity.MovieDB.MoviecastRow;

namespace LatihanSerenity.MovieDB
{
    public interface IMoviecastRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MoviecastRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMoviecastRetrieveHandler
    {
        public MoviecastRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}