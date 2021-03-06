using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;

namespace LatihanSerenity.MasterData
{
    [ConnectionKey("MasterData"), Module("MasterData"), TableName("siswa")]
    [DisplayName("Siswa"), InstanceName("Siswa")]
    [ReadPermission("MasterData:View")]
    [ModifyPermission("MasterData:Modify")]
    public sealed class SiswaRow : Row<SiswaRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Nis"), Column("NIS")]
        public Int32? Nis
        {
            get => fields.Nis[this];
            set => fields.Nis[this] = value;
        }

        [DisplayName("Nama"), Size(50), QuickSearch, NameProperty]
        public String Nama
        {
            get => fields.Nama[this];
            set => fields.Nama[this] = value;
        }

        [DisplayName("Kota Asal"), Size(50)]
        public String KotaAsal
        {
            get => fields.KotaAsal[this];
            set => fields.KotaAsal[this] = value;
        }

        [DisplayName("Tgl Lahir")]
        public DateTime? TglLahir
        {
            get => fields.TglLahir[this];
            set => fields.TglLahir[this] = value;
        }

        [DisplayName("Umur")]
        public Int32? Umur
        {
            get => fields.Umur[this];
            set => fields.Umur[this] = value;
        }

        [DisplayName("Detail Pelanggaran"), MasterDetailRelation(foreignKey: "IdSiswa"), NotMapped]
        public List<PelanggaranRow> DetailPelanggaran
        {
            get => fields.DetailPelanggaran[this];
            set => fields.DetailPelanggaran[this] = value;
        }

        public SiswaRow()
            : base()
        {
        }

        public SiswaRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field Nis;
            public StringField Nama;
            public StringField KotaAsal;
            public DateTimeField TglLahir;
            public Int32Field Umur;
            public RowListField<PelanggaranRow> DetailPelanggaran;
        }
    }
}
