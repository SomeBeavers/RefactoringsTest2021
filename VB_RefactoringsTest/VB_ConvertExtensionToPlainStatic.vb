Imports System.Runtime.CompilerServices

Namespace RefactoringsTest2021
    Module ConvertExtensionToPlainStatic
        <Extension()>
        Sub DoSomething(ByVal s As String, ByVal s2 As String)
        End Sub

        Private Sub Test(ByVal str As String)
            str.DoSomething(Nothing)
        End Sub
    End Module
End Namespace
