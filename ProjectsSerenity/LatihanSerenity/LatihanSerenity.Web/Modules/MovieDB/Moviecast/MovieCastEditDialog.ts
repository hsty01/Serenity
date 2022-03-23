namespace LatihanSerenity.MovieDB {

    @Serenity.Decorators.registerClass()
    export class MovieCastEditDialog extends
        Serenity.Extensions.GridEditorDialog<MoviecastRow> {
        protected getFormKey() { return MoviecastForm.formKey; }
        protected getNameProperty() { return MoviecastRow.nameProperty; }
        protected getLocalTextPrefix() { return MoviecastRow.localTextPrefix; }

        protected form: MoviecastForm;

        constructor() {
            super();
            this.form = new MoviecastForm(this.idPrefix);
        }
    }
}