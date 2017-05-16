Public Class EmpViewModel
    Private EBO As List(Of EBO)
    Private EmpDetails As List(Of EmpDetails)

    Public Property ListEBO() As List(Of EBO)
        Get
            Return EBO
        End Get
        Set(ByVal value As List(Of EBO))
            EBO = value
        End Set
    End Property

    Public Property ListEmpDetails() As List(Of EmpDetails)
        Get
            Return EmpDetails
        End Get
        Set(ByVal value As List(Of EmpDetails))
            EmpDetails = value
        End Set
    End Property
End Class
