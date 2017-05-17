@ModelType EmpBO.EmpViewModel1
@Code
    ViewData("Title") = "Index8"
End Code

<h2>Index8</h2>

@Using (Html.BeginForm("Index8", "Employee", FormMethod.Post))
    @<div Class="row">
        <div Class="col-xs-4">@Html.LabelFor(Function(model) model.EBOObj.EmpName)</div>
        <div Class="col-xs-4">@Html.EditorFor(Function(model) model.EBOObj.EmpName)</div>
    </div>
    @<div Class="row">
        <div Class="col-xs-4">@Html.LabelFor(Function(Model) Model.EBOObj.EmpAge)</div>
        <div Class="col-xs-4">@Html.EditorFor(Function(Model) Model.EBOObj.EmpAge)</div>
    </div>
    @<div Class="row">
        <div Class="col-xs-4">@Html.LabelFor(Function(Model) Model.EBOObj.EmpJoiningDate)</div>
        <div Class="col-xs-4">@Html.EditorFor(Function(Model) Model.EBOObj.EmpJoiningDate)</div>
    </div>

    @<div Class="row">
        <div Class="col-xs-4">@Html.LabelFor(Function(Model) Model.EBOObj.EmpSalary)</div>
        <div Class="col-xs-4">@Html.EditorFor(Function(Model) Model.EBOObj.EmpSalary)</div>
    </div>

    @<div Class="row">
        <div Class="col-xs-4">@Html.LabelFor(Function(Model) Model.EmpDetailsObj.EDPhone)</div>
        <div Class="col-xs-4">@Html.EditorFor(Function(Model) Model.EmpDetailsObj.EDPhone)</div>
    </div>
    @<div Class="row">
        <div Class="col-xs-4">@Html.LabelFor(Function(Model) Model.EmpDetailsObj.EDEmail)</div>
        <div Class="col-xs-4">@Html.EditorFor(Function(Model) Model.EmpDetailsObj.EDEmail)</div>
    </div>
    @<div Class="row">
        <div Class="col-xs-4">@Html.LabelFor(Function(Model) Model.EmpDetailsObj.EDSalary)</div>
        <div Class="col-xs-4">@Html.EditorFor(Function(Model) Model.EmpDetailsObj.EDSalary)</div>
    </div>
    @<div class="row">
        <input type="submit" value="Insert" /> 
    </div>
End Using

