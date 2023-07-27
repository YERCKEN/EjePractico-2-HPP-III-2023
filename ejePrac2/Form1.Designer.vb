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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PanelP1 = New Panel()
        LabelTítulo = New Label()
        LabelResultado = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TextBoxHorasT = New TextBox()
        LabelNumero = New Label()
        BtnCerrar = New PictureBox()
        Menu = New MenuStrip()
        Archivo = New ToolStripMenuItem()
        archivoP1 = New ToolStripMenuItem()
        archivoP2 = New ToolStripMenuItem()
        P3 = New ToolStripMenuItem()
        ArchivoP4 = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator5 = New ToolStripSeparator()
        ayuda = New ToolStripMenuItem()
        TIP = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        btnEmpresa = New ToolStripMenuItem()
        toolStripSeparator2 = New ToolStripSeparator()
        version = New ToolStripMenuItem()
        BuscarToolStripMenuItem = New ToolStripMenuItem()
        BtnMin = New PictureBox()
        LabelPractico = New Label()
        PictureBoxLogo = New PictureBox()
        LabelTitulo = New Label()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        PanelP2 = New Panel()
        TextBox2 = New TextBox()
        Panel1 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Panel2 = New Panel()
        PanelP1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        Menu.SuspendLayout()
        CType(BtnMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelP1
        ' 
        PanelP1.Controls.Add(LabelTítulo)
        PanelP1.Controls.Add(LabelResultado)
        PanelP1.Controls.Add(Label1)
        PanelP1.Controls.Add(PictureBox1)
        PanelP1.Controls.Add(TextBoxHorasT)
        PanelP1.Controls.Add(LabelNumero)
        PanelP1.Location = New Point(0, 45)
        PanelP1.Name = "PanelP1"
        PanelP1.Size = New Size(800, 407)
        PanelP1.TabIndex = 14
        ' 
        ' LabelTítulo
        ' 
        LabelTítulo.AutoSize = True
        LabelTítulo.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTítulo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTítulo.Location = New Point(425, 15)
        LabelTítulo.Name = "LabelTítulo"
        LabelTítulo.Size = New Size(242, 32)
        LabelTítulo.TabIndex = 10
        LabelTítulo.Text = "SUELDO SEMANAL"
        ' 
        ' LabelResultado
        ' 
        LabelResultado.AutoSize = True
        LabelResultado.Font = New Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point)
        LabelResultado.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelResultado.Location = New Point(76, 271)
        LabelResultado.Name = "LabelResultado"
        LabelResultado.Size = New Size(150, 55)
        LabelResultado.TabIndex = 6
        LabelResultado.Text = "0.00 $"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(74, 227)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 27)
        Label1.TabIndex = 5
        Label1.Text = "Sueldo"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.P11
        PictureBox1.Location = New Point(362, 50)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(364, 330)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' TextBoxHorasT
        ' 
        TextBoxHorasT.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxHorasT.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxHorasT.Location = New Point(76, 132)
        TextBoxHorasT.Name = "TextBoxHorasT"
        TextBoxHorasT.Size = New Size(189, 38)
        TextBoxHorasT.TabIndex = 3
        ' 
        ' LabelNumero
        ' 
        LabelNumero.AutoSize = True
        LabelNumero.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelNumero.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelNumero.Location = New Point(76, 88)
        LabelNumero.Name = "LabelNumero"
        LabelNumero.Size = New Size(191, 27)
        LabelNumero.TabIndex = 2
        LabelNumero.Text = "Horas Trabajadas"
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.Cursor = Cursors.Hand
        BtnCerrar.Image = My.Resources.Resources.cancel_3
        BtnCerrar.Location = New Point(753, 5)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(33, 33)
        BtnCerrar.TabIndex = 0
        BtnCerrar.TabStop = False
        ' 
        ' Menu
        ' 
        Menu.BackColor = Color.Transparent
        Menu.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Menu.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Menu.GripMargin = New Padding(2, 60, 60, 2)
        Menu.ImageScalingSize = New Size(20, 20)
        Menu.Items.AddRange(New ToolStripItem() {Archivo, toolStripSeparator5, ayuda, toolStripSeparator2, version})
        Menu.Location = New Point(0, 0)
        Menu.Name = "Menu"
        Menu.Padding = New Padding(0)
        Menu.RenderMode = ToolStripRenderMode.Professional
        Menu.Size = New Size(800, 48)
        Menu.TabIndex = 9
        Menu.Text = "MenuStrip1"
        ' 
        ' Archivo
        ' 
        Archivo.DropDownItems.AddRange(New ToolStripItem() {archivoP1, archivoP2, P3, ArchivoP4, ToolStripSeparator1, SalirToolStripMenuItem})
        Archivo.Margin = New Padding(20, 0, 0, 0)
        Archivo.Name = "Archivo"
        Archivo.Padding = New Padding(5, 20, 5, 0)
        Archivo.Size = New Size(92, 48)
        Archivo.Text = "Archivo"
        ' 
        ' archivoP1
        ' 
        archivoP1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        archivoP1.ImageTransparentColor = Color.Magenta
        archivoP1.Margin = New Padding(0, 20, 0, 0)
        archivoP1.Name = "archivoP1"
        archivoP1.Padding = New Padding(0, 5, 0, 1)
        archivoP1.Size = New Size(209, 32)
        archivoP1.Text = "Problema #1"
        ' 
        ' archivoP2
        ' 
        archivoP2.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        archivoP2.ImageTransparentColor = Color.Magenta
        archivoP2.Name = "archivoP2"
        archivoP2.Padding = New Padding(0, 5, 0, 1)
        archivoP2.Size = New Size(209, 32)
        archivoP2.Text = "Problema #2"
        ' 
        ' P3
        ' 
        P3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        P3.ImageTransparentColor = Color.Magenta
        P3.Name = "P3"
        P3.Padding = New Padding(0, 5, 0, 1)
        P3.Size = New Size(209, 32)
        P3.Text = "Problema #3"
        ' 
        ' ArchivoP4
        ' 
        ArchivoP4.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ArchivoP4.Name = "ArchivoP4"
        ArchivoP4.Size = New Size(209, 28)
        ArchivoP4.Text = "Problema #4"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(206, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        SalirToolStripMenuItem.Margin = New Padding(0, 15, 0, 0)
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Padding = New Padding(0, 10, 0, 1)
        SalirToolStripMenuItem.Size = New Size(209, 37)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' toolStripSeparator5
        ' 
        toolStripSeparator5.Margin = New Padding(0, 0, 0, 5)
        toolStripSeparator5.Name = "toolStripSeparator5"
        toolStripSeparator5.Size = New Size(6, 43)
        ' 
        ' ayuda
        ' 
        ayuda.DropDownItems.AddRange(New ToolStripItem() {TIP, ToolStripSeparator3, btnEmpresa})
        ayuda.Name = "ayuda"
        ayuda.Padding = New Padding(5, 20, 5, 0)
        ayuda.Size = New Size(81, 48)
        ayuda.Text = "Ayuda"
        ' 
        ' TIP
        ' 
        TIP.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TIP.Margin = New Padding(0, 20, 0, 0)
        TIP.Name = "TIP"
        TIP.Size = New Size(172, 28)
        TIP.Text = "Tip"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(169, 6)
        ' 
        ' btnEmpresa
        ' 
        btnEmpresa.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        btnEmpresa.Name = "btnEmpresa"
        btnEmpresa.Size = New Size(172, 28)
        btnEmpresa.Text = "Empresa"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Margin = New Padding(0, 0, 0, 5)
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 43)
        ' 
        ' version
        ' 
        version.DropDownItems.AddRange(New ToolStripItem() {BuscarToolStripMenuItem})
        version.Name = "version"
        version.Padding = New Padding(5, 20, 5, 0)
        version.Size = New Size(91, 48)
        version.Text = "Version"
        ' 
        ' BuscarToolStripMenuItem
        ' 
        BuscarToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BuscarToolStripMenuItem.Margin = New Padding(0, 20, 0, 0)
        BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        BuscarToolStripMenuItem.Size = New Size(224, 28)
        BuscarToolStripMenuItem.Text = "1.9"
        ' 
        ' BtnMin
        ' 
        BtnMin.Cursor = Cursors.Hand
        BtnMin.Image = CType(resources.GetObject("BtnMin.Image"), Image)
        BtnMin.Location = New Point(689, 6)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(33, 33)
        BtnMin.TabIndex = 10
        BtnMin.TabStop = False
        ' 
        ' LabelPractico
        ' 
        LabelPractico.AutoSize = True
        LabelPractico.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPractico.ForeColor = Color.FromArgb(CByte(148), CByte(166), CByte(170))
        LabelPractico.Location = New Point(425, 255)
        LabelPractico.Name = "LabelPractico"
        LabelPractico.Size = New Size(252, 46)
        LabelPractico.TabIndex = 13
        LabelPractico.Text = "PRÁCTICO #2"
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackColor = Color.Transparent
        PictureBoxLogo.BackgroundImage = My.Resources.Resources.YERKEN_SOLUTIO_gris1
        PictureBoxLogo.Location = New Point(104, 164)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(315, 181)
        PictureBoxLogo.TabIndex = 12
        PictureBoxLogo.TabStop = False
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.AutoSize = True
        LabelTitulo.Font = New Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTitulo.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        LabelTitulo.Location = New Point(425, 204)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(228, 51)
        LabelTitulo.TabIndex = 11
        LabelTitulo.Text = "EJERCICIO"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(224, 28)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' PanelP2
        ' 
        PanelP2.Location = New Point(0, 0)
        PanelP2.Name = "PanelP2"
        PanelP2.Size = New Size(200, 100)
        PanelP2.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(255, 124)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 29)
        TextBox2.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 402)
        Panel1.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(425, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 32)
        Label2.TabIndex = 10
        Label2.Text = "2DO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label3.Location = New Point(76, 271)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 55)
        Label3.TabIndex = 6
        Label3.Text = "0.00 $"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label4.Location = New Point(74, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 27)
        Label4.TabIndex = 5
        Label4.Text = "Sueldo"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBox1.Location = New Point(76, 132)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(189, 38)
        TextBox1.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label5.Location = New Point(76, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(191, 27)
        Label5.TabIndex = 2
        Label5.Text = "Horas Trabajadas"
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(391, 36)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 125)
        Panel2.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.Sin_título_11
        ClientSize = New Size(800, 450)
        Controls.Add(PanelP1)
        Controls.Add(LabelPractico)
        Controls.Add(PictureBoxLogo)
        Controls.Add(LabelTitulo)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnMin)
        Controls.Add(Menu)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        PanelP1.ResumeLayout(False)
        PanelP1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).EndInit()
        Menu.ResumeLayout(False)
        Menu.PerformLayout()
        CType(BtnMin, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents Archivo As ToolStripMenuItem
    Friend WithEvents archivoP1 As ToolStripMenuItem
    Friend WithEvents archivoP2 As ToolStripMenuItem
    Friend WithEvents P3 As ToolStripMenuItem
    Friend WithEvents ArchivoP4 As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ayuda As ToolStripMenuItem
    Friend WithEvents TIP As ToolStripMenuItem
    Friend WithEvents btnEmpresa As ToolStripMenuItem
    Friend WithEvents version As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents BtnMin As PictureBox
    Friend WithEvents LabelPractico As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents PanelP1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxHorasT As TextBox
    Friend WithEvents LabelNumero As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelResultado As Label
    Friend WithEvents LabelTítulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelP2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel2 As Panel
End Class
