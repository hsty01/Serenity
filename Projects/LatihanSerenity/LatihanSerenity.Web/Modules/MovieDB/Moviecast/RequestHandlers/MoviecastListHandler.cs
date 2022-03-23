using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LatihanSerenity.MovieDB.MoviecastRow>;
using MyRow = LatihanSerenity.MovieDB.MoviecastRow;

namespace LatihanSerenity.MovieDB
{
    public interface IMoviecastListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MoviecastListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMoviecastListHandler
    {
        public MoviecastListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}