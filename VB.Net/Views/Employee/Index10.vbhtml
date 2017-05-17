@ModelType List(Of EmpBO.EBO)
@Code
    ViewData("Title") = "Index10"
End Code

<h2>Index10</h2>

@Using (Html.BeginForm("Index10", "Employee", FormMethod.Post))
    For i As Int32 = 0 To 1
        @<div Class="row">
            <div Class="col-xs-3">
                <Label> Name</label>
                @Html.EditorFor(Function(Model) Model(i).EmpName)
             </div>
            <div Class="col-xs-3">
                <Label> Age</label>
                @Html.EditorFor(Function(Model) Model(i).EmpAge)
            </div>
            <div Class="col-xs-3">
                <Label> Joining Date</label>
                @Html.EditorFor(Function(Model) Model(i).EmpJoiningDate)
            </div>
            <div Class="col-xs-3">
                <Label> Salary</label>
                @Html.EditorFor(Function(Model) Model(i).EmpSalary)
            </div>
        </div>
    Next
   @<input type = "submit" value="insert" />
End Using   
