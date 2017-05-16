Public Class EBO
    Private Id As Int32
    Private Name As String
    Private Age As Int32
    Private Salary As Int32
    Private JoiningDate As Date
    Public Property EmpId() As Int32
        Get
            Return Id
        End Get
        Set(ByVal value As Int32)
            Id = value
        End Set
    End Property

    Public Property EmpName() As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            Name = value
        End Set
    End Property
    Public Property EmpAge() As String
        Get
            Return Age
        End Get
        Set(ByVal value As String)
            Age = value
        End Set
    End Property

    Public Property EmpSalary() As String
        Get
            Return Salary
        End Get
        Set(ByVal value As String)
            Salary = value
        End Set
    End Property

    Public Property EmpJoiningDate() As String
        Get
            Return JoiningDate
        End Get
        Set(ByVal value As String)
            JoiningDate = value
        End Set
    End Property

End Class

Public Class EmpDetails
    Private Id As Int32
    Private EmpId As Int32
    Private Phone As Int32
    Private Email As String
    Private Skills As Int32
    Public Property EID() As Int32
        Get
            Return Id
        End Get
        Set(ByVal value As Int32)
            Id = value
        End Set
    End Property

    Public Property EDID() As Int32
        Get
            Return EmpId
        End Get
        Set(ByVal value As Int32)
            EmpId = value
        End Set
    End Property

    Public Property EDPhone() As Int32
        Get
            Return Phone
        End Get
        Set(ByVal value As Int32)
            Phone = value
        End Set
    End Property

    Public Property EDEmail() As String
        Get
            Return Email
        End Get
        Set(ByVal value As String)
            Email = value
        End Set
    End Property

    Public Property EDSalary() As Int32
        Get
            Return Skills
        End Get
        Set(ByVal value As Int32)
            Skills = value
        End Set
    End Property

End Class
