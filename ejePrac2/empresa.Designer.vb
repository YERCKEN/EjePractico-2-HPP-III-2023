<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empresa
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(empresa))
        PictureBoxLogo = New PictureBox()
        LabelPractico = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackColor = Color.Transparent
        PictureBoxLogo.BackgroundImage = My.Resources.Resources.YERKEN_SOLUTIO_gris1
        PictureBoxLogo.Location = New Point(240, 50)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(315, 181)
        PictureBoxLogo.TabIndex = 13
        PictureBoxLogo.TabStop = False
        ' 
        ' LabelPractico
        ' 
        LabelPractico.AutoSize = True
        LabelPractico.Font = New Font("Montserrat", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPractico.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelPractico.Location = New Point(99, 234)
        LabelPractico.Name = "LabelPractico"
        LabelPractico.Size = New Size(600, 84)
        LabelPractico.TabIndex = 15
        LabelPractico.Text = resources.GetString("LabelPractico.Text")
        LabelPractico.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(363, 358)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 37)
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.Location = New Point(408, 358)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 37)
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' empresa
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 21.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 407)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(LabelPractico)
        Controls.Add(PictureBoxLogo)
        FormBorderStyle = FormBorderStyle.None
        Name = "empresa"
        Text = "z"
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelPractico As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
