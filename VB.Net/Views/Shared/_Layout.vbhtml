﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <!-- Q1 -->
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                            Q1
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("DataReader-Single", "Index3", "Employee")</li>
                            <li>@Html.ActionLink("DataReader-Multiple", "Index4", "Employee")</li>
                        </ul>
                    </li>

                    <!-- Q2 -->
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                            Q2
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("DataAdapter-Single", "Index1", "Employee")</li>
                            <li>@Html.ActionLink("DataAdapter-Multiple", "Index2", "Employee")</li>
                        </ul>
                    </li>

                    <!-- Q3 -->
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                            Q3
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Scalar-Value", "Index5", "Employee")</li>
                        </ul>
                    </li>

                    <!-- Q4 -->
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                            Q4
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("PK-Create", "Index5", "Employee")</li>
                            <li>@Html.ActionLink("PKFK - Create", "Index8", "Employee")</li>
                        </ul>
                    </li>

                    <!-- Q5 -->
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                            Q5
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Bool-User", "Index9", "Employee")</li>
                        </ul>
                    </li>

                    <!-- Q6 -->
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                            Q6
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Multipe-Insert", "Index10", "Employee")</li>
                        </ul>
                    </li>

                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                            Q7
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("UserDefined-Table", "Index15", "Employee")</li>
                        </ul>
                    </li>

                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                            Q8
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Find-User", "Index14", "Employee")</li>
                        </ul>
                    </li>

                    <!-- Q9 -->
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                            Q9
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Check-Delete", "Index11", "Employee")</li>
                        </ul>
                    </li>

                    <!-- Q10 -->
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                            Q10
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Update-Salary", "Index12", "Employee")</li>
                        </ul>
                    </li>

                    <li>@Html.ActionLink("Sub-Layout", "ChildLayout", "Employee")</li>

                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
