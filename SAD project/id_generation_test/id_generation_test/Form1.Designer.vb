<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtSelectID = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.txtPhoto = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnSaveImage = New System.Windows.Forms.Button()
        Me.OPDPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.picImportStudent = New System.Windows.Forms.PictureBox()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImportStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(513, 459)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(129, 58)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(513, 195)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.RowTemplate.Height = 28
        Me.dgvUsers.Size = New System.Drawing.Size(654, 202)
        Me.dgvUsers.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(141, 53)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(173, 26)
        Me.txtName.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(74, 59)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'txtSelectID
        '
        Me.txtSelectID.Location = New System.Drawing.Point(710, 410)
        Me.txtSelectID.Name = "txtSelectID"
        Me.txtSelectID.Size = New System.Drawing.Size(129, 26)
        Me.txtSelectID.TabIndex = 4
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(710, 459)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(129, 58)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(141, 100)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(173, 26)
        Me.txtEmail.TabIndex = 2
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(74, 106)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 20)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "email"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(845, 459)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(129, 58)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(980, 459)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 58)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'picStudent
        '
        Me.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStudent.Location = New System.Drawing.Point(513, 12)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(191, 177)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudent.TabIndex = 6
        Me.picStudent.TabStop = False
        '
        'txtPhoto
        '
        Me.txtPhoto.Location = New System.Drawing.Point(58, 353)
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.ReadOnly = True
        Me.txtPhoto.Size = New System.Drawing.Size(334, 26)
        Me.txtPhoto.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(239, 385)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(153, 63)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnSaveImage
        '
        Me.btnSaveImage.Location = New System.Drawing.Point(239, 454)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(153, 63)
        Me.btnSaveImage.TabIndex = 7
        Me.btnSaveImage.Text = "SAVE IMAGE"
        Me.btnSaveImage.UseVisualStyleBackColor = True
        '
        'OPDPhoto
        '
        Me.OPDPhoto.FileName = "OPDPhoto"
        '
        'picImportStudent
        '
        Me.picImportStudent.Location = New System.Drawing.Point(58, 385)
        Me.picImportStudent.Name = "picImportStudent"
        Me.picImportStudent.Size = New System.Drawing.Size(175, 132)
        Me.picImportStudent.TabIndex = 8
        Me.picImportStudent.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 540)
        Me.Controls.Add(Me.picImportStudent)
        Me.Controls.Add(Me.btnSaveImage)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.picStudent)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtSelectID)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtPhoto)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.btnRefresh)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImportStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtSelectID As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents picStudent As System.Windows.Forms.PictureBox
    Friend WithEvents txtPhoto As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnSaveImage As System.Windows.Forms.Button
    Friend WithEvents OPDPhoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents picImportStudent As System.Windows.Forms.PictureBox

End Class
