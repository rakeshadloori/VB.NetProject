@ModelType EmpBO.EmpViewModel
@Code
    ViewData("Title") = "Data Adapter Multiple Tables"
End Code

<h2>Index2</h2>
<h4>Employee Table</h4>
<div class="row">
    <div class="col-xs-3">
        <label>Id</label>
    </div>
    <div class="col-xs-3">
        <label>Name</label>
    </div>
    <div class="col-xs-3">
        <label>Age</label>
    </div>
    <div class="col-xs-3">
        <label>Joinng Date</label>
    </div>

</div>
@For Each item In Model.ListEBO
    @<div Class="row">
        <div Class="col-xs-3">
            @item.EmpId
        </div>
        <div class="col-xs-3">
            @item.EmpName
        </div>
        <div class="col-xs-3">
            @item.EmpAge
        </div>
        <div class="col-xs-3">
            @item.EmpJoiningDate
        </div>
    </div>
Next


<h4>Employee Details Table</h4>
<div class="row">
    <div class="col-xs-3">
        <label>Id</label>
    </div>
    <div class="col-xs-3">
        <label>Emp Id</label>
    </div>
    <div class="col-xs-3">
        <label>Phone</label>
    </div>
    <div class="col-xs-3">
        <label>Email</label>
    </div>

</div>

@For Each item In Model.ListEmpDetails
    @<div class="row">
        <div class="col-xs-3">
            @item.EID
        </div>
        <div class="col-xs-3">
            @item.EDID
        </div>
        <div class="col-xs-3">
            @item.EDPhone
        </div>
        <div class="col-xs-3">
            @item.EDEmail
        </div>
    </div>
Next
