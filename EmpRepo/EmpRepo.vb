Imports System.Configuration
Imports System.Data.SqlClient
Imports EmpBO

Public Class EmpRepo
    Public Shared Function getEmployeeDA() As DataTable
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        conn.Open()
        Dim dt As DataTable = New DataTable
        Try
            Dim cmd As SqlCommand = New SqlCommand
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "spGetEmp"
            Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter()
            dataAdapter.SelectCommand = cmd
            dataAdapter.Fill(dt)
        Catch ex As Exception

        Finally
            conn.Close()
        End Try

        Return dt
    End Function

    Public Shared Function getMultipleDA() As EmpViewModel
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        Dim vm As EmpViewModel = New EmpViewModel
        conn.Open()
        Dim dt As DataTable = New DataTable
        Dim ds As DataSet = New DataSet
        Try
            Dim cmd As SqlCommand = New SqlCommand
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "spMultitableData"
            Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter()
            dataAdapter.SelectCommand = cmd
            dataAdapter.Fill(ds)

            Dim l1 As List(Of EmpBO.EBO) = New List(Of EmpBO.EBO)
            Dim l2 As List(Of EmpBO.EmpDetails) = New List(Of EmpBO.EmpDetails)
            Dim dt1 As DataTable = ds.Tables(0)
            For Each dr In dt1.Rows
                Dim db As EmpBO.EBO = New EmpBO.EBO
                db.EmpId = dr("Id")
                db.EmpName = dr("Name")
                db.EmpAge = dr("Age")
                db.EmpJoiningDate = dr("JoiningDate")
                l1.Add(db)
            Next

            Dim dt2 As DataTable = ds.Tables(1)
            For Each dr In dt2.Rows
                Dim db As EmpBO.EmpDetails = New EmpBO.EmpDetails
                db.EID = dr("Id")
                db.EDID = dr("EmpID")
                db.EDPhone = dr("Phone")
                db.EDEmail = dr("Email")
                l2.Add(db)
            Next



            vm.ListEBO = l1
            vm.ListEmpDetails = l2

        Catch ex As Exception

        Finally
            conn.Close()
        End Try

        Return vm

    End Function


    Public Shared Function getEmployeeDR() As List(Of EBO)
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        conn.Open()
        Dim l1 As List(Of EBO) = New List(Of EBO)
        Try
            Dim cmd As SqlCommand = New SqlCommand
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "spGetEmp"
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While (dr.Read())
                Dim eb As EBO = New EBO
                eb.EmpId = Convert.ToInt32(dr("Id")).ToString()
                eb.EmpName = dr("Name")
                eb.EmpAge = dr("Age")
                eb.EmpJoiningDate = dr("JoiningDate")
                l1.Add(eb)
            End While

        Catch ex As Exception

        Finally
            conn.Close()
        End Try

        Return l1
    End Function

    Public Shared Function getEmployeeMultipleDR() As EmpViewModel
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        conn.Open()
        Dim l As EmpViewModel = New EmpViewModel
        Dim l1 As List(Of EBO) = New List(Of EBO)
        Dim l2 As List(Of EmpDetails) = New List(Of EmpDetails)
        Try
            Dim cmd As SqlCommand = New SqlCommand
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "spMultitableData"
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While (dr.Read())
                Dim eb As EBO = New EBO
                eb.EmpId = Convert.ToInt32(dr("Id")).ToString()
                eb.EmpName = dr("Name")
                eb.EmpAge = dr("Age")
                eb.EmpJoiningDate = dr("JoiningDate")
                l1.Add(eb)
                'Hi
            End While

            dr.NextResult()
            While (dr.Read())
                Dim eb As EmpDetails = New EmpDetails
                eb.EID = dr("Id")
                eb.EDID = dr("EmpID")
                eb.EDPhone = dr("Phone")
                eb.EDEmail = dr("Email")
                l2.Add(eb)
            End While

        Catch ex As Exception

        Finally
            conn.Close()
        End Try
        l.ListEBO = l1
        l.ListEmpDetails = l2
        Return l
    End Function
End Class
