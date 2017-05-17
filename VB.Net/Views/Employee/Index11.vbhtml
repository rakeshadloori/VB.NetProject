@Code
    ViewData("Title") = "Index11"
End Code

<h2>Index11</h2>

@Using (Html.BeginForm("Index11", "Employee", FormMethod.Post))
    @<label>Delete By ID</label>
    @<input type = "text" name="id" value="@ViewBag.id" />
    @<input type = "submit" value="Delete" />
    @<h5>@ViewBag.res</h5>
End Using