using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace LatihanSerenity.MasterData.Columns
{
    [ColumnsScript("MasterData.Siswa")]
    [BasedOnRow(typeof(SiswaRow), CheckNames = true)]
    public class SiswaColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public Int32 Nis { get; set; }
        [EditLink]
        public String Nama { get; set; }
        public String KotaAsal { get; set; }
        public DateTime TglLahir { get; set; }
        public Int32 Umur { get; set; }
    }
}