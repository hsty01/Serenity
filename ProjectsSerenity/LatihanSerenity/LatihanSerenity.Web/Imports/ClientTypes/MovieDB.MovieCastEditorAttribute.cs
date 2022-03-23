using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace LatihanSerenity.MovieDB
{
    public partial class MovieCastEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "LatihanSerenity.MovieDB.MovieCastEditor";

        public MovieCastEditorAttribute()
            : base(Key)
        {
        }
    }
}
