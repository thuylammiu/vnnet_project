Public Class frmDetail
    Private fobjVen As CVender

    Public Property Vendor() As CVender
        Get
            Return fobjVen
        End Get
        Set(ByVal value As CVender)
            fobjVen = value
            BindControls() '
        End Set
    End Property

    Private Sub BindControls()
        If fobjVen IsNot Nothing Then

            lblDetailCompany.DataBindings.Add("Text", fobjVen, "CompanyName")
            lblDetailAddess.DataBindings.Add("Text", fobjVen, "Address")
            lblDetailCity.DataBindings.Add("Text", fobjVen, "City")

            lblDetailPhoneNumber.DataBindings.Add("Text", fobjVen, "PhoneNumber")
            lblDetailZipCode.DataBindings.Add("Text", fobjVen, "Zipcode")
            lblDetailState.DataBindings.Add("Text", fobjVen, "State")
        End If
    End Sub
    Private Sub frmDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdDetailClose.Click
        Me.Close()
    End Sub
End Class