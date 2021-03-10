Imports System

Namespace RefactoringsTest2021
    Public Class InlineField
        Private Const ErrorMessage As String = "Something has failed"

        Public Sub Draw(ByVal s As String)
            Try
            Catch e As Exception
                Console.WriteLine("{0} : {1}", ErrorMessage, e)
                Console.WriteLine("{0} : {1}", ErrorMessage, e)
            End Try
        End Sub
    End Class
End Namespace
