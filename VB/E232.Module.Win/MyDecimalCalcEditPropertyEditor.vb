Imports System
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.XtraEditors.Repository

Namespace E232.Module.Win
    <PropertyEditor(GetType(Decimal), MyDecimalCalcEditPropertyEditor.CalcEditorAlias, False)> _
    Public Class MyDecimalCalcEditPropertyEditor
        Inherits DXPropertyEditor

        Public Const CalcEditorAlias As String = "CalcEditor"
        Public Sub New(ByVal objectType As Type, ByVal model As IModelMemberViewItem)
            MyBase.New(objectType, model)
            Me.ControlBindingProperty = "EditValue"
        End Sub
        Protected Overrides Function CreateControlCore() As Object
            Return New CalcEdit()
        End Function
        Protected Overrides Sub SetupRepositoryItem(ByVal item As RepositoryItem)
            MyBase.SetupRepositoryItem(item)
            CType(item, RepositoryItemCalcEdit).Mask.EditMask = "C"
            CType(item, RepositoryItemCalcEdit).Mask.UseMaskAsDisplayFormat = True
        End Sub
        Protected Overrides Function CreateRepositoryItem() As RepositoryItem
            Return New RepositoryItemCalcEdit()
        End Function
        ' Uncomment this code starting with version 13.1.
        'public override bool CanFormatPropertyValue {
        '    get { return true; }
        '}
    End Class
    <NavigationItem("E232")> _
    Public Class TestObject
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private _Amount As Decimal
        <EditorAlias(MyDecimalCalcEditPropertyEditor.CalcEditorAlias)> _
        Public Property Amount() As Decimal
            Get
                Return _Amount
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue("Amount", _Amount, value)
            End Set
        End Property
    End Class
End Namespace