using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LatihanSerenity.MovieDB.MoviecastRow;

namespace LatihanSerenity.MovieDB
{
    public interface IMoviecastDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MoviecastDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMoviecastDeleteHandler
    {
        public MoviecastDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}