Imports System
Imports System.Runtime.InteropServices

Namespace RefactoringsTest2021
    Public Class VB_ChangeSignature
        Inherits ChangeSignatureSimpleBase

        Private ReadOnly _anotherParameter As String
        Private ReadOnly _charNewNameRenamed1 As Char()
        Private ReadOnly _charNewNameRenamed1123123 As Char()
        Private ReadOnly _charNewNameRenamed1A As Char()
        Private ReadOnly _charNewNameRenamed1W As Char()
        Private ReadOnly _sssss As String
        Private ReadOnly _t As Integer
        Private ReadOnly _t123 As Integer
        Private ReadOnly _t2 As Integer
        Private ReadOnly _t2123 As Integer
        Private ReadOnly _t2A As Integer
        Private ReadOnly _t2W As Integer
        Private ReadOnly _t3 As Integer
        Private ReadOnly _t3123 As Integer
        Private ReadOnly _t3A As Integer
        Private ReadOnly _t3W As Integer
        Private ReadOnly _t4123123 As String
        Private ReadOnly _t4A111 As String
        Private ReadOnly _t4Renamed As String
        Private ReadOnly _t4W As String
        Private ReadOnly _ta As Integer
        Private ReadOnly _testIntRenamed As Integer
        Private ReadOnly _testIntRenamed123123 As Integer
        Private ReadOnly _testIntRenameda As Integer
        Private ReadOnly _testIntRenamedw As Integer
        Private ReadOnly _tw As Integer

        Public Sub New(ByVal testInt_renamed As Integer, ByRef charNewNameRenamed1 As Char(), ByVal t123 As Integer, ByVal t2123 As Integer, ByVal t3123 As Integer, ByVal t4123123 As String, ByVal testInt_renamed123123 As Integer, ByRef charNewNameRenamed1123123 As Char(), ByVal t As Integer, ByVal t2 As Integer, ByVal t3 As Integer, ByVal t4_renamed As String, ByVal testInt_renamedw As Integer, ByRef charNewNameRenamed1w As Char(), ByVal tw As Integer, ByVal t2w As Integer, ByVal t3w As Integer, ByVal t4w As String, ByVal testInt_renameda As Integer, ByRef charNewNameRenamed1a As Char(), ByVal ta As Integer, ByVal t2a As Integer, ByVal t3a As Integer, ByVal t4a111 As String, ByVal anotherParameter As String, ByVal sssss As String)
            _testIntRenamed = testInt_renamed
            _charNewNameRenamed1 = charNewNameRenamed1
            _t123 = t123
            _t2123 = t2123
            _t3123 = t3123
            _t4123123 = t4123123
            _testIntRenamed123123 = testInt_renamed123123
            _charNewNameRenamed1123123 = charNewNameRenamed1123123
            _t = t
            _t2 = t2
            _t3 = t3
            _t4Renamed = t4_renamed
            _testIntRenamedw = testInt_renamedw
            _charNewNameRenamed1W = charNewNameRenamed1w
            _tw = tw
            _t2W = t2w
            _t3W = t3w
            _t4W = t4w
            _testIntRenameda = testInt_renameda
            _charNewNameRenamed1A = charNewNameRenamed1a
            _ta = ta
            _t2A = t2a
            _t3A = t3a
            _t4A111 = t4a111
            _anotherParameter = anotherParameter
            _sssss = sssss
        End Sub

        Public Overrides Function ChangeSignature_method(ByVal s As String, ByVal xxx As Integer, ByVal Optional _1_int As Integer = 0) As String
            Console.WriteLine("overriden")
            Return MyBase.ChangeSignature_method(s, xxx, _1_int)
        End Function

        Public Property ChangeSignatureProperty As String

        Public Sub UseChangeSignature(ByVal useInPullTool As String)
            Dim a = "".ToCharArray()
            Dim b = "".ToCharArray()
            Dim c = "".ToCharArray()
            Dim d = "".ToCharArray()
            Dim changeSignature = New VB_ChangeSignature(0, a, 0, 0, 0, Nothing, 0, b, 0, 0, 0, Nothing, 0, d, 0, 0, 0, Nothing, 0, c, 0, 0, 0, Nothing, Nothing, Nothing)
            ChangeSignatureProperty = ""
            ChangeSignature_method("test", 10)
            Dim int As Integer
        End Sub
    End Class

    Public Class ChangeSignatureSimpleBase
        Public Overridable Function ChangeSignature_method(ByVal s As String, ByVal xxx As Integer, ByVal Optional _1_int As Integer = 0) As String
            Return String.Format("'{0}': {1} times", s, xxx)
        End Function

        Public Function Foo() As String
            Throw New Exception()
        End Function

        Public Sub Test()
            Foo()
            ChangeSignature_method("test", 10)
        End Sub
    End Class

    Class ChangeSignature_Indexer(Of T)
        Private arr As T() = New T(99) {}

        Default Public Property Item(ByVal i As Integer) As T
            Get
                Return arr(i)
            End Get
            Set(ByVal value As T)
                arr(i) = value
            End Set
        End Property
    End Class

    Public Class MyAttribute
    End Class

    Public Class ChangeSignature_A
    End Class
End Namespace
