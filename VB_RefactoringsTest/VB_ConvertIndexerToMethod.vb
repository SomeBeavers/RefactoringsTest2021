Imports System

Namespace RefactoringsTest2021
    Public Class ConvertIndexerToMethod
        Public Class Book
            Public Property Author As String
            Public Property Title As String
        End Class

        Private books As Book()

        Default Public Property Item(ByVal index As Integer, ByVal name As String) As Book
            Get
                If index >= books.Length Then Throw New IndexOutOfRangeException()
                Return books(index)
            End Get
            Set(ByVal value As Book)
                If index >= books.Length Then Throw New IndexOutOfRangeException()
                books(index) = value
            End Set
        End Property

        Public Sub TestCopyBook(ByVal copy As Integer, ByVal [to] As Integer, ByVal name As String)
            Me([to], name) = Me(copy, name)
        End Sub
    End Class
End Namespace
