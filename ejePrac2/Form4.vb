Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form4

    'VARIABLES
    Dim minAmNacionalLocal, minPmNacionalLocal, minAmLargaDnacional, minPmLargaDnacional, minAmLargaDinter, minPmLargaDinter As Integer
    Dim locales As Double = 0
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 45) ' Establecer la nueva ubicación de Form2 en relación con Form1
        minAmNacionalLocal = 0
        minPmNacionalLocal = 0
        minAmLargaDnacional = 0
        minPmLargaDnacional = 0
        minAmLargaDinter = 0
        minPmLargaDinter = 0
        btnCalcular.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label5.Text = "-10"
        Label6.Text = "-10"
        PanelResultado.Visible = False
    End Sub

    Private Sub ListaLlamada_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListaLlamada.SelectedValueChanged

        If ListaLlamada.Text = "Nacional local" Then
            TextBoxMinAm.Text = minAmNacionalLocal
            TextBoxMinPm.Text = minPmNacionalLocal

            'PictureBox1.BackgroundImage = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\3. LABORATORIOS PRÁCTICOS\EJERCICIO PRÁCTICO #2\ejePrac2\ejePrac2\IMG\BICI.jpg")

        ElseIf ListaLlamada.Text = "Larga distancia nacional" Then

            TextBoxMinAm.Text = minAmLargaDnacional
            TextBoxMinPm.Text = minPmLargaDnacional

            'PictureBox1.BackgroundImage = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\3. LABORATORIOS PRÁCTICOS\EJERCICIO PRÁCTICO #2\ejePrac2\ejePrac2\IMG\moto.jpg")

        ElseIf ListaLlamada.Text = "Larga distancia internacional" Then

            TextBoxMinAm.Text = minAmLargaDinter
            TextBoxMinPm.Text = minPmLargaDinter

            'PictureBox1.BackgroundImage = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\3. LABORATORIOS PRÁCTICOS\EJERCICIO PRÁCTICO #2\ejePrac2\ejePrac2\IMG\CARRO.jpg")

        End If

        TextBoxMinAm.BackColor = Color.White
        TextBoxMinPm.BackColor = Color.White

    End Sub

    'CONTROL..--------------------------------------------------------------------------------------------------------------------
    Private Sub TextBoxMinAm_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMinAm.TextChanged

        If TextBoxMinAm.Text <> "" Then

            'ERROR DE DESBORDAMIENTO
            If TextBoxMinAm.Text > Integer.MaxValue Then

                TextBoxMinAm.BackColor = Color.FromArgb(255, 222, 222)
                MessageBox.Show("ERROR: DESBORDAMIENTO INT MAX = " & Integer.MaxValue, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxMinAm.Text = TextBoxMinAm.Text.Substring(0, TextBoxMinAm.Text.Length - 1)
                TextBoxMinAm.BackColor = Color.White
            Else
                TextBoxMinAm.BackColor = Color.White
            End If

        End If
    End Sub

    Private Sub TextBoxMinAm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMinAm.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            TextBoxMinAm.BackColor = Color.FromArgb(255, 222, 222)
            e.Handled = True
            MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            TextBoxMinAm.BackColor = Color.White
        End If
    End Sub


    Private Sub TextBoxMinPm_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMinPm.TextChanged
        If TextBoxMinPm.Text <> "" Then

            'ERROR DE DESBORDAMIENTO
            If TextBoxMinPm.Text > Integer.MaxValue Then

                TextBoxMinPm.BackColor = Color.FromArgb(255, 222, 222)
                MessageBox.Show("ERROR: DESBORDAMIENTO INT MAX = " & Integer.MaxValue, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxMinPm.Text = TextBoxMinPm.Text.Substring(0, TextBoxMinPm.Text.Length - 1)
                TextBoxMinPm.BackColor = Color.White

            Else
                TextBoxMinPm.BackColor = Color.White
            End If

        End If
    End Sub

    Private Sub TextBoxMinPm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMinPm.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            TextBoxMinPm.BackColor = Color.FromArgb(255, 222, 222)
            e.Handled = True
            MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            TextBoxMinPm.BackColor = Color.White
        End If
    End Sub



    'boton ingresar guardado de variables

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        If ListaLlamada.Text = "Nacional local" Then

            minAmNacionalLocal = TextBoxMinAm.Text
            minPmNacionalLocal = TextBoxMinPm.Text
            TextBoxMinAm.BackColor = Color.FromArgb(207, 255, 235)
            TextBoxMinPm.BackColor = Color.FromArgb(207, 255, 235)
            btnCalcular.Visible = True

        ElseIf ListaLlamada.Text = "Larga distancia nacional" Then

            minAmLargaDnacional = TextBoxMinAm.Text
            minPmLargaDnacional = TextBoxMinPm.Text
            TextBoxMinAm.BackColor = Color.FromArgb(207, 255, 235)
            TextBoxMinPm.BackColor = Color.FromArgb(207, 255, 235)
            btnCalcular.Visible = True

        ElseIf ListaLlamada.Text = "Larga distancia internacional" Then

            minAmLargaDinter = TextBoxMinAm.Text
            minPmLargaDinter = TextBoxMinPm.Text
            TextBoxMinAm.BackColor = Color.FromArgb(207, 255, 235)
            TextBoxMinPm.BackColor = Color.FromArgb(207, 255, 235)
            btnCalcular.Visible = True
        End If



    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        '10 min locales gratis CUALQUIER HORARIO
        PanelResultado.Visible = True

        LabelMinAmLocal.Text = minAmNacionalLocal
        LabelMinPmLocal.Text = minPmNacionalLocal


        LabelMinAmNacional.Text = minAmLargaDnacional
        LabelMinPmNacional.Text = minPmLargaDnacional

        LabelMinAmInter.Text = minAmLargaDinter
        LabelMinPmInter.Text = minPmLargaDinter

        'DESCUENTO DEPENDIENDO--------------------------------------------------------

        'AM
        If minAmNacionalLocal > 0 Then

            If (minAmNacionalLocal - 10) < 0 Then

                minAmNacionalLocal = 0

            Else
                minAmNacionalLocal -= 10
            End If
            Label5.Visible = True
            Label6.Visible = False
            'PM
        ElseIf minPmNacionalLocal > 0 Then

            If (minPmNacionalLocal - 10) < 0 Then

                minPmNacionalLocal = 0

            Else
                minPmNacionalLocal -= 10
            End If
            Label6.Visible = True
            Label5.Visible = False
        End If

        MsgBox("MIN local AM: " & minAmNacionalLocal & vbCrLf & "MIN local PM: " & minPmNacionalLocal)

        'MsgBox("TOTAL LLAMADAS AM: " & Math.Round(((minAmNacionalLocal * 0.06) + (minAmLargaDnacional * 0.12) + (minAmLargaDinter * 0.2)), 2))
        'MsgBox("TOTAL LLAMADAS PM: " & Math.Round(((minPmNacionalLocal * 0.03) + (minPmLargaDnacional * 0.06) + (minPmLargaDinter * 0.1)), 2))
        'MsgBox("TOTA: " & Math.Round(((Math.Round(((minPmNacionalLocal * 0.03) + (minPmLargaDnacional * 0.06) + (minPmLargaDinter * 0.1)), 2)) + (Math.Round(((minAmNacionalLocal * 0.06) + (minAmLargaDnacional * 0.12) + (minAmLargaDinter * 0.2)), 2))), 2))

        LabelTotalLocal.Text = Math.Round(((minAmNacionalLocal * 0.06) + (minPmNacionalLocal * 0.03)), 2) & " $"
        LabelTotalnacional.Text = Math.Round(((minAmLargaDnacional * 0.12) + (minPmLargaDnacional * 0.06)), 2) & " $"
        LabelTotalinter.Text = Math.Round(((minAmLargaDinter * 0.2) + (minPmLargaDinter * 0.1)), 2) & " $"


        LabelTotal.Text = Math.Round(((Math.Round(((minPmNacionalLocal * 0.03) + (minPmLargaDnacional * 0.06) + (minPmLargaDinter * 0.1)), 2)) + (Math.Round(((minAmNacionalLocal * 0.06) + (minAmLargaDnacional * 0.12) + (minAmLargaDinter * 0.2)), 2))), 2) & " $"

        'REINICIO DE VARIABLES
        TextBoxMinAm.BackColor = Color.White
        TextBoxMinPm.BackColor = Color.White

        reinicio()
        btnCalcular.Visible = False
    End Sub

    Sub reinicio()
        minAmNacionalLocal = 0
        minPmNacionalLocal = 0
        minAmLargaDnacional = 0
        minPmLargaDnacional = 0
        minAmLargaDinter = 0
        minPmLargaDinter = 0
        TextBoxMinAm.Text = 0
        TextBoxMinPm.Text = 0
    End Sub

    'BTN VOLVER
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        PanelResultado.Visible = False

    End Sub
End Class