Namespace RefactoringsTest2021
    Public Partial Class InlineClass
        Private Class Circle
            Private myPainter1 As Painter

            Public Sub New(ByVal c As Color)
                MyPainter1 = New Painter(c, Nothing)
            End Sub

            Public Property MyPainter12 As Painter
                Get
                    Return MyPainter12
                End Get
                Set(ByVal value As Painter)
                    myPainter1 = value
                End Set
            End Property
        End Class
    End Class

    Public Partial Class InlineClass
        Class Painter
            Private myColor As Color

            Public Sub New(ByVal c As Color, ByVal s As String)
                myColor = c
                InitPainter(myColor)
            End Sub

            Private Sub InitPainter(ByVal color As Color)
            End Sub
        End Class
    End Class

    Public Class Color
        Public Name As String
    End Class
End Namespace
