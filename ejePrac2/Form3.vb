Public Class Form3

    Dim contadorDot As Integer = 0
    Dim contadorDot2 As Integer = 0


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 45) ' Establecer la nueva ubicación de Form2 en relación con Form1

        TextBoxKm.Enabled = False
        TextBoxTone.Enabled = False
        LabelResultado.Text = "--- $"

    End Sub


    Private Sub ListaVe_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListaVe.SelectedValueChanged

        If ListaVe.Text = "Bicicleta" Then
            limpiar()
            TextBoxKm.Enabled = False
            TextBoxTone.Enabled = False
            LabelResultado.Text = "100 $"
            PictureBox1.BackgroundImage = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\3. LABORATORIOS PRÁCTICOS\EJERCICIO PRÁCTICO #2\ejePrac2\ejePrac2\IMG\BICI.jpg")

        ElseIf ListaVe.Text = "Moto" Then
            limpiar()
            TextBoxKm.Enabled = True
            TextBoxTone.Enabled = False
            PictureBox1.BackgroundImage = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\3. LABORATORIOS PRÁCTICOS\EJERCICIO PRÁCTICO #2\ejePrac2\ejePrac2\IMG\moto.jpg")
            LabelResultado.Text = "--- $"
        ElseIf ListaVe.Text = "Carro" Then
            limpiar()
            TextBoxKm.Enabled = True
            TextBoxTone.Enabled = False
            PictureBox1.BackgroundImage = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\3. LABORATORIOS PRÁCTICOS\EJERCICIO PRÁCTICO #2\ejePrac2\ejePrac2\IMG\CARRO.jpg")
            LabelResultado.Text = "--- $"
        ElseIf ListaVe.Text = "Camión" Then
            limpiar()
            TextBoxKm.Enabled = True
            TextBoxTone.Enabled = True
            PictureBox1.BackgroundImage = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\3. LABORATORIOS PRÁCTICOS\EJERCICIO PRÁCTICO #2\ejePrac2\ejePrac2\IMG\camion.jpg")
            LabelResultado.Text = "--- $"
        End If

    End Sub

    Private Sub TextBoxKm_TextChanged(sender As Object, e As EventArgs) Handles TextBoxKm.TextChanged

        If TextBoxKm.Text <> "" And TextBoxKm.Text <> "." Then

            'ERROR DE DESBORDAMIENTO
            If TextBoxKm.Text > 10000000 Then

                TextBoxKm.BackColor = Color.FromArgb(255, 222, 222)
                MessageBox.Show("ERROR: DESBORDAMIENTO, MAX = " & "10,000,000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxKm.Text = TextBoxKm.Text.Substring(0, TextBoxKm.Text.Length - 1)
                TextBoxKm.BackColor = Color.White
            Else

                If TextBoxKm.Text.Count(Function(c) c = ".") = 0 And contadorDot = 1 Then
                    contadorDot = 0
                Else
                    fCalculo()
                End If

            End If


        End If



    End Sub

    Private Sub TextBoxKm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxKm.KeyPress
        'CANCELACIÓN
        If contadorDot = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

                TextBoxKm.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                If e.KeyChar = "." Then
                    contadorDot += 1
                End If

                TextBoxKm.BackColor = Color.White

            End If

        Else

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                TextBoxKm.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                TextBoxKm.BackColor = Color.White
            End If

        End If
    End Sub



    Private Sub TextBoxTone_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTone.TextChanged


        If TextBoxTone.Text <> "" And TextBoxTone.Text <> "." Then

            'ERROR DE DESBORDAMIENTO
            If TextBoxTone.Text > 10000000 Then

                TextBoxTone.BackColor = Color.FromArgb(255, 222, 222)
                MessageBox.Show("ERROR: DESBORDAMIENTO, MAX = " & "10,000,000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxTone.Text = TextBoxTone.Text.Substring(0, TextBoxTone.Text.Length - 1)
                TextBoxTone.BackColor = Color.White
            Else

                If TextBoxTone.Text.Count(Function(c) c = ".") = 0 And contadorDot2 = 1 Then
                    contadorDot2 = 0
                Else

                    fCalculo()

                End If

            End If
        End If





    End Sub

    Private Sub TextBoxTone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTone.KeyPress
        'CANCELACIÓN
        If contadorDot2 = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

                TextBoxTone.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                If e.KeyChar = "." Then
                    contadorDot2 += 1
                End If

                TextBoxTone.BackColor = Color.White

            End If

        Else

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                TextBoxTone.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                TextBoxTone.BackColor = Color.White
            End If

        End If
    End Sub



    'TEXT CHANGE

    Sub fCalculo()

        If ListaVe.Text = "Moto" Or ListaVe.Text = "Carro" Then

            If TextBoxKm.Text <> "" Then
                LabelResultado.Text = Math.Round((30 * TextBoxKm.Text), 2) & " $"
            End If

        ElseIf ListaVe.Text = "Camión" Then

            If TextBoxKm.Text <> "" And TextBoxTone.Text <> "" Then

                LabelResultado.Text = Math.Round(((30 * Double.Parse(TextBoxKm.Text)) + (25 * Double.Parse(TextBoxTone.Text))), 2) & " $"
            End If

        End If
    End Sub

    Sub limpiar()
        TextBoxKm.Clear()
        TextBoxTone.Clear()
    End Sub


End Class