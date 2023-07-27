<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TextBoxTone = New TextBox()
        LabelTo = New Label()
        LabelResultado = New Label()
        LabelTOTAL = New Label()
        PictureBox1 = New PictureBox()
        LabelkM = New Label()
        TextBoxKm = New TextBox()
        ListaVe = New ComboBox()
        LabelVe = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxTone
        ' 
        TextBoxTone.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxTone.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxTone.Location = New Point(76, 203)
        TextBoxTone.Name = "TextBoxTone"
        TextBoxTone.Size = New Size(189, 38)
        TextBoxTone.TabIndex = 26
        ' 
        ' LabelTo
        ' 
        LabelTo.AutoSize = True
        LabelTo.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTo.Location = New Point(76, 173)
        LabelTo.Name = "LabelTo"
        LabelTo.Size = New Size(118, 27)
        LabelTo.TabIndex = 25
        LabelTo.Text = "Toneladas"
        ' 
        ' LabelResultado
        ' 
        LabelResultado.AutoSize = True
        LabelResultado.Font = New Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point)
        LabelResultado.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelResultado.Location = New Point(76, 309)
        LabelResultado.Name = "LabelResultado"
        LabelResultado.Size = New Size(150, 55)
        LabelResultado.TabIndex = 23
        LabelResultado.Text = "0.00 $"
        ' 
        ' LabelTOTAL
        ' 
        LabelTOTAL.AutoSize = True
        LabelTOTAL.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTOTAL.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTOTAL.Location = New Point(74, 274)
        LabelTOTAL.Name = "LabelTOTAL"
        LabelTOTAL.Size = New Size(79, 27)
        LabelTOTAL.TabIndex = 22
        LabelTOTAL.Text = "TOTAL"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(358, 133)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(364, 238)
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' LabelkM
        ' 
        LabelkM.AutoSize = True
        LabelkM.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelkM.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelkM.Location = New Point(79, 66)
        LabelkM.Name = "LabelkM"
        LabelkM.Size = New Size(169, 27)
        LabelkM.TabIndex = 19
        LabelkM.Text = "Km Recorridos"
        ' 
        ' TextBoxKm
        ' 
        TextBoxKm.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxKm.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxKm.Location = New Point(76, 98)
        TextBoxKm.Name = "TextBoxKm"
        TextBoxKm.Size = New Size(189, 38)
        TextBoxKm.TabIndex = 20
        ' 
        ' ListaVe
        ' 
        ListaVe.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        ListaVe.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaVe.FormattingEnabled = True
        ListaVe.Items.AddRange(New Object() {"Bicicleta", "Moto", "Carro", "Camión"})
        ListaVe.Location = New Point(445, 76)
        ListaVe.Name = "ListaVe"
        ListaVe.Size = New Size(191, 43)
        ListaVe.TabIndex = 27
        ' 
        ' LabelVe
        ' 
        LabelVe.AutoSize = True
        LabelVe.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelVe.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelVe.Location = New Point(487, 40)
        LabelVe.Name = "LabelVe"
        LabelVe.Size = New Size(104, 27)
        LabelVe.TabIndex = 28
        LabelVe.Text = "Vehículo"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 407)
        Controls.Add(ListaVe)
        Controls.Add(LabelVe)
        Controls.Add(TextBoxTone)
        Controls.Add(LabelTo)
        Controls.Add(LabelResultado)
        Controls.Add(LabelTOTAL)
        Controls.Add(PictureBox1)
        Controls.Add(TextBoxKm)
        Controls.Add(LabelkM)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxTone As TextBox
    Friend WithEvents LabelTo As Label
    Friend WithEvents LabelResultado As Label
    Friend WithEvents LabelTOTAL As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelkM As Label
    Friend WithEvents TextBoxKm As TextBox
    Friend WithEvents ListaVe As ComboBox
    Friend WithEvents LabelVe As Label
End Class
