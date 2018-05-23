Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

<DefaultClassOptions()> _
Public Class DomainObject1
    Inherits BaseObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Private fNumber As Decimal

    Public Property Number() As Decimal
        Get
            Return fNumber
        End Get
        Set(ByVal value As Decimal)
            SetPropertyValue("Number", fNumber, Value)
        End Set
    End Property

End Class
