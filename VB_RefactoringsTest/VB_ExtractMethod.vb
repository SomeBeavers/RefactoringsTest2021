Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.InteropServices

Namespace RefactoringsTest2021
    Public Class ExtractMethod
        Public Sub New(ByVal int As Integer, ByVal age As Integer, ByVal name As String, ByVal name2 As String, ByVal name3 As String, ByVal name4 As String)
            Dim age2 As Integer
            age2 = age
            Dim t = 1
            Age = 1
            Name = name
            Name2 = name2
            Name3 = someNewRR(name3)
        End Sub

        Public Overridable Function ExtractMethod1(<Out> ByRef chars As Char(), ByVal input As String) As String
            Dim A = 1
            chars = ToArray(input)
            Array.Reverse(chars)
            Dim reversed = New String(chars)
            Console.WriteLine(reversed)
            Return reversed
        End Function

        Private Shared Sub ExtractMethod2(ByVal input As String)
            Dim a = 1
            Dim reversed1 = 1
            Dim reversed2 = 1
            Dim reversed3 = 1
            Dim reversed4 = 1
            Dim reversed5 = 1
            Dim reversed6 = 1
            Dim charsRenamedNewName = input.ToCharArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray()
            Array.Reverse(charsRenamedNewName)
            Dim reversed = New String(charsRenamedNewName)
            Console.WriteLine(reversed)
            Console.WriteLine(reversed1)
            Console.WriteLine(reversed2)
            Console.WriteLine(reversed3)
            Console.WriteLine(reversed4)
            Console.WriteLine(reversed5)
            Console.WriteLine(reversed6)
        End Sub

        Public Sub ExtractLocalFunction(ByVal input As String, ByVal b As Boolean, ByVal list As List(Of String))
            If b Then

                While b

                    If b Then

                        While b

                            If b Then

                                SyncLock list

                                    If b Then

                                        While b

                                            Try

                                                For i As Integer = 0 To list.Count - 1

                                                    For Each s In list
                                                        Dim ints = New List(Of Integer)() From {
                                                            list.Count
                                                        }
                                                    Next

                                                    If b Then
                                                        Dim a = 1
                                                        Dim reversed1 = 1
                                                        Dim reversed2 = 1
                                                        Dim reversed3 = 1
                                                        Dim reversed4 = 1
                                                        Dim reversed5 = 1
                                                        Dim reversed6 = 1
                                                        Dim charsRenamedNewName = input.ToCharArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray()
                                                        Array.Reverse(charsRenamedNewName)
                                                        Dim reversed = New String(charsRenamedNewName)
                                                        Console.WriteLine(reversed)
                                                        Console.WriteLine(reversed1)
                                                        Console.WriteLine(reversed2)
                                                        Console.WriteLine(reversed3)
                                                        Console.WriteLine(reversed4)
                                                        Console.WriteLine(reversed5)
                                                        Console.WriteLine(reversed6)
                                                    End If
                                                Next

                                            Catch e As Exception
                                                Console.WriteLine(e)
                                                Throw
                                            End Try
                                        End While
                                    End If
                                End SyncLock
                            End If
                        End While
                    End If
                End While
            End If
        End Sub

        Private Shared Function ToArray(ByVal input As String) As Char()
            Return input.ToCharArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray()
        End Function

        Protected Overridable Function someNewRR(ByVal name3 As String) As String
            Return name3
        End Function

        Private name As String

        Public Property Name1 As String
            Get
                Return name
            End Get
            Set(ByVal value As String)
                name = value
            End Set
        End Property

        Public Property Name2 As String
        Public Property Name3 As String
        Public Property Name4 As String
        Public Property Age As Integer
    End Class
End Namespace
