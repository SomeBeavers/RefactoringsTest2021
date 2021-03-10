Namespace RefactoringsTest2021
    Public Class MoveToAnotherType
        Private Shared Sub Test()
            Test2()
        End Sub

        Private Shared Sub Test2()
        End Sub

        Class MoveToAnotherType1
            Private Shared Function CreateMoveBug() As String
                Return String.Empty
            End Function

            Public Shared Sub Test2()
                CreateMoveBug()
            End Sub
        End Class
    End Class
End Namespace
