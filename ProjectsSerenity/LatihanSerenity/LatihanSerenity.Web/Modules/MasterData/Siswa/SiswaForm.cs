using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace LatihanSerenity.MasterData.Forms
{
    [FormScript("MasterData.Siswa")]
    [BasedOnRow(typeof(SiswaRow), CheckNames = true)]
    public class SiswaForm
    {
        public Int32 Nis { get; set; }
        public String Nama { get; set; }
        public String KotaAsal { get; set; }
        public DateTime TglLahir { get; set; }
        public Int32 Umur { get; set; }
        [Category("Detail Pelanggaran")]
        [PelanggaranDetailEditor]
        public List<PelanggaranRow> DetailPelanggaran { get; set; }
    }
}