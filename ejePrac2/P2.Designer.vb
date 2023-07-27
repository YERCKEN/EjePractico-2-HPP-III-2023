<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P2
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
        LabelTítulo = New Label()
        LabelResultado = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TextBoxMonto = New TextBox()
        LabelNumero = New Label()
        TextBoxDías = New TextBox()
        Label2 = New Label()
        LabelInteres = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelTítulo
        ' 
        LabelTítulo.AutoSize = True
        LabelTítulo.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTítulo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTítulo.Location = New Point(449, 19)
        LabelTítulo.Name = "LabelTítulo"
        LabelTítulo.Size = New Size(191, 32)
        LabelTítulo.TabIndex = 16
        LabelTítulo.Text = "Monto a Pagar"
        ' 
        ' LabelResultado
        ' 
        LabelResultado.AutoSize = True
        LabelResultado.Font = New Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point)
        LabelResultado.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelResultado.Location = New Point(76, 307)
        LabelResultado.Name = "LabelResultado"
        LabelResultado.Size = New Size(150, 55)
        LabelResultado.TabIndex = 15
        LabelResultado.Text = "0.00 $"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(74, 263)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 27)
        Label1.TabIndex = 14
        Label1.Text = "TOTAL"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources._21
        PictureBox1.Location = New Point(362, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(364, 330)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' TextBoxMonto
        ' 
        TextBoxMonto.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxMonto.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxMonto.Location = New Point(76, 96)
        TextBoxMonto.Name = "TextBoxMonto"
        TextBoxMonto.Size = New Size(189, 38)
        TextBoxMonto.TabIndex = 12
        ' 
        ' LabelNumero
        ' 
        LabelNumero.AutoSize = True
        LabelNumero.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelNumero.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelNumero.Location = New Point(76, 58)
        LabelNumero.Name = "LabelNumero"
        LabelNumero.Size = New Size(80, 27)
        LabelNumero.TabIndex = 11
        LabelNumero.Text = "Monto"
        ' 
        ' TextBoxDías
        ' 
        TextBoxDías.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxDías.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxDías.Location = New Point(76, 190)
        TextBoxDías.Name = "TextBoxDías"
        TextBoxDías.Size = New Size(189, 38)
        TextBoxDías.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(76, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 27)
        Label2.TabIndex = 17
        Label2.Text = "Días de Atraso"
        ' 
        ' LabelInteres
        ' 
        LabelInteres.AutoSize = True
        LabelInteres.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelInteres.ForeColor = Color.Red
        LabelInteres.Location = New Point(162, 262)
        LabelInteres.Name = "LabelInteres"
        LabelInteres.Size = New Size(0, 27)
        LabelInteres.TabIndex = 19
        ' 
        ' P2
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 407)
        Controls.Add(LabelInteres)
        Controls.Add(TextBoxDías)
        Controls.Add(Label2)
        Controls.Add(LabelTítulo)
        Controls.Add(LabelResultado)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(TextBoxMonto)
        Controls.Add(LabelNumero)
        FormBorderStyle = FormBorderStyle.None
        Name = "P2"
        Text = "P2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelTítulo As Label
    Friend WithEvents LabelResultado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxMonto As TextBox
    Friend WithEvents LabelNumero As Label
    Friend WithEvents TextBoxDías As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelInteres As Label
End Class
