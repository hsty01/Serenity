namespace LatihanSerenity.MovieDB {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'LatihanSerenity.MovieDB.MovieKind', 'MovieDB.MovieKind');
}
