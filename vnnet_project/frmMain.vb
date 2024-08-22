Imports System.IO

Public Class frmMain
    Private statesList As List(Of CState)

#Region "Private Members"

    Private fobjVendors As CVenders
    Private fobjVen As CVender
    Private fnSelectionID As Integer

#End Region

#Region "Public Methods"

    Public Sub Handler(ByVal DataDirty As Boolean)
        cmdSave.Enabled = DataDirty
    End Sub

#End Region

#Region "Private Methods"

    ''' <summary>
    ''' Creates and assigns bindings to all form fields.
    ''' </summary>
    Private Sub BindControls()
        fobjVen = fobjVendors.Item(fnSelectionID)

        txtCoName.DataBindings.Add("Text", fobjVen, "CompanyName")
        txtAddress.DataBindings.Add("Text", fobjVen, "Address")
        txtCity.DataBindings.Add("Text", fobjVen, "City")
        cmdSave.DataBindings.Add("Enabled", fobjVen, "Dirtied")

        txtPhoneNumber.DataBindings.Add("Text", fobjVen, "PhoneNumber")
        txtZipCode.DataBindings.Add("Text", fobjVen, "Zipcode")
        cmbState.DataBindings.Add("SelectedValue", fobjVen, "StateID")


    End Sub

    ''' <summary>
    ''' Clear all bindings, then calls BindControls
    ''' </summary>
    Private Sub UpdateDataBindings()
        txtCoName.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        txtCity.DataBindings.Clear()
        cmdSave.DataBindings.Clear()
        txtPhoneNumber.DataBindings.Clear()
        txtZipCode.DataBindings.Clear()
        cmbState.DataBindings.Clear()
        BindControls()
    End Sub

    Private Sub LoadStates()
        statesList = New List(Of CState)()
        For Each state As EStates In [Enum].GetValues(GetType(EStates))
            statesList.Add(New CState() With {.Code = state.ToString(), .ID = CType(state, Integer)})
        Next

        cmbState.DataSource = statesList
        cmbState.DisplayMember = "Code"
        cmbState.ValueMember = "ID"
        cmbState.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbState.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Private Sub TogglePreviousNext()
        cmdNext.Enabled = fnSelectionID < fobjVendors.Count - 1
        cmdPrev.Enabled = fnSelectionID > 0
    End Sub

#End Region

#Region "Event Handlers"

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fobjVendors = New CVenders
            fobjVendors.GetVendors()

            fnSelectionID = 0
            LoadStates()
            UpdateDataBindings()
            TogglePreviousNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Scroll forward through vendor collection and toggle buttons accordingly.
    ''' </summary>
    Private Sub cmdNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        Try
            fnSelectionID += 1
            UpdateDataBindings()
            TogglePreviousNext()

            ' Switch to Company Name for editing purposes.
            txtCoName.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Scroll back through vendor collection and toggle buttons accordingly.
    ''' </summary>
    Private Sub cmdPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        Try
            fnSelectionID -= 1
            UpdateDataBindings()
            TogglePreviousNext()

            ' Switch to Company Name for editing purposes.
            txtCoName.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DisableSaveButton()
        fobjVen.Dirtied = False
        cmdSave.DataBindings.Clear()
        cmdSave.DataBindings.Add("Enabled", fobjVen, "Dirtied")
    End Sub



    ''' <summary>
    ''' Launch save file dialog.
    ''' </summary>
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If fobjVen IsNot Nothing Then

                Dim filePath As String = "vendor.txt"

                Using writer As New StreamWriter(filePath, False)
                    writer.WriteLine("CompanyName: " & fobjVen.CompanyName)
                    writer.WriteLine("Address: " & fobjVen.Address)
                    writer.WriteLine("City: " & fobjVen.City)
                    writer.WriteLine("PhoneNumber: " & fobjVen.PhoneNumber)
                    writer.WriteLine("State: " & fobjVen.StateID.ToString())
                    writer.WriteLine("Zipcode: " & fobjVen.Zipcode)
                    writer.WriteLine("Dirtied: " & fobjVen.Dirtied)
                End Using
                DisableSaveButton()

                MessageBox.Show("Data saved!", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No vendor data to save.", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Launch open file dialog.
    ''' </summary>
    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZipCode.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If

        If (e.KeyChar = "."c) AndAlso CType(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If

        If (e.KeyChar = "."c) AndAlso CType(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmdSaveForm_Click(sender As Object, e As EventArgs) Handles cmdSaveForm.Click

        Dim frm As New frmDetail()
        frm.StartPosition = FormStartPosition.Manual
        Dim x As Integer = Me.Location.X + (Me.Width - frm.Width) \ 2
        Dim y As Integer = Me.Location.Y + (Me.Height - frm.Height) \ 2
        frm.Location = New Point(x, y)
        frm.Vendor = fobjVen
        frm.ShowDialog()
    End Sub


#End Region

End Class
