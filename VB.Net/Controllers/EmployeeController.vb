Imports System.Web.Mvc
Imports EmpBO
Imports EmpRepo

Namespace Controllers
    Public Class EmployeeController
        Inherits Controller

        ' GET: Employee
        Function Index1() As ActionResult
            Dim da As DataTable = EmpRepo.EmpRepo.getEmployeeDA()
            Return View(da)
        End Function

        Function Index2() As ActionResult
            Dim list As EmpViewModel = EmpRepo.EmpRepo.getMultipleDA()
            Return View(list)
        End Function

        Function Index3() As ActionResult
            Dim list As List(Of EmpBO.EBO) = EmpRepo.EmpRepo.getEmployeeDR()
            Return View(list)
        End Function

        Function Index4() As ActionResult
            Dim vm As EmpViewModel = EmpRepo.EmpRepo.getEmployeeMultipleDR()
            Return View(vm)
        End Function

        'Scalar value
        Function Index5() As ActionResult
            Return View()
        End Function

        'Get Scalar value (Primary Key) after inserting record
        <HttpPost()>
        Function Index6(emp As EBO) As ActionResult
            Dim id As Int32 = EmpRepo.EmpRepo.getScalarValue(emp)
            ViewBag.id = id
            Return View(emp)
        End Function

        'Insert data get Pk And use Pk to update Fk table data
        Function Index8() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function Index8(emp As EmpBO.EmpViewModel1) As ActionResult
            Dim pk As Int32 = EmpRepo.EmpRepo.insertIntoTwoTables(emp)
            Return RedirectToAction("Index1")
        End Function

        'Bool
        Function Index9() As ActionResult
            ViewBag.emp = TempData("emp")
            ViewBag.Bool1 = TempData("val")
            Return View()
        End Function

        <HttpPost()>
        Function Index9(emp As String) As ActionResult
            Dim id As String = EmpRepo.EmpRepo.findEmployee(emp)
            TempData("emp") = emp
            TempData("val") = id
            Return RedirectToAction("Index9")
        End Function

        Function Index10() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function Index10(emp As List(Of EmpBO.EBO)) As ActionResult
            EmpRepo.EmpRepo.MultipleInsert(emp)
            Return RedirectToAction("Index1")
        End Function
        Function Index11() As ActionResult
            ViewBag.res = TempData("user")
            ViewBag.id = TempData("id")
            Return View()
        End Function

        <HttpPost()>
        Function Index11(id As Int32) As ActionResult
            Dim res As String = EmpRepo.EmpRepo.checkUser(id)
            TempData("id") = id
            TempData("User") = res
            Return RedirectToAction("Index11")
        End Function

        Function Index12() As ActionResult
            ViewBag.res = TempData("res")
            Return View()
        End Function

        <HttpPost()>
        Function Index13() As ActionResult
            Dim res As String = EmpRepo.EmpRepo.updateSalary()
            TempData("res") = res
            Return RedirectToAction("Index12")
        End Function

        Function Index14() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function Index14(Name As String) As ActionResult
            Dim ob As Object = EmpRepo.EmpRepo.UserInfo(Name)
            ViewBag.Name = Name
            If (ob.GetType = GetType(EBO)) Then
                Return View(ob)
            Else
                ViewBag.Msg = ob
                Return View()
            End If


        End Function


        Function Index15() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function Index15(emp As EmpBO.EBO) As ActionResult
            Dim res As String = EmpRepo.EmpRepo.UDT(emp)
            Return RedirectToAction("Index1")
        End Function
    End Class
End Namespace