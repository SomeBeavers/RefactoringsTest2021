Imports System

Namespace RefactoringsTest2021
    Public Class MakeMethodNonStatic
        Public Property Id As String
        Public Property Name As String

        Public Shared Function Merge(ByVal m2 As MakeMethodNonStatic) As MakeMethodNonStatic
            Return New MakeMethodNonStatic()
        End Function

        Private Sub Te()
            Merge(New MakeMethodNonStatic()).ToString()
        End Sub

        Public Function Merge(ByVal name As String, ByVal id As String, ByVal m2 As MakeMethodNonStatic, ByVal m3 As MakeMethodNonStatic, ByVal m4 As MakeMethodNonStatic, ByVal m5 As MakeMethodNonStatic, ByVal m6 As MakeMethodNonStatic, ByVal m7 As MakeMethodNonStatic, ByVal m8 As MakeMethodNonStatic, ByVal m9 As MakeMethodNonStatic, ByVal m10 As MakeMethodNonStatic, ByVal m11 As MakeMethodNonStatic, ByVal m12 As MakeMethodNonStatic, ByVal m13 As MakeMethodNonStatic, ByVal m15 As MakeMethodNonStatic, ByVal m16 As MakeMethodNonStatic, ByVal m17 As MakeMethodNonStatic, ByVal m18 As MakeMethodNonStatic, ByVal m19 As MakeMethodNonStatic, ByVal m20 As MakeMethodNonStatic, ByVal m21 As MakeMethodNonStatic, ByVal m22 As MakeMethodNonStatic, ByVal m23 As MakeMethodNonStatic) As MakeMethodNonStatic
            Return New MakeMethodNonStatic() With {
                .Id = id & m2.Id,
                .Name = name & m2.Name
            }
        End Function

        Public Shared Function Merge(ByVal name As String, ByVal id As String, ByVal m2 As MakeMethodNonStatic, ByVal m3 As MakeMethodNonStatic, ByVal m4 As MakeMethodNonStatic, ByVal m5 As MakeMethodNonStatic, ByVal m6 As MakeMethodNonStatic, ByVal m7 As MakeMethodNonStatic, ByVal m8 As MakeMethodNonStatic, ByVal m9 As MakeMethodNonStatic, ByVal m10 As MakeMethodNonStatic, ByVal m11 As MakeMethodNonStatic, ByVal m12 As MakeMethodNonStatic, ByVal m13 As MakeMethodNonStatic, ByVal m14 As MakeMethodNonStatic, ByVal m15 As MakeMethodNonStatic, ByVal m16 As MakeMethodNonStatic, ByVal m17 As MakeMethodNonStatic, ByVal m18 As MakeMethodNonStatic, ByVal m19 As MakeMethodNonStatic, ByVal m20 As MakeMethodNonStatic, ByVal m21 As MakeMethodNonStatic, ByVal m22 As MakeMethodNonStatic, ByVal m23 As MakeMethodNonStatic) As MakeMethodNonStatic
            Return New MakeMethodNonStatic() With {
                .Id = id & m2.Id,
                .Name = name & m2.Name
            }
        End Function

        Public Shared Function Merge(ByVal m1 As MakeMethodNonStatic, ByVal m2 As MakeMethodNonStatic, ByVal m3 As MakeMethodNonStatic, ByVal m4 As MakeMethodNonStatic, ByVal m5 As MakeMethodNonStatic, ByVal m6 As MakeMethodNonStatic, ByVal m7 As MakeMethodNonStatic, ByVal m8 As MakeMethodNonStatic, ByVal m9 As MakeMethodNonStatic, ByVal m10 As MakeMethodNonStatic, ByVal m11 As MakeMethodNonStatic, ByVal m12 As MakeMethodNonStatic, ByVal m13 As MakeMethodNonStatic, ByVal m14 As MakeMethodNonStatic, ByVal m15 As MakeMethodNonStatic, ByVal m16 As MakeMethodNonStatic, ByVal m17 As MakeMethodNonStatic, ByVal m18 As MakeMethodNonStatic, ByVal m19 As MakeMethodNonStatic, ByVal m20 As MakeMethodNonStatic, ByVal m21 As MakeMethodNonStatic, ByVal m22 As MakeMethodNonStatic, ByVal m23 As MakeMethodNonStatic) As MakeMethodNonStatic
            Return New MakeMethodNonStatic() With {
                .Id = m1.Id & m2.Id,
                .Name = m1.Name & m2.Name
            }
        End Function
    End Class
End Namespace
