Imports System

Namespace RefactoringsTest2021
    Public Class InlineParameter
        Private Sub PerformAction(ByVal action As Action, ByVal Optional s As String = "")
            action()
        End Sub

        Private Sub VeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongLongLongLongLongLongLongLongNameNameNameName(ByVal s As String, ByVal ss As String, ByVal sss As String)
            Console.WriteLine(s)
            Console.WriteLine(ss)
            Console.WriteLine(sss)
        End Sub

        Private Sub Test(ByVal key As String, ByVal value As String)
            PerformAction(Sub() Console.WriteLine("{0} : {1}", key, value))
        End Sub

        Private Sub Test2(ByVal key As String, ByVal value As String, ByVal s As String, ByVal s2 As String, ByVal s1 As String, ByVal s3 As String, ByVal s4 As String, ByVal s5 As String, ByVal s6 As String)
            PerformAction(Sub() Console.WriteLine($"{key} : " & $"{value}" & $"{s}{s1}{s2}{s3}{s4}{s5}"))
        End Sub

        Private Sub Test6(ByVal key As String, ByVal value As String, ByVal s As String, ByVal s2 As String, ByVal s1 As String, ByVal s3 As String, ByVal s4 As String, ByVal s5 As String, ByVal s6 As String)
            PerformAction(Sub() Console.WriteLine($"{key} !!!!!!!!! " & $"{value}" & $"{value}" & $"{s}{s1}{s2}{s3}{s4}{s5}"))
        End Sub

        Private Sub Test3(ByVal key As String, ByVal value As String, ByVal s As String, ByVal s2 As String, ByVal s1 As String, ByVal s3 As String, ByVal s4 As String, ByVal s5 As String, ByVal s6 As String)
            PerformAction(Sub() Console.WriteLine($"{key} : {value}{s}{s1}{s2}{s3}{s4}{s5}"))
        End Sub

        Private Sub Test4(ByVal key As String, ByVal value As String, ByVal s As String, ByVal s2 As String, ByVal s1 As String, ByVal s3 As String, ByVal s4 As String, ByVal s5 As String, ByVal s6 As String)
            PerformAction(Sub() Console.WriteLine($"{key} : {value}{s}{s1}{s2}{s3}{s4}{s5}"))
        End Sub

        Private Sub UseTest1(ByVal parameter As String)
            VeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongLongLongLongLongLongLongLongNameNameNameName("1", "2", parameter)
        End Sub

        Private Sub UseTest()
            VeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongLongLongLongLongLongLongLongNameNameNameName("", "1", "test")
        End Sub
    End Class
End Namespace
