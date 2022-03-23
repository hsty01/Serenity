 using FluentMigrator;
using Serenity.Extensions;
using System;

namespace LatihanSerenity.Migrations.DefaultDB
{
    [Migration(20210210_130000)]
    public class DefaultDB_20210210_130000_PersonAndMovieCast : Migration
    {
        public override void Up()
        {
            Create.Table("Person")
                .WithColumn("PersonId").AsInt32().Identity()
                    .PrimaryKey().NotNullable()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("Lastname").AsString(50).NotNullable()
                .WithColumn("BirthDate").AsDateTime().Nullable()
                .WithColumn("BirthPlace").AsString(100).Nullable()
                .WithColumn("Gender").AsInt32().Nullable()
                .WithColumn("Height").AsInt32().Nullable();

            Create.Table("MovieCast")
                .WithColumn("MovieCastId").AsInt32().Identity()
                    .PrimaryKey().NotNullable()
                .WithColumn("MovieId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieCast_MovieId", "Movie", "MovieId")
                .WithColumn("PersonId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieCast_PersonId", "Person", "PersonId")
                .WithColumn("Character").AsString(50).Nullable();
        }


        public override void Down()
        {
        }
    }
}