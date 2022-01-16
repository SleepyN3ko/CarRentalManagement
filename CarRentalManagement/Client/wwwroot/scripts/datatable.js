function AddDataTable(table) {
    $(document).ready(function () {
        $(table).DataTable().columns.adjust();
    })
}
function DataTablesDispose(table) {
    $(document).ready(function () {
        $(table).DataTable().destroy();
        var element = document.querySelector(table + '_wrapper');
        element.parentNode.removeChild(element);
    })

}