<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdPrev = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.gbxSupplyVendor = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCoName = New System.Windows.Forms.TextBox()
        Me.lblCoName = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.cmdSaveForm = New System.Windows.Forms.Button()
        Me.gbxSupplyVendor.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLoad
        '
        Me.cmdLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLoad.Location = New System.Drawing.Point(102, 517)
        Me.cmdLoad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(82, 37)
        Me.cmdLoad.TabIndex = 14
        Me.cmdLoad.Text = "Load"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(15, 515)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(78, 37)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Save"
        '
        'cmdPrev
        '
        Me.cmdPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrev.Location = New System.Drawing.Point(434, 515)
        Me.cmdPrev.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(90, 37)
        Me.cmdPrev.TabIndex = 10
        Me.cmdPrev.Text = "Previous"
        '
        'cmdNext
        '
        Me.cmdNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNext.Location = New System.Drawing.Point(532, 515)
        Me.cmdNext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(90, 37)
        Me.cmdNext.TabIndex = 11
        Me.cmdNext.Text = "Next"
        '
        'gbxSupplyVendor
        '
        Me.gbxSupplyVendor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxSupplyVendor.Controls.Add(Me.Label3)
        Me.gbxSupplyVendor.Controls.Add(Me.txtPhoneNumber)
        Me.gbxSupplyVendor.Controls.Add(Me.Label2)
        Me.gbxSupplyVendor.Controls.Add(Me.txtZipCode)
        Me.gbxSupplyVendor.Controls.Add(Me.Label1)
        Me.gbxSupplyVendor.Controls.Add(Me.cmbState)
        Me.gbxSupplyVendor.Controls.Add(Me.txtCity)
        Me.gbxSupplyVendor.Controls.Add(Me.txtAddress)
        Me.gbxSupplyVendor.Controls.Add(Me.txtCoName)
        Me.gbxSupplyVendor.Controls.Add(Me.lblCoName)
        Me.gbxSupplyVendor.Controls.Add(Me.lblCity)
        Me.gbxSupplyVendor.Controls.Add(Me.lblAddress)
        Me.gbxSupplyVendor.Location = New System.Drawing.Point(15, 18)
        Me.gbxSupplyVendor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxSupplyVendor.Name = "gbxSupplyVendor"
        Me.gbxSupplyVendor.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxSupplyVendor.Size = New System.Drawing.Size(606, 474)
        Me.gbxSupplyVendor.TabIndex = 9
        Me.gbxSupplyVendor.TabStop = False
        Me.gbxSupplyVendor.Text = "Supply Vendors"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Phone Number"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(144, 205)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(451, 26)
        Me.txtPhoneNumber.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ZipCode"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(144, 173)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(451, 26)
        Me.txtZipCode.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "State"
        '
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(144, 139)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(451, 28)
        Me.cmbState.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCity.Location = New System.Drawing.Point(144, 105)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(451, 26)
        Me.txtCity.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Location = New System.Drawing.Point(144, 68)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(451, 26)
        Me.txtAddress.TabIndex = 4
        '
        'txtCoName
        '
        Me.txtCoName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCoName.Location = New System.Drawing.Point(144, 31)
        Me.txtCoName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCoName.Name = "txtCoName"
        Me.txtCoName.Size = New System.Drawing.Size(451, 26)
        Me.txtCoName.TabIndex = 3
        '
        'lblCoName
        '
        Me.lblCoName.AutoSize = True
        Me.lblCoName.Location = New System.Drawing.Point(16, 37)
        Me.lblCoName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCoName.Name = "lblCoName"
        Me.lblCoName.Size = New System.Drawing.Size(126, 20)
        Me.lblCoName.TabIndex = 0
        Me.lblCoName.Text = "Company Name:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(16, 111)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(39, 20)
        Me.lblCity.TabIndex = 1
        Me.lblCity.Text = "City:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(16, 74)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 20)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address:"
        '
        'cmdSaveForm
        '
        Me.cmdSaveForm.Location = New System.Drawing.Point(251, 520)
        Me.cmdSaveForm.Name = "cmdSaveForm"
        Me.cmdSaveForm.Size = New System.Drawing.Size(85, 30)
        Me.cmdSaveForm.TabIndex = 15
        Me.cmdSaveForm.Text = "Show Form"
        Me.cmdSaveForm.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 572)
        Me.Controls.Add(Me.cmdSaveForm)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.gbxSupplyVendor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Widget Group Company"
        Me.gbxSupplyVendor.ResumeLayout(False)
        Me.gbxSupplyVendor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdLoad As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdPrev As Button
    Friend WithEvents cmdNext As Button
    Friend WithEvents gbxSupplyVendor As GroupBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCoName As TextBox
    Friend WithEvents lblCoName As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents cmdSaveForm As Button
End Class
