@Code
    ViewData("Title") = "Index12"
End Code

<h2>Index12</h2>

@Using (Html.BeginForm("Index13", "Employee", FormMethod.Post))
    @<input type = "submit" value="Update Salary" />
    @<h5>@ViewBag.res</h5>
End Using