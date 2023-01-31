<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Y2 = New System.Windows.Forms.TextBox()
        Me.Y1 = New System.Windows.Forms.TextBox()
        Me.X1 = New System.Windows.Forms.TextBox()
        Me.X2 = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Distancia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(113, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Y2
        '
        Me.Y2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Y2.Location = New System.Drawing.Point(36, 107)
        Me.Y2.Multiline = True
        Me.Y2.Name = "Y2"
        Me.Y2.Size = New System.Drawing.Size(71, 32)
        Me.Y2.TabIndex = 1
        '
        'Y1
        '
        Me.Y1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Y1.Location = New System.Drawing.Point(36, 198)
        Me.Y1.Multiline = True
        Me.Y1.Name = "Y1"
        Me.Y1.Size = New System.Drawing.Size(71, 32)
        Me.Y1.TabIndex = 2
        '
        'X1
        '
        Me.X1.BackColor = System.Drawing.SystemColors.Desktop
        Me.X1.Location = New System.Drawing.Point(418, 107)
        Me.X1.Multiline = True
        Me.X1.Name = "X1"
        Me.X1.Size = New System.Drawing.Size(71, 32)
        Me.X1.TabIndex = 3
        '
        'X2
        '
        Me.X2.BackColor = System.Drawing.SystemColors.Desktop
        Me.X2.Location = New System.Drawing.Point(418, 207)
        Me.X2.Multiline = True
        Me.X2.Name = "X2"
        Me.X2.Size = New System.Drawing.Size(71, 32)
        Me.X2.TabIndex = 4
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Calcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Calcular.Location = New System.Drawing.Point(36, 12)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(97, 35)
        Me.Calcular.TabIndex = 5
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Distancia
        '
        Me.Distancia.BackColor = System.Drawing.SystemColors.Desktop
        Me.Distancia.Location = New System.Drawing.Point(221, 12)
        Me.Distancia.Multiline = True
        Me.Distancia.Name = "Distancia"
        Me.Distancia.Size = New System.Drawing.Size(97, 32)
        Me.Distancia.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Distancia"
        '
        'Limpiar
        '
        Me.Limpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Limpiar.Location = New System.Drawing.Point(132, 274)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(97, 35)
        Me.Limpiar.TabIndex = 8
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Salir.Location = New System.Drawing.Point(248, 274)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(97, 35)
        Me.Salir.TabIndex = 9
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Y2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Y1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "X1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "X2"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.TextBox1.Location = New System.Drawing.Point(392, -3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 87)
        Me.TextBox1.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.BlueViolet
        Me.Label6.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(425, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 60)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Calculadora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       De" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Distancia"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(544, 337)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Distancia)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.X2)
        Me.Controls.Add(Me.X1)
        Me.Controls.Add(Me.Y1)
        Me.Controls.Add(Me.Y2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Y2 As System.Windows.Forms.TextBox
    Friend WithEvents Y1 As System.Windows.Forms.TextBox
    Friend WithEvents X1 As System.Windows.Forms.TextBox
    Friend WithEvents X2 As System.Windows.Forms.TextBox
    Friend WithEvents Calcular As System.Windows.Forms.Button
    Friend WithEvents Distancia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Limpiar As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
