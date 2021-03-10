Namespace RefactoringsTest2021
    Public Class IntroduceParameter
        Public Sub IntroduceParameter1()
            Dim introduceParameter = New IntroduceParameter()
            Dim selectSomeThing = introduceParameter.SelectSomeThing.SelectSomeThing.SelectSomeThing.SelectSomeThing.SelectSomeThing
            Dim v1 = "hello"
            Dim v2 = IntroduceParameter2(v1)
        End Sub

        Private Shared Function IntroduceParameter2(ByVal param As String) As Integer
            Return param.Length
        End Function

        Public SelectSomeThing As IntroduceParameter

        Private Sub Use()
            IntroduceParameter1()
            IntroduceParameter2(Nothing)
        End Sub
    End Class
End Namespace
