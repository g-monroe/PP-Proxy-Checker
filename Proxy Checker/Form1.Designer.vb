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
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.tbIP = New System.Windows.Forms.TextBox()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProxy = New System.Windows.Forms.Label()
        Me.tbTimeout = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(203, 37)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(62, 23)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'tbIP
        '
        Me.tbIP.Location = New System.Drawing.Point(13, 13)
        Me.tbIP.Name = "tbIP"
        Me.tbIP.Size = New System.Drawing.Size(90, 20)
        Me.tbIP.TabIndex = 1
        '
        'tbPort
        '
        Me.tbPort.Location = New System.Drawing.Point(108, 13)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New System.Drawing.Size(62, 20)
        Me.tbPort.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ":"
        '
        'lblProxy
        '
        Me.lblProxy.AutoSize = True
        Me.lblProxy.Location = New System.Drawing.Point(13, 42)
        Me.lblProxy.Name = "lblProxy"
        Me.lblProxy.Size = New System.Drawing.Size(74, 13)
        Me.lblProxy.TabIndex = 4
        Me.lblProxy.Text = "Proxy: None..."
        '
        'tbTimeout
        '
        Me.tbTimeout.Location = New System.Drawing.Point(203, 13)
        Me.tbTimeout.Name = "tbTimeout"
        Me.tbTimeout.Size = New System.Drawing.Size(62, 20)
        Me.tbTimeout.TabIndex = 5
        Me.tbTimeout.Text = "5000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 7)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TimeOut(ms)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 67)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbTimeout)
        Me.Controls.Add(Me.lblProxy)
        Me.Controls.Add(Me.tbPort)
        Me.Controls.Add(Me.tbIP)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCheck As Button
    Friend WithEvents tbIP As TextBox
    Friend WithEvents tbPort As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProxy As Label
    Friend WithEvents tbTimeout As TextBox
    Friend WithEvents Label2 As Label
End Class
