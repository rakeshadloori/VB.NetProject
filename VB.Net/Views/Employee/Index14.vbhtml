@ModelType  EmpBO.EBO
@Code
    ViewData("Title") = "Index14"
End Code

<h2>Index14</h2>

@Using (Html.BeginForm("Index14", "Employee", FormMethod.Post))
    @<input type = "text" name="name" value="@ViewBag.Name" />
    @<input type = "submit" value="Find" />
End Using

<br />

@If (Model IsNot Nothing) Then
        @<div Class="row">
            <div Class="col-xs-2"><label>Name</label></div>
            <div Class="col-xs-2"><label>Age</label></div>
            <div Class="col-xs-2"><label>JoiningDate</label></div>
            <div Class="col-xs-2"><label>Salary</label></div>
    </div>
    @<div Class="row">
        <div Class="col-xs-2">@Model.EmpName</div>
        <div Class="col-xs-2">@Model.EmpAge</div>
        <div Class="col-xs-2">@Model.EmpJoiningDate</div>
        <div Class="col-xs-2">@Model.EmpSalary</div>
    </div>
Else
        @ViewBag.Msg
End If