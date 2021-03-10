Namespace RefactoringsTest2021
    Public Class MoveTypeToOuterScope
        Class MoveTypeToOuterScope1
            Private Sub Test()
                Dim MoveTypeToOuterScope2 = New MoveTypeToOuterScope2()
            End Sub
        End Class

        Class MoveTypeToOuterScope2
            Private Sub Test()
                Dim MoveTypeToOuterScope1 = New MoveTypeToOuterScope1()
            End Sub
        End Class
    End Class
End Namespace
