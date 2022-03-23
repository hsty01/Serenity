using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace LatihanSerenity.MovieDB.Forms
{
    [FormScript("MovieDB.Moviecast")]
    [BasedOnRow(typeof(MoviecastRow), CheckNames = true)]
    public class MoviecastForm
    {
        public Int32 PersonId { get; set; }
        public String Character { get; set; }
    }
}