namespace LatihanSerenity.MovieDB {
    @Serenity.Decorators.registerEditor()
    export class MovieCastEditor
        extends Serenity.Extensions.GridEditorBase<MoviecastRow> {
        protected getColumnsKey() { return "MovieDB.Moviecast"; }
        protected getDialogType() { return MovieCastEditDialog; }
        protected getLocalTextPrefix() { return MoviecastRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }

        protected validateEntity(row: MoviecastRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;        

            row.PersonFullname = PersonRow.getLookup()
                .itemById[row.PersonId].Fullname;

            return true;
        }
    }
} 