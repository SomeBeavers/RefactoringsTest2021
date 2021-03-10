Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace RefactoringsTest2021
    Public Class InlineMethod
        Private Async Sub InlineMethod1(ByVal sender As Object)
        End Sub

        Private Shared Sub InlineMethod2()
            Dim i = Foo(True)
        End Sub

        Private Shared Function Foo(ByVal x As Boolean) As Integer
            If x Then Return 1
            Return 2
        End Function

        Public Function WriteAsync1(ByVal buffer As Byte(), ByVal offset As Integer, ByVal count As Integer, ByVal sourceStream As FileStream) As Task
            Return sourceStream.WriteAsync(buffer, offset, count, CancellationToken.None)
        End Function

        Public Async Sub WriteAsync2(ByVal buffer As Byte(), ByVal offset As Integer, ByVal count As Integer, ByVal sourceStream As FileStream)
            Await sourceStream.WriteAsync(buffer, offset, count, CancellationToken.None).ConfigureAwait(False)
        End Sub
    End Class
End Namespace
