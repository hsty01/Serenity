using FluentMigrator;
using Serenity.Extensions;
using System;

namespace LatihanSerenity.Migrations.DefaultDB
{
    [Migration(20210210_104100)]
    public class DefaultDB_20210210_104100_MovieGenres : Migration
    {
        public override void Up()
        {
             Create.Table("MovieGenres")
                .WithColumn("MovieGenreId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("MovieId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieGenres_MovieId", "Movie", "MovieId")
                .WithColumn("GenreId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieGenres_GenreId", "Genre", "GenreId");

            Execute.Sql(
              @"INSERT INTO MovieGenres (MovieId, GenreId) 
                    SELECT m.MovieId, m.GenreId 
                    FROM Movie m 
                    WHERE m.GenreId IS NOT NULL");

            Delete.ForeignKey("FK_Movie_GenreId")
                .OnTable("Movie");
            Delete.Column("GenreId")
                .FromTable("Movie");
        }


        public override void Down()
        {
        }
    }
}