Imports System
Imports System.IO

Namespace RefactoringsTest2021
    Public Class MoveTypeToAnotherNamespace
        Public Sub Draw()
            Try
            Catch e As Exception
                LogError(e)
            End Try
        End Sub

        Public Sub Draw2()
            Try
            Catch e As Exception
                LogError(e)
            End Try
        End Sub

        Private Shared Sub LogError(ByVal e As Exception)
            File.WriteAllText("c:\Errors\Exception.txt", e.ToString())
        End Sub
    End Class
End Namespace
