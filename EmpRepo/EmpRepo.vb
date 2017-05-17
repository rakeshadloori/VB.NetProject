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


    Public Shared Function getScalarValue(emp As EBO) As Int32
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        conn.Open()
        Dim id As Int32 = 0
        Try
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "spInsertEmp"
            cmd.Parameters.AddWithValue("@Name", emp.EmpName)
            cmd.Parameters.AddWithValue("@Age", emp.EmpAge)
            cmd.Parameters.AddWithValue("@JoiningDate", emp.EmpJoiningDate)
            cmd.Parameters.AddWithValue("@Salary", emp.EmpSalary)
            Dim id1 As Object = cmd.ExecuteScalar()
            id = Convert.ToInt32(id1)
        Catch ex As Exception
            Throw ex
        Finally
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        Return id
    End Function

    Public Shared Function insertIntoTwoTables(emp As EmpViewModel1) As Int32
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        conn.Open()
        Dim id As Int32 = 0
        Try
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "spInsertIntoTwoTables"
            cmd.Parameters.AddWithValue("@Name", emp.EBOObj.EmpName)
            cmd.Parameters.AddWithValue("@Age", emp.EBOObj.EmpAge)
            cmd.Parameters.AddWithValue("@JoiningDate", emp.EBOObj.EmpJoiningDate)
            cmd.Parameters.AddWithValue("@Salary", emp.EBOObj.EmpSalary)
            cmd.Parameters.AddWithValue("@Phone", emp.EmpDetailsObj.EDPhone)
            cmd.Parameters.AddWithValue("@Email", emp.EmpDetailsObj.EDEmail)
            cmd.Parameters.AddWithValue("@Skills", emp.EmpDetailsObj.EDSalary)
            Dim id1 As Object = cmd.ExecuteScalar()
            id = Convert.ToInt32(id1)
        Catch ex As Exception
            Throw ex
        Finally
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        Return id
    End Function


    Public Shared Function findEmployee(empName As String) As String
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        conn.Open()
        Dim id As String = ""
        Try
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "spBool"
            cmd.Parameters.AddWithValue("@Name", empName)
            Dim id1 As Object = cmd.ExecuteScalar()
            id = id1.ToString()
        Catch ex As Exception
            Throw ex
        Finally
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        Return id
    End Function

    Public Shared Function checkuser(id As Int32) As String
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        conn.Open()
        Dim output As String = ""
        Try
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "spDeleteEmp"
            cmd.Parameters.AddWithValue("@id", id)
            Dim id1 As Object = cmd.ExecuteScalar()
            output = id1.ToString()
        Catch ex As Exception
            Throw ex
        Finally
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        Return output
    End Function

    Public Shared Function updateSalary() As String
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        conn.Open()
        Dim output As String = ""
        Try
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "spUpdateSalary"
            cmd.ExecuteNonQuery()
            output = "Updated"
        Catch ex As Exception
            Throw ex
        Finally
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        Return output
    End Function

    Public Shared Function UDT(emp As EmpBO.EBO) As String
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        conn.Open()
        Dim output As String = ""
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Age", GetType(Int32))
        dt.Columns.Add("JoiningDate", GetType(DateTime))
        dt.Columns.Add("Salary", GetType(Int32))
        Try
            Dim dr As DataRow = dt.NewRow()
            dr("Name") = emp.EmpName
            dr("Age") = emp.EmpAge
            dr("JoiningDate") = emp.EmpJoiningDate
            dr("Salary") = emp.EmpSalary
            dt.Rows.Add(dr)

            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserDefinedTable", dt)
            cmd.CommandText = "spCustomTable1"
            cmd.ExecuteNonQuery()
            output = "Created"
        Catch ex As Exception
            Throw ex
        Finally
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        Return output
    End Function

    Public Shared Function MultipleInsert(emp As List(Of EmpBO.EBO))
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        conn.Open()
        Try
            For Each e In emp
                Dim cmd As SqlCommand = New SqlCommand()
                cmd.Connection = conn
                cmd.CommandType = System.Data.CommandType.StoredProcedure
                cmd.CommandText = "spInsertEmp"
                cmd.Parameters.AddWithValue("@Name", e.EmpName)
                cmd.Parameters.AddWithValue("@Age", e.EmpAge)
                cmd.Parameters.AddWithValue("@JoiningDate", e.EmpJoiningDate)
                cmd.Parameters.AddWithValue("@Salary", e.EmpSalary)
                cmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            Throw ex
        Finally
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
    End Function

    Public Shared Function UserInfo(Name As String)
        Dim connection As String = ConfigurationManager.ConnectionStrings("EmpContext").ConnectionString
        Dim conn As SqlConnection = New SqlConnection(connection)
        conn.Open()
        Dim r1 As Object = New Object()
        Try
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = conn
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "spCheckUserDetails"
            cmd.Parameters.AddWithValue("@Name", Name)
            Dim rd As SqlDataReader = cmd.ExecuteReader()
            While (rd.Read())
                If (rd.FieldCount > 1) Then
                    Dim emp As EmpBO.EBO = New EmpBO.EBO()
                    emp.EmpName = rd("Name").ToString()
                    emp.EmpAge = Convert.ToInt32(rd("Age"))
                    emp.EmpJoiningDate = Convert.ToDateTime(rd("JoiningDate"))
                    emp.EmpSalary = Convert.ToInt32(rd("Salary"))
                    r1 = emp
                Else
                    r1 = rd("Message").ToString()
                End If
            End While
        Catch ex As Exception
            Throw ex
        Finally
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        Return r1
    End Function

End Class
