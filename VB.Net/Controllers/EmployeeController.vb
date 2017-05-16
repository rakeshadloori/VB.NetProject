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
    End Class
End Namespace