using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<LatihanSerenity.MovieDB.MoviecastRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LatihanSerenity.MovieDB.MoviecastRow;

namespace LatihanSerenity.MovieDB
{
    public interface IMoviecastSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MoviecastSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMoviecastSaveHandler
    {
        public MoviecastSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}