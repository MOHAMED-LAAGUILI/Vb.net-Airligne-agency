<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btn = New System.Windows.Forms.Button
        Me.btf = New System.Windows.Forms.Button
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.txt4 = New System.Windows.Forms.TextBox
        Me.txt3 = New System.Windows.Forms.ComboBox
        Me.txt2 = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(66, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Billet de Transport"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(26, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prix a payer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(27, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Destination"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(26, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date billet"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(26, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Numero billet"
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.Image = CType(resources.GetObject("btn.Image"), System.Drawing.Image)
        Me.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn.Location = New System.Drawing.Point(52, 221)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(135, 47)
        Me.btn.TabIndex = 5
        Me.btn.Text = "Nouveau"
        Me.btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn.UseVisualStyleBackColor = False
        '
        'btf
        '
        Me.btf.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btf.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btf.Image = CType(resources.GetObject("btf.Image"), System.Drawing.Image)
        Me.btf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btf.Location = New System.Drawing.Point(210, 221)
        Me.btf.Name = "btf"
        Me.btf.Size = New System.Drawing.Size(113, 47)
        Me.btf.TabIndex = 6
        Me.btf.Text = "Fermer"
        Me.btf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btf.UseVisualStyleBackColor = False
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(146, 73)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(185, 27)
        Me.txt1.TabIndex = 7
        '
        'txt4
        '
        Me.txt4.Enabled = False
        Me.txt4.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4.Location = New System.Drawing.Point(146, 172)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(185, 27)
        Me.txt4.TabIndex = 8
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.FormattingEnabled = True
        Me.txt3.Items.AddRange(New Object() {"Tanger", "Rabat", "Casa", "Fes", "Agadir", "Oujda"})
        Me.txt3.Location = New System.Drawing.Point(146, 139)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(185, 27)
        Me.txt3.TabIndex = 11
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt2.Location = New System.Drawing.Point(146, 106)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(185, 27)
        Me.txt2.TabIndex = 12
        Me.txt2.Value = New Date(2023, 2, 16, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(337, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 21)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(378, 280)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btf)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Agence de voyage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btf As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.DateTimePicker
    Private WithEvents txt3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
