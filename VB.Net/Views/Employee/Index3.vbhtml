@ModelType IEnumerable(Of EmpBO.EBO)
@Code
    ViewData("Title") = "Data Reader Single Table"
End Code

<h2>Index3</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmpId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmpName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmpAge)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmpSalary)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmpJoiningDate)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmpId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmpName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmpAge)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmpSalary)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmpJoiningDate)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
