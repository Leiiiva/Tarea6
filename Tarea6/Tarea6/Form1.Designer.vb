<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_minus = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_exit = New System.Windows.Forms.Label()
        Me.lbl_clean = New System.Windows.Forms.Label()
        Me.lnl_print = New System.Windows.Forms.Label()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.lbl_hi = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_minus
        '
        Me.btn_minus.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_minus.Location = New System.Drawing.Point(3, 3)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(40, 38)
        Me.btn_minus.TabIndex = 0
        Me.btn_minus.Text = "-"
        Me.btn_minus.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_name)
        Me.Panel1.Controls.Add(Me.lbl_exit)
        Me.Panel1.Controls.Add(Me.lbl_clean)
        Me.Panel1.Controls.Add(Me.lnl_print)
        Me.Panel1.Controls.Add(Me.lbl_change)
        Me.Panel1.Controls.Add(Me.lbl_hi)
        Me.Panel1.Controls.Add(Me.btn_ok)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_plus)
        Me.Panel1.Controls.Add(Me.btn_minus)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 274)
        Me.Panel1.TabIndex = 1
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.Location = New System.Drawing.Point(204, 67)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(0, 28)
        Me.lbl_name.TabIndex = 9
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_exit
        '
        Me.lbl_exit.AutoSize = True
        Me.lbl_exit.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_exit.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_exit.Location = New System.Drawing.Point(122, 240)
        Me.lbl_exit.Name = "lbl_exit"
        Me.lbl_exit.Size = New System.Drawing.Size(82, 28)
        Me.lbl_exit.TabIndex = 8
        Me.lbl_exit.Text = "5- Salir"
        Me.lbl_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_clean
        '
        Me.lbl_clean.AutoSize = True
        Me.lbl_clean.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_clean.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_clean.Location = New System.Drawing.Point(227, 189)
        Me.lbl_clean.Name = "lbl_clean"
        Me.lbl_clean.Size = New System.Drawing.Size(112, 28)
        Me.lbl_clean.TabIndex = 7
        Me.lbl_clean.Text = "4- Limpiar"
        Me.lbl_clean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnl_print
        '
        Me.lnl_print.AutoSize = True
        Me.lnl_print.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lnl_print.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lnl_print.Location = New System.Drawing.Point(3, 189)
        Me.lnl_print.Name = "lnl_print"
        Me.lnl_print.Size = New System.Drawing.Size(205, 28)
        Me.lnl_print.TabIndex = 6
        Me.lnl_print.Text = "2- Imprimir Nombre"
        Me.lnl_print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_change
        '
        Me.lbl_change.AutoSize = True
        Me.lbl_change.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_change.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_change.Location = New System.Drawing.Point(3, 140)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(201, 28)
        Me.lbl_change.TabIndex = 5
        Me.lbl_change.Text = "1- Cambiar Nombre"
        Me.lbl_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_hi
        '
        Me.lbl_hi.AutoSize = True
        Me.lbl_hi.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_hi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_hi.Location = New System.Drawing.Point(227, 140)
        Me.lbl_hi.Name = "lbl_hi"
        Me.lbl_hi.Size = New System.Drawing.Size(113, 28)
        Me.lbl_hi.TabIndex = 4
        Me.lbl_hi.Text = "3- Saludar"
        Me.lbl_hi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_ok.Location = New System.Drawing.Point(44, 62)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(80, 38)
        Me.btn_ok.TabIndex = 3
        Me.btn_ok.Text = "Ok !"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(72, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_plus
        '
        Me.btn_plus.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_plus.Location = New System.Drawing.Point(122, 3)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(40, 38)
        Me.btn_plus.TabIndex = 1
        Me.btn_plus.Text = "+"
        Me.btn_plus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 297)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "201314707 - Edgar Leiva"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_minus As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_change As Label
    Friend WithEvents lbl_hi As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_plus As Button
    Friend WithEvents lbl_exit As Label
    Friend WithEvents lbl_clean As Label
    Friend WithEvents lnl_print As Label
    Friend WithEvents lbl_name As Label
End Class
