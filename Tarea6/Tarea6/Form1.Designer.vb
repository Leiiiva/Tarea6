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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_divide = New System.Windows.Forms.Button()
        Me.btn_multiply = New System.Windows.Forms.Button()
        Me.btn_substract = New System.Windows.Forms.Button()
        Me.lbl_b = New System.Windows.Forms.Label()
        Me.lbl_num_b = New System.Windows.Forms.Label()
        Me.btn_plus_b = New System.Windows.Forms.Button()
        Me.btn_minus_b = New System.Windows.Forms.Button()
        Me.lbl_a = New System.Windows.Forms.Label()
        Me.lbl_result = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_num_a = New System.Windows.Forms.Label()
        Me.btn_plus_a = New System.Windows.Forms.Button()
        Me.btn_minus_a = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_divide)
        Me.GroupBox1.Controls.Add(Me.btn_multiply)
        Me.GroupBox1.Controls.Add(Me.btn_substract)
        Me.GroupBox1.Controls.Add(Me.lbl_b)
        Me.GroupBox1.Controls.Add(Me.lbl_num_b)
        Me.GroupBox1.Controls.Add(Me.btn_plus_b)
        Me.GroupBox1.Controls.Add(Me.btn_minus_b)
        Me.GroupBox1.Controls.Add(Me.lbl_a)
        Me.GroupBox1.Controls.Add(Me.lbl_result)
        Me.GroupBox1.Controls.Add(Me.lbl_1)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.lbl_num_a)
        Me.GroupBox1.Controls.Add(Me.btn_plus_a)
        Me.GroupBox1.Controls.Add(Me.btn_minus_a)
        Me.GroupBox1.Font = New System.Drawing.Font("Acumin Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 333)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculadora Simple"
        '
        'btn_divide
        '
        Me.btn_divide.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_divide.Location = New System.Drawing.Point(268, 274)
        Me.btn_divide.Name = "btn_divide"
        Me.btn_divide.Size = New System.Drawing.Size(117, 38)
        Me.btn_divide.TabIndex = 45
        Me.btn_divide.Text = "Dividir"
        Me.btn_divide.UseVisualStyleBackColor = True
        '
        'btn_multiply
        '
        Me.btn_multiply.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_multiply.Location = New System.Drawing.Point(268, 197)
        Me.btn_multiply.Name = "btn_multiply"
        Me.btn_multiply.Size = New System.Drawing.Size(117, 38)
        Me.btn_multiply.TabIndex = 44
        Me.btn_multiply.Text = "Multiplicar"
        Me.btn_multiply.UseVisualStyleBackColor = True
        '
        'btn_substract
        '
        Me.btn_substract.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_substract.Location = New System.Drawing.Point(268, 115)
        Me.btn_substract.Name = "btn_substract"
        Me.btn_substract.Size = New System.Drawing.Size(117, 38)
        Me.btn_substract.TabIndex = 43
        Me.btn_substract.Text = "Restar"
        Me.btn_substract.UseVisualStyleBackColor = True
        '
        'lbl_b
        '
        Me.lbl_b.AutoSize = True
        Me.lbl_b.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_b.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_b.Location = New System.Drawing.Point(17, 120)
        Me.lbl_b.Name = "lbl_b"
        Me.lbl_b.Size = New System.Drawing.Size(37, 28)
        Me.lbl_b.TabIndex = 42
        Me.lbl_b.Text = "B :"
        Me.lbl_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_num_b
        '
        Me.lbl_num_b.AutoSize = True
        Me.lbl_num_b.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_num_b.Location = New System.Drawing.Point(129, 120)
        Me.lbl_num_b.Name = "lbl_num_b"
        Me.lbl_num_b.Size = New System.Drawing.Size(24, 28)
        Me.lbl_num_b.TabIndex = 41
        Me.lbl_num_b.Text = "0"
        Me.lbl_num_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_plus_b
        '
        Me.btn_plus_b.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_plus_b.Location = New System.Drawing.Point(179, 115)
        Me.btn_plus_b.Name = "btn_plus_b"
        Me.btn_plus_b.Size = New System.Drawing.Size(40, 38)
        Me.btn_plus_b.TabIndex = 40
        Me.btn_plus_b.Text = "+"
        Me.btn_plus_b.UseVisualStyleBackColor = True
        '
        'btn_minus_b
        '
        Me.btn_minus_b.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_minus_b.Location = New System.Drawing.Point(60, 115)
        Me.btn_minus_b.Name = "btn_minus_b"
        Me.btn_minus_b.Size = New System.Drawing.Size(40, 38)
        Me.btn_minus_b.TabIndex = 39
        Me.btn_minus_b.Text = "-"
        Me.btn_minus_b.UseVisualStyleBackColor = True
        '
        'lbl_a
        '
        Me.lbl_a.AutoSize = True
        Me.lbl_a.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_a.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_a.Location = New System.Drawing.Point(17, 43)
        Me.lbl_a.Name = "lbl_a"
        Me.lbl_a.Size = New System.Drawing.Size(37, 28)
        Me.lbl_a.TabIndex = 38
        Me.lbl_a.Text = "A :"
        Me.lbl_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_result
        '
        Me.lbl_result.AutoSize = True
        Me.lbl_result.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_result.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_result.Location = New System.Drawing.Point(69, 279)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(0, 28)
        Me.lbl_result.TabIndex = 37
        Me.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_1.Location = New System.Drawing.Point(17, 202)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(169, 28)
        Me.lbl_1.TabIndex = 36
        Me.lbl_1.Text = "El resultado es :"
        Me.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_add.Location = New System.Drawing.Point(268, 38)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(117, 38)
        Me.btn_add.TabIndex = 35
        Me.btn_add.Text = "Sumar"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'lbl_num_a
        '
        Me.lbl_num_a.AutoSize = True
        Me.lbl_num_a.Font = New System.Drawing.Font("Acumin Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_num_a.Location = New System.Drawing.Point(129, 43)
        Me.lbl_num_a.Name = "lbl_num_a"
        Me.lbl_num_a.Size = New System.Drawing.Size(24, 28)
        Me.lbl_num_a.TabIndex = 34
        Me.lbl_num_a.Text = "0"
        Me.lbl_num_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_plus_a
        '
        Me.btn_plus_a.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_plus_a.Location = New System.Drawing.Point(179, 38)
        Me.btn_plus_a.Name = "btn_plus_a"
        Me.btn_plus_a.Size = New System.Drawing.Size(40, 38)
        Me.btn_plus_a.TabIndex = 33
        Me.btn_plus_a.Text = "+"
        Me.btn_plus_a.UseVisualStyleBackColor = True
        '
        'btn_minus_a
        '
        Me.btn_minus_a.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_minus_a.Location = New System.Drawing.Point(60, 38)
        Me.btn_minus_a.Name = "btn_minus_a"
        Me.btn_minus_a.Size = New System.Drawing.Size(40, 38)
        Me.btn_minus_a.TabIndex = 32
        Me.btn_minus_a.Text = "-"
        Me.btn_minus_a.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "201314707 - Edgar Leiva"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_divide As Button
    Friend WithEvents btn_multiply As Button
    Friend WithEvents btn_substract As Button
    Friend WithEvents lbl_b As Label
    Friend WithEvents lbl_num_b As Label
    Friend WithEvents btn_plus_b As Button
    Friend WithEvents btn_minus_b As Button
    Friend WithEvents lbl_a As Label
    Friend WithEvents lbl_result As Label
    Friend WithEvents lbl_1 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents lbl_num_a As Label
    Friend WithEvents btn_plus_a As Button
    Friend WithEvents btn_minus_a As Button
End Class
