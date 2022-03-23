using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace LatihanSerenity.MasterData.Columns
{
    [ColumnsScript("MasterData.Pelanggaran")]
    [BasedOnRow(typeof(PelanggaranRow), CheckNames = true)]
    public class PelanggaranColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Hidden]
        public Int32 Id { get; set; }
        [EditLink]
        public String Pelanggaran { get; set; }
        public DateTime TglPelanggaran { get; set; }
        public String Keterangan { get; set; }
    }
}