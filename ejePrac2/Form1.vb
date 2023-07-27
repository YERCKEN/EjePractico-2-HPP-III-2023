Imports System.Buffers
Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.InteropServices
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form1

    'VARIABLES-------------------------


    'CARGA DEL FORMS
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelP1.Visible = False
        P2.Visible = False
        Form3.Visible = False
        Form4.Visible = False
        empresa.Visible = False

    End Sub



    Private Sub archivoP1_Click(sender As Object, e As EventArgs) Handles archivoP1.Click
        PanelP1.Visible = True
        P2.Visible = False
        Form3.Visible = False
        Form4.Visible = False
        empresa.Visible = False
        fPantallaInicioHide()
    End Sub

    Private Sub archivoP2_Click(sender As Object, e As EventArgs) Handles archivoP2.Click
        PanelP1.Visible = False
        Form3.Visible = False
        P2.Owner = Me
        P2.Show()
        Form4.Visible = False
        empresa.Visible = False
        fPantallaInicioHide()
    End Sub

    Private Sub P3_Click(sender As Object, e As EventArgs) Handles P3.Click
        PanelP1.Visible = False
        P2.Close()

        Form3.Show()
        Form3.Owner = Me
        Form4.Visible = False
        empresa.Visible = False
        fPantallaInicioHide()

    End Sub

    Private Sub ArchivoP4_Click(sender As Object, e As EventArgs) Handles ArchivoP4.Click
        PanelP1.Visible = False
        P2.Close()
        Form3.Close()
        Form4.Owner = Me
        Form4.Show()
        empresa.Visible = False
        'Form4.TopMost() = True
        fPantallaInicioHide()
    End Sub

    Private Sub btnEmpresa_Click(sender As Object, e As EventArgs) Handles btnEmpresa.Click
        P2.Visible = False
        Form3.Visible = False
        Form4.Visible = False
        empresa.Visible = True
        empresa.Owner = Me
        fPantallaInicioHide()
    End Sub




    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub LabelPractico_Click(sender As Object, e As EventArgs) Handles LabelPractico.Click

    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub




    'TEXT BOX-----------------------------------------------------------------------------------------------------
    Private Sub TextBoxHorasT_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHorasT.TextChanged

        If TextBoxHorasT.Text <> "" Then

            'ERROR DE DESBORDAMIENTO
            If TextBoxHorasT.Text > 168 Then

                TextBoxHorasT.BackColor = Color.FromArgb(255, 222, 222)
                MessageBox.Show("ERROR: DESBORDAMIENTO MAX = " & 168, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxHorasT.Text = TextBoxHorasT.Text.Substring(0, TextBoxHorasT.Text.Length - 1)

            Else
                TextBoxHorasT.BackColor = Color.White

                If Integer.Parse(TextBoxHorasT.Text) > 35 Then

                    LabelResultado.Text = 15.0 * 35 + ((Integer.Parse(TextBoxHorasT.Text) - 35) * 22.5) & " $"

                Else

                    LabelResultado.Text = 15.0 * Integer.Parse(TextBoxHorasT.Text) & " $"

                End If

            End If

        Else
            LabelResultado.Text = "0.00 $"

        End If



    End Sub

    Private Sub TextBoxHorasT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHorasT.KeyPress


        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            TextBoxHorasT.BackColor = Color.FromArgb(255, 222, 222)
            e.Handled = True
            MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else

            TextBoxHorasT.BackColor = Color.White

        End If

    End Sub


    'MOVER VENTANA

    Private Sub Menu_MouseDown(sender As Object, e As MouseEventArgs) Handles Menu.MouseDown



        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If


    End Sub

    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged

        If P2 IsNot Nothing Then ' Verificar si el Formulario 2 está abierto
            P2.Location = New Point(Me.Location.X, Me.Location.Y + 45) ' Establecer la nueva ubicación de Form2 en relación con Form1
        End If

        If Form3 IsNot Nothing Then ' Verificar si el Formulario 2 está abierto
            Form3.Location = New Point(Me.Location.X, Me.Location.Y + 45) ' Establecer la nueva ubicación de Form2 en relación con Form1
        End If


        If Form4 IsNot Nothing Then ' Verificar si el Formulario 2 está abierto
            Form4.Location = New Point(Me.Location.X, Me.Location.Y + 45) ' Establecer la nueva ubicación de Form2 en relación con Form1
        End If

        If empresa IsNot Nothing Then ' Verificar si el Formulario 2 está abierto
            empresa.Location = New Point(Me.Location.X, Me.Location.Y + 45) ' Establecer la nueva ubicación de Form2 en relación con Form1
        End If
    End Sub




    'Declaración de la función SendMessage
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    'Declaración de la función ReleaseCapture
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Sub fPantallaInicioHide()

        PictureBoxLogo.Visible = False
        LabelTitulo.Visible = False
        LabelPractico.Visible = False
        Me.BackgroundImage = Nothing


    End Sub

    Private Sub TIP_Click(sender As Object, e As EventArgs) Handles TIP.Click

        If P2.Visible Then ' Verificar si el Formulario 2 está abierto

            MessageBox.Show("CÁLCULO DEL MONTO QUE ADEUDA EL CLIENTE" & vbCrLf & vbCrLf & vbCrLf & "INTERÉS POR ATRASO:" & vbCrLf & vbCrLf & "30 a 60 Días = 2%" & vbCrLf & "61 a 90 Días = 5%" & vbCrLf & "90 a 129 Días = 7%" & vbCrLf & "129 o Más Días = 15%" & vbCrLf& & vbCrLf & "CONSIDERACIONES: " & vbCrLf & vbCrLf & "-Monto: " & vbCrLf & vbCrLf & "Límite de Desbordamiento: 10,000,000" & vbCrLf & "Se admite valores flotantes" & vbCrLf & vbCrLf & "-Días de Atraso: " & vbCrLf & vbCrLf & "Límite de Desbordamiento: " & Integer.MaxValue & "   ( Integer.MaxValue )" & vbCrLf & "Sólo Serán Válidos Valores Enteros", "TIP y INFOMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Form3.Visible Then ' Verificar si el Formulario 2 está abierto
            MessageBox.Show("CÁLCULO DEL IMPORTE A PAGAR POR UN VEHÍCULO AL CIRCULAR POR UNA AUTOPISTA" & vbCrLf & vbCrLf & vbCrLf & "a) Un importe fijo de 100 unidades para la bicicleta." & vbCrLf& & "b) Las motos y los carros pagaran 30 unidades por Km." & vbCrLf& & "c) Los camiones pagaran 30 unidades por Km, más 25 unidades por toneladas." & vbCrLf& & vbCrLf & "CONSIDERACIONES: " & vbCrLf & vbCrLf & "-KM recorridos y Toneladas: " & vbCrLf & vbCrLf & "Límite de Desbordamiento: 10,000,000" & vbCrLf & "Se admite valores flotantes", "TIP y INFOMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Form4.Visible Then ' Verificar si el Formulario 2 está abierto

            MessageBox.Show("CALCULO DE LAS FACTURAS MENSUAL SERVICIO TELEFÓNICO" & vbCrLf & vbCrLf & vbCrLf & "$0.03 por minuto la llamada nacional loca" & vbCrLf & "$0.06 por la llamada de larga distancia nacional" & vbCrLf & "$0.10 la llamada de larga distancia internacional." & vbCrLf & "si las llamadas fueron realizadas por la mañana tienen un doble valor" & vbCrLf & "los 10 primeros minutos de llamadas locales son gratis, en cualquier horario." & vbCrLf & vbCrLf & "CONSIDERACIONES: " & vbCrLf & vbCrLf & "Límite de Desbordamiento: " & Integer.MaxValue & "   ( Integer.MaxValue )" & vbCrLf & "Sólo Serán Válidos Valores Enteros", "TIP y INFOMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf PanelP1.Visible Then ' Verificar si el Formulario 2 está abierto
            MessageBox.Show("CÁLCULO DE SALARIO SEMANAL" & vbCrLf & vbCrLf & vbCrLf & "Salario × Hora = 15.00 $" & vbCrLf & "Cada hora por encima de 35 horas se considerará extra y se paga a B/. 22.50 $" & vbCrLf & vbCrLf & "CONSIDERACIONES: " & vbCrLf & vbCrLf & "Límite de Desbordamiento: " & 168 & "   ( HORAS SEMANALES )" & vbCrLf & "Sólo Serán Válidos Valores Enteros", "TIP y INFOMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub


End Class
