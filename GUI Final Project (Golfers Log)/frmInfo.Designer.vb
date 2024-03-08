<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfo))
        Me.picGolf = New System.Windows.Forms.PictureBox()
        Me.lblGolfersLog = New System.Windows.Forms.Label()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblMyName = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.picGolf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGolf
        '
        Me.picGolf.Image = CType(resources.GetObject("picGolf.Image"), System.Drawing.Image)
        Me.picGolf.Location = New System.Drawing.Point(12, 12)
        Me.picGolf.Name = "picGolf"
        Me.picGolf.Size = New System.Drawing.Size(391, 292)
        Me.picGolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGolf.TabIndex = 0
        Me.picGolf.TabStop = False
        '
        'lblGolfersLog
        '
        Me.lblGolfersLog.AutoSize = True
        Me.lblGolfersLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGolfersLog.Location = New System.Drawing.Point(531, 9)
        Me.lblGolfersLog.Name = "lblGolfersLog"
        Me.lblGolfersLog.Size = New System.Drawing.Size(139, 25)
        Me.lblGolfersLog.TabIndex = 1
        Me.lblGolfersLog.Text = "Golfer's Log"
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurpose.Location = New System.Drawing.Point(409, 40)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(75, 20)
        Me.lblPurpose.TabIndex = 2
        Me.lblPurpose.Text = "Purpose"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Location = New System.Drawing.Point(410, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "The purpose of this application is for golfers to keep track of their friends or " &
    "competitos."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(409, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Location = New System.Drawing.Point(410, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(356, 99)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(409, 243)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(63, 20)
        Me.lblAuthor.TabIndex = 6
        Me.lblAuthor.Text = "Author"
        '
        'lblMyName
        '
        Me.lblMyName.AutoEllipsis = True
        Me.lblMyName.Location = New System.Drawing.Point(410, 272)
        Me.lblMyName.Name = "lblMyName"
        Me.lblMyName.Size = New System.Drawing.Size(83, 20)
        Me.lblMyName.TabIndex = 7
        Me.lblMyName.Text = "Daniel O'Malley"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(713, 282)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmInfo
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 317)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblMyName)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPurpose)
        Me.Controls.Add(Me.lblGolfersLog)
        Me.Controls.Add(Me.picGolf)
        Me.Name = "frmInfo"
        Me.Text = "Golfer's Log Information (Daniel O'Malley #77)"
        CType(Me.picGolf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGolf As PictureBox
    Friend WithEvents lblGolfersLog As Label
    Friend WithEvents lblPurpose As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblMyName As Label
    Friend WithEvents btnClose As Button
End Class
