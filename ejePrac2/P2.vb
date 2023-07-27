Public Class P2
    Dim contadorDot As Integer = 0
    Dim interes As Double
    Private Sub P2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 45) ' Establecer la nueva ubicación de Form2 en relación con Form1
        LabelInteres.Text = ""
    End Sub


    'TEXBOX DÍAS-----------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub TextBoxDías_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDías.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            TextBoxDías.BackColor = Color.FromArgb(255, 222, 222)
            e.Handled = True
            MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            TextBoxDías.BackColor = Color.White

        End If

    End Sub

    Private Sub TextBoxDías_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDías.TextChanged
        If TextBoxDías.Text <> "" Then

            'ERROR DE DESBORDAMIENTO
            If TextBoxDías.Text > Integer.MaxValue Then

                TextBoxDías.BackColor = Color.FromArgb(255, 222, 222)
                MessageBox.Show("ERROR: DESBORDAMIENTO INT MAX = " & Integer.MaxValue, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxDías.Text = TextBoxDías.Text.Substring(0, TextBoxDías.Text.Length - 1)
                TextBoxDías.BackColor = Color.White

            Else
                TextBoxDías.BackColor = Color.White
                fCalculo()
            End If

        Else

            LabelResultado.Text = "0.00 $"
        End If
    End Sub




    'TEXBOX MONTO-----------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub TextBoxMonto_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMonto.TextChanged

        If TextBoxMonto.Text <> "" Then

            If TextBoxMonto.Text > 10000000 Then

                TextBoxMonto.BackColor = Color.FromArgb(255, 222, 222)
                MessageBox.Show("ERROR: DESBORDAMIENTO, MAX = " & "10,000,000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxMonto.Text = TextBoxMonto.Text.Substring(0, TextBoxMonto.Text.Length - 1)
                TextBoxMonto.BackColor = Color.White
            Else

                If TextBoxMonto.Text.Count(Function(c) c = ".") = 0 And contadorDot = 1 Then
                    contadorDot = 0
                Else
                    fCalculo()
                End If

            End If



        Else
            LabelResultado.Text = "0.00 $"
        End If


    End Sub

    Private Sub TextBoxMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMonto.KeyPress

        'CANCELACIÓN
        If contadorDot = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

                TextBoxMonto.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                If e.KeyChar = "." Then
                    contadorDot += 1
                End If

                TextBoxMonto.BackColor = Color.White

            End If

        Else

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                TextBoxMonto.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                TextBoxMonto.BackColor = Color.White
            End If

        End If

    End Sub


    Sub fCalculo()

        'TEXBOX VACIAS ? 
        If TextBoxMonto.Text <> "" And TextBoxDías.Text <> "" Then

            '? INTERES
            If TextBoxDías.Text >= 30 And TextBoxDías.Text <= 60 Then
                LabelInteres.Text = "+2%"
                LabelResultado.Text = Math.Round(TextBoxMonto.Text * 1.02, 2) & " $"

            ElseIf TextBoxDías.Text >= 61 And TextBoxDías.Text <= 90 Then
                LabelInteres.Text = "+5%"
                LabelResultado.Text = Math.Round(TextBoxMonto.Text * 1.05, 2) & " $"

            ElseIf TextBoxDías.Text >= 91 And TextBoxDías.Text <= 129 Then
                LabelInteres.Text = "+7%"
                LabelResultado.Text = Math.Round(TextBoxMonto.Text * 1.07, 2) & " $"

            ElseIf TextBoxDías.Text > 129 Then
                LabelInteres.Text = "+15%"
                LabelResultado.Text = Math.Round(TextBoxMonto.Text * 1.15, 2) & " $"
            Else
                LabelInteres.Text = ""
                LabelResultado.Text = TextBoxMonto.Text
            End If

        End If


    End Sub


End Class