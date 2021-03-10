Imports System

Namespace RefactoringsTest2021
    Public Class MakeStatic
        Public Property Name As String

        Public Sub MakeStatic1(ByVal logger As Logger)
            Dim msg = $"The new shape is drawn at {pivot}, {pivot}"
            logger.Log(msg)
            Console.WriteLine(Name)
        End Sub

        Private pivot As Integer

        Public Class Logger
            Public Sub Log(ByVal msg As String)
            End Sub
        End Class
    End Class
End Namespace
