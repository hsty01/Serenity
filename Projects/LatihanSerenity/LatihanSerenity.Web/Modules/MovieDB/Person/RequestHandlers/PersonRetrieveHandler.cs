﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LatihanSerenity.MovieDB.PersonRow>;
using MyRow = LatihanSerenity.MovieDB.PersonRow;

namespace LatihanSerenity.MovieDB
{
    public interface IPersonRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PersonRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonRetrieveHandler
    {
        public PersonRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}