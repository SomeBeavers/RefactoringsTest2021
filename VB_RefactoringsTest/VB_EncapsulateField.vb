Imports System

Namespace RefactoringsTest2021
    Public Class VB_EncapsulateField
        Private fieldWithoutProperty As String
        Public ReadOnly fieldWithProperty As Integer

        Public ReadOnly Property FieldWithProperty1 As Integer
            Get
                Return fieldWithProperty
            End Get
        End Property

        Private fieldWithSeveralProperties As String

        Private Property FieldWithSeveralProperties1 As String
            Get
                Return fieldWithSeveralProperties
            End Get
            Set(ByVal value As String)
                fieldWithSeveralProperties = value
            End Set
        End Property

        Private Protected Property FieldWithSeveralProperties2 As String
            Get
                Return fieldWithSeveralProperties
            End Get
            Set(ByVal value As String)
                fieldWithSeveralProperties = value
            End Set
        End Property

        Public Sub New(ByVal fieldWithoutProperty As String, ByVal fieldWithProperty As Integer, ByVal fieldWithSeveralProperties As String)
            Me.fieldWithoutProperty = fieldWithoutProperty
            Me.fieldWithProperty = fieldWithProperty
            Me.fieldWithSeveralProperties = fieldWithSeveralProperties
            Console.WriteLine(Me.fieldWithoutProperty)
            Console.WriteLine(Me.fieldWithProperty)
            Console.WriteLine(Me.fieldWithSeveralProperties)
            Dim fieldWithoutPropertyName = NameOf(Me.fieldWithoutProperty)
            Const fieldWithPropertyName As String = NameOf(Me.fieldWithProperty)
            Dim fieldWithSeveralPropertiesName As String = NameOf(Me.fieldWithSeveralProperties)
        End Sub
    End Class
End Namespace
