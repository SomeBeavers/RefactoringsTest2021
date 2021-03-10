Namespace RefactoringsTest2021
    Public Class ConvertMethodToProperty
        Public Property Faculty As String

        Public Function Test() As String
            Faculty = "faculty"
            Return Faculty
        End Function
    End Class
End Namespace
