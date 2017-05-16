@ModelType System.Data.DataTable
@Code
    ViewData("Title") = "Data Adapter Single Table"
End Code

<h2>GetEmpDataAdapter</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>

<div class="row">
    @For Each col As Data.DataColumn In Model.Columns
        @<div Class="col-xs-2">
            @col.ColumnName
        </div>
    Next
</div>

@For Each row As Data.DataRow In Model.Rows
    @<div class="row">
        @For Each col In row.ItemArray
            @<div Class="col-xs-2">
                @col

            </div>
        Next
    </div>
Next