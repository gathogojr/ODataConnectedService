﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


'Original file name:
'Generation date: 20.11.2020 0:28:18
Namespace Simple
    '''<summary>
    '''There are no comments for Simple.TestType in the schema.
    '''</summary>
    '''<KeyProperties>
    '''KeyProp
    '''</KeyProperties>
    <Global.System.Data.Services.Common.DataServiceKeyAttribute("KeyProp")>  _
    Partial Public Class TestType
        '''<summary>
        '''Create a new TestType object.
        '''</summary>
        '''<param name="keyProp">Initial value of KeyProp.</param>
        '''<param name="valueProp">Initial value of ValueProp.</param>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Shared Function CreateTestType(ByVal keyProp As Integer, ByVal valueProp As String) As TestType
            Dim testType As TestType = New TestType()
            testType.KeyProp = keyProp
            testType.ValueProp = valueProp
            Return testType
        End Function
        '''<summary>
        '''There are no comments for Property KeyProp in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property KeyProp() As Integer
            Get
                Return Me._KeyProp
            End Get
            Set
                Me.OnKeyPropChanging(value)
                Me._KeyProp = value
                Me.OnKeyPropChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _KeyProp As Integer
        Partial Private Sub OnKeyPropChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnKeyPropChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property ValueProp in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property ValueProp() As String
            Get
                Return Me._ValueProp
            End Get
            Set
                Me.OnValuePropChanging(value)
                Me._ValueProp = value
                Me.OnValuePropChanged
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _ValueProp As String
        Partial Private Sub OnValuePropChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnValuePropChanged()
        End Sub
    End Class
End Namespace
