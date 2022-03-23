
namespace LatihanSerenity.MasterData {

    @Serenity.Decorators.registerEditor("LatihanSerenity.PelanggaranDetailEditor")
    export class PelanggaranDetailEditor extends Serenity.Extensions.GridEditorBase<PelanggaranRow> {
        protected getColumnsKey() { return PelanggaranColumns.columnsKey; }
        protected getDialogType() { return PelanggaranDetailEditorDialog; }
        protected getLocalTextPrefix() { return PelanggaranRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
        protected getAddButtonCAption() {
            return "Add";
        
        }
    }
}