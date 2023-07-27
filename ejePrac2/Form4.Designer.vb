<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        TextBoxMinPm = New TextBox()
        LabelTo = New Label()
        TextBoxMinAm = New TextBox()
        LabelkM = New Label()
        ListaLlamada = New ComboBox()
        LabelVe = New Label()
        BtnIngresar = New Button()
        btnCalcular = New Button()
        PanelResultado = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        LabelTotal = New Label()
        Label3 = New Label()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        BtnBack = New Button()
        LabelMinAmLocal = New Label()
        LabelTotalinter = New Label()
        LabelTotalnacional = New Label()
        LabelTotalLocal = New Label()
        LabelMinPmInter = New Label()
        LabelMinPmNacional = New Label()
        LabelMinPmLocal = New Label()
        LabelMinAmInter = New Label()
        LabelMinAmNacional = New Label()
        Label2 = New Label()
        Label1 = New Label()
        LabelNaranja = New Label()
        LabelLimon = New Label()
        LabelCoca = New Label()
        PictureBox1 = New PictureBox()
        PanelResultado.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxMinPm
        ' 
        TextBoxMinPm.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxMinPm.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxMinPm.Location = New Point(40, 261)
        TextBoxMinPm.Name = "TextBoxMinPm"
        TextBoxMinPm.Size = New Size(325, 38)
        TextBoxMinPm.TabIndex = 32
        ' 
        ' LabelTo
        ' 
        LabelTo.AutoSize = True
        LabelTo.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTo.Location = New Point(40, 231)
        LabelTo.Name = "LabelTo"
        LabelTo.Size = New Size(138, 27)
        LabelTo.TabIndex = 31
        LabelTo.Text = "Minutos PM"
        ' 
        ' TextBoxMinAm
        ' 
        TextBoxMinAm.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxMinAm.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxMinAm.Location = New Point(40, 167)
        TextBoxMinAm.Name = "TextBoxMinAm"
        TextBoxMinAm.Size = New Size(325, 38)
        TextBoxMinAm.TabIndex = 28
        ' 
        ' LabelkM
        ' 
        LabelkM.AutoSize = True
        LabelkM.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelkM.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelkM.Location = New Point(43, 135)
        LabelkM.Name = "LabelkM"
        LabelkM.Size = New Size(138, 27)
        LabelkM.TabIndex = 27
        LabelkM.Text = "Minutos AM"
        ' 
        ' ListaLlamada
        ' 
        ListaLlamada.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ListaLlamada.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaLlamada.FormattingEnabled = True
        ListaLlamada.Items.AddRange(New Object() {"Nacional local", "Larga distancia nacional", "Larga distancia internacional"})
        ListaLlamada.Location = New Point(40, 69)
        ListaLlamada.Name = "ListaLlamada"
        ListaLlamada.Size = New Size(325, 35)
        ListaLlamada.TabIndex = 33
        ' 
        ' LabelVe
        ' 
        LabelVe.AutoSize = True
        LabelVe.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelVe.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelVe.Location = New Point(40, 34)
        LabelVe.Name = "LabelVe"
        LabelVe.Size = New Size(152, 27)
        LabelVe.TabIndex = 34
        LabelVe.Text = "Tipo Llamada"
        ' 
        ' BtnIngresar
        ' 
        BtnIngresar.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnIngresar.Cursor = Cursors.Hand
        BtnIngresar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnIngresar.FlatAppearance.BorderSize = 0
        BtnIngresar.FlatStyle = FlatStyle.Flat
        BtnIngresar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnIngresar.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnIngresar.Location = New Point(43, 334)
        BtnIngresar.Name = "BtnIngresar"
        BtnIngresar.Size = New Size(140, 51)
        BtnIngresar.TabIndex = 35
        BtnIngresar.Text = "Ingresar"
        BtnIngresar.UseVisualStyleBackColor = False
        ' 
        ' btnCalcular
        ' 
        btnCalcular.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        btnCalcular.Cursor = Cursors.Hand
        btnCalcular.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        btnCalcular.FlatAppearance.BorderSize = 0
        btnCalcular.FlatStyle = FlatStyle.Flat
        btnCalcular.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalcular.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        btnCalcular.Location = New Point(225, 334)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(140, 51)
        btnCalcular.TabIndex = 36
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = False
        ' 
        ' PanelResultado
        ' 
        PanelResultado.Controls.Add(Label6)
        PanelResultado.Controls.Add(Label5)
        PanelResultado.Controls.Add(Label4)
        PanelResultado.Controls.Add(LabelTotal)
        PanelResultado.Controls.Add(Label3)
        PanelResultado.Controls.Add(Panel4)
        PanelResultado.Controls.Add(Panel3)
        PanelResultado.Controls.Add(Panel2)
        PanelResultado.Controls.Add(Panel1)
        PanelResultado.Controls.Add(BtnBack)
        PanelResultado.Controls.Add(LabelMinAmLocal)
        PanelResultado.Controls.Add(LabelTotalinter)
        PanelResultado.Controls.Add(LabelTotalnacional)
        PanelResultado.Controls.Add(LabelTotalLocal)
        PanelResultado.Controls.Add(LabelMinPmInter)
        PanelResultado.Controls.Add(LabelMinPmNacional)
        PanelResultado.Controls.Add(LabelMinPmLocal)
        PanelResultado.Controls.Add(LabelMinAmInter)
        PanelResultado.Controls.Add(LabelMinAmNacional)
        PanelResultado.Controls.Add(Label2)
        PanelResultado.Controls.Add(Label1)
        PanelResultado.Controls.Add(LabelNaranja)
        PanelResultado.Controls.Add(LabelLimon)
        PanelResultado.Controls.Add(LabelCoca)
        PanelResultado.Location = New Point(0, 12)
        PanelResultado.Name = "PanelResultado"
        PanelResultado.Size = New Size(800, 380)
        PanelResultado.TabIndex = 37
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(585, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 27)
        Label6.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(411, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 27)
        Label5.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label4.Location = New Point(17, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(767, 27)
        Label4.TabIndex = 20
        Label4.Text = "Producto                          |       Min. AM       |       Min. PM       |     Monto        "
        ' 
        ' LabelTotal
        ' 
        LabelTotal.AutoSize = True
        LabelTotal.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTotal.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTotal.Location = New Point(633, 268)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(28, 27)
        LabelTotal.TabIndex = 19
        LabelTotal.Text = "--"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label3.Location = New Point(537, 268)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 27)
        Label3.TabIndex = 18
        Label3.Text = "TOTAL = "
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Panel4.BackgroundImageLayout = ImageLayout.None
        Panel4.ForeColor = SystemColors.ControlLightLight
        Panel4.Location = New Point(475, 256)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(300, 2)
        Panel4.TabIndex = 16
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Panel3.BackgroundImageLayout = ImageLayout.None
        Panel3.ForeColor = SystemColors.ControlLightLight
        Panel3.Location = New Point(280, 50)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(2, 200)
        Panel3.TabIndex = 17
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.ForeColor = SystemColors.ControlLightLight
        Panel2.Location = New Point(454, 50)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(2, 200)
        Panel2.TabIndex = 16
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.ForeColor = SystemColors.ControlLightLight
        Panel1.Location = New Point(628, 50)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2, 200)
        Panel1.TabIndex = 15
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        BtnBack.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnBack.Location = New Point(12, 300)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(107, 55)
        BtnBack.TabIndex = 14
        BtnBack.Text = "🔙"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' LabelMinAmLocal
        ' 
        LabelMinAmLocal.AutoSize = True
        LabelMinAmLocal.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMinAmLocal.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelMinAmLocal.Location = New Point(296, 85)
        LabelMinAmLocal.Name = "LabelMinAmLocal"
        LabelMinAmLocal.Size = New Size(28, 27)
        LabelMinAmLocal.TabIndex = 13
        LabelMinAmLocal.Text = "--"
        ' 
        ' LabelTotalinter
        ' 
        LabelTotalinter.AutoSize = True
        LabelTotalinter.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTotalinter.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTotalinter.Location = New Point(643, 209)
        LabelTotalinter.Name = "LabelTotalinter"
        LabelTotalinter.Size = New Size(28, 27)
        LabelTotalinter.TabIndex = 12
        LabelTotalinter.Text = "--"
        ' 
        ' LabelTotalnacional
        ' 
        LabelTotalnacional.AutoSize = True
        LabelTotalnacional.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTotalnacional.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTotalnacional.Location = New Point(644, 148)
        LabelTotalnacional.Name = "LabelTotalnacional"
        LabelTotalnacional.Size = New Size(28, 27)
        LabelTotalnacional.TabIndex = 11
        LabelTotalnacional.Text = "--"
        ' 
        ' LabelTotalLocal
        ' 
        LabelTotalLocal.AutoSize = True
        LabelTotalLocal.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTotalLocal.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTotalLocal.Location = New Point(643, 87)
        LabelTotalLocal.Name = "LabelTotalLocal"
        LabelTotalLocal.Size = New Size(28, 27)
        LabelTotalLocal.TabIndex = 10
        LabelTotalLocal.Text = "--"
        ' 
        ' LabelMinPmInter
        ' 
        LabelMinPmInter.AutoSize = True
        LabelMinPmInter.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMinPmInter.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelMinPmInter.Location = New Point(469, 209)
        LabelMinPmInter.Name = "LabelMinPmInter"
        LabelMinPmInter.Size = New Size(28, 27)
        LabelMinPmInter.TabIndex = 9
        LabelMinPmInter.Text = "--"
        ' 
        ' LabelMinPmNacional
        ' 
        LabelMinPmNacional.AutoSize = True
        LabelMinPmNacional.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMinPmNacional.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelMinPmNacional.Location = New Point(469, 148)
        LabelMinPmNacional.Name = "LabelMinPmNacional"
        LabelMinPmNacional.Size = New Size(28, 27)
        LabelMinPmNacional.TabIndex = 8
        LabelMinPmNacional.Text = "--"
        ' 
        ' LabelMinPmLocal
        ' 
        LabelMinPmLocal.AutoSize = True
        LabelMinPmLocal.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMinPmLocal.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelMinPmLocal.Location = New Point(470, 87)
        LabelMinPmLocal.Name = "LabelMinPmLocal"
        LabelMinPmLocal.Size = New Size(28, 27)
        LabelMinPmLocal.TabIndex = 7
        LabelMinPmLocal.Text = "--"
        ' 
        ' LabelMinAmInter
        ' 
        LabelMinAmInter.AutoSize = True
        LabelMinAmInter.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMinAmInter.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelMinAmInter.Location = New Point(295, 209)
        LabelMinAmInter.Name = "LabelMinAmInter"
        LabelMinAmInter.Size = New Size(28, 27)
        LabelMinAmInter.TabIndex = 6
        LabelMinAmInter.Text = "--"
        ' 
        ' LabelMinAmNacional
        ' 
        LabelMinAmNacional.AutoSize = True
        LabelMinAmNacional.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMinAmNacional.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelMinAmNacional.Location = New Point(295, 148)
        LabelMinAmNacional.Name = "LabelMinAmNacional"
        LabelMinAmNacional.Size = New Size(28, 27)
        LabelMinAmNacional.TabIndex = 5
        LabelMinAmNacional.Text = "--"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        Label2.Location = New Point(258, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 27)
        Label2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label1.Location = New Point(17, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 27)
        Label1.TabIndex = 3
        ' 
        ' LabelNaranja
        ' 
        LabelNaranja.AutoSize = True
        LabelNaranja.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        LabelNaranja.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelNaranja.Location = New Point(12, 212)
        LabelNaranja.Name = "LabelNaranja"
        LabelNaranja.Size = New Size(266, 24)
        LabelNaranja.TabIndex = 2
        LabelNaranja.Text = "Larga distancia internacional"
        ' 
        ' LabelLimon
        ' 
        LabelLimon.AutoSize = True
        LabelLimon.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        LabelLimon.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelLimon.Location = New Point(12, 150)
        LabelLimon.Name = "LabelLimon"
        LabelLimon.Size = New Size(224, 24)
        LabelLimon.TabIndex = 1
        LabelLimon.Text = "Larga distancia nacional"
        ' 
        ' LabelCoca
        ' 
        LabelCoca.AutoSize = True
        LabelCoca.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        LabelCoca.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelCoca.Location = New Point(12, 88)
        LabelCoca.Name = "LabelCoca"
        LabelCoca.Size = New Size(133, 24)
        LabelCoca.TabIndex = 0
        LabelCoca.Text = "Nacional local"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(445, 68)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(355, 340)
        PictureBox1.TabIndex = 38
        PictureBox1.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 407)
        Controls.Add(PanelResultado)
        Controls.Add(PictureBox1)
        Controls.Add(btnCalcular)
        Controls.Add(BtnIngresar)
        Controls.Add(ListaLlamada)
        Controls.Add(LabelVe)
        Controls.Add(TextBoxMinPm)
        Controls.Add(LabelTo)
        Controls.Add(TextBoxMinAm)
        Controls.Add(LabelkM)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form4"
        Text = "Form4"
        PanelResultado.ResumeLayout(False)
        PanelResultado.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxMinPm As TextBox
    Friend WithEvents LabelTo As Label
    Friend WithEvents TextBoxMinAm As TextBox
    Friend WithEvents LabelkM As Label
    Friend WithEvents ListaLlamada As ComboBox
    Friend WithEvents LabelVe As Label
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents PanelResultado As Panel
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnBack As Button
    Friend WithEvents LabelMinAmLocal As Label
    Friend WithEvents LabelTotalinter As Label
    Friend WithEvents LabelTotalnacional As Label
    Friend WithEvents LabelTotalLocal As Label
    Friend WithEvents LabelMinPmInter As Label
    Friend WithEvents LabelMinPmNacional As Label
    Friend WithEvents LabelMinPmLocal As Label
    Friend WithEvents LabelMinAmInter As Label
    Friend WithEvents LabelMinAmNacional As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNaranja As Label
    Friend WithEvents LabelLimon As Label
    Friend WithEvents LabelCoca As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
