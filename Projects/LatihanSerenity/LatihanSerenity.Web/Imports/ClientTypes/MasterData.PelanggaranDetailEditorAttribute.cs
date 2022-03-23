using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace LatihanSerenity.MasterData
{
    public partial class PelanggaranDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "LatihanSerenity.MasterData.PelanggaranDetailEditor";

        public PelanggaranDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}
