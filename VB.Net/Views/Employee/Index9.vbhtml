@Code
    ViewData("Title") = "Index9"
End Code

<h2>Index9</h2>

@Using (Html.BeginForm("Index9", "Employee", FormMethod.Post))
    @<label>Find Employee</label>
    @<input type = "text" name="emp" value="@ViewBag.emp"/>
    @<input type = "submit" value="Find">@<br />
    @<h5>@ViewBag.Bool1</h5>
End Using