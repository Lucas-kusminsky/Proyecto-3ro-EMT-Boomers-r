
Public Class Form1
    Dim num1 As String = ""
    Dim num2 As String = ""
    Dim ver As Integer = 0
    Dim cuen As String = ""
    Dim res As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cuen = "" Then
            num1 += "1"
            TextBox1.Text = num1
        Else
            num2 += "1"
            TextBox1.Text = num1 + " " + cuen + " " + num2
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cuen = "" Then
            num1 += "2"
            TextBox1.Text = num1
        Else
            num2 += "2"
            TextBox1.Text = num1 + " " + cuen + " " + num2
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cuen = "" Then
            num1 += "3"
            TextBox1.Text = num1
        Else
            num2 += "3"
            TextBox1.Text = num1 + " " + cuen + " " + num2
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If cuen = "" Then
            num1 += "4"
            TextBox1.Text = num1
        Else
            num2 += "4"
            TextBox1.Text = num1 + " " + cuen + " " + num2
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If cuen = "" Then
            num1 += "5"
            TextBox1.Text = num1
        Else
            num2 += "5"
            TextBox1.Text = num1 + " " + cuen + " " + num2
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If cuen = "" Then
            num1 += "6"
            TextBox1.Text = num1
        Else
            num2 += "6"
            TextBox1.Text = num1 + " " + cuen + " " + num2
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If cuen = "" Then
            num1 += "7"
            TextBox1.Text = num1
        Else
            num2 += "7"
            TextBox1.Text = num1 + " " + cuen + " " + num2
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If cuen = "" Then
            num1 += "8"
            TextBox1.Text = num1
        Else
            num2 += "8"
            TextBox1.Text = num1 + " " + cuen + " " + num2
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If cuen = "" Then
            num1 += "9"
            TextBox1.Text = num1
        Else
            num2 += "9"
            TextBox1.Text = num1 + " " + cuen + " " + num2
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If cuen = "" Then
            num1 += "0"
            TextBox1.Text = num1
        Else
            num2 += "0"
            TextBox1.Text = num1 + " " + cuen + " " + num2
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        num1 = ""
        num2 = ""
        cuen = ""
        ver = 0
        TextBox1.Text = ""
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If cuen = "" Then
            cuen = "+"
            TextBox1.Text += " " + cuen
        End If
        If cuen <> "" And num2 <> "" Then
            Button16.PerformClick()
            num1 = TextBox1.Text
            cuen = "+"
            TextBox1.Text += " " + cuen
        End If
        ver = 0
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If cuen = "" Then
            cuen = "-"
            TextBox1.Text += " " + cuen
        End If
        If cuen <> "" And num2 <> "" Then
            Button16.PerformClick()
            num1 = TextBox1.Text
            cuen = "-"
            TextBox1.Text += " " + cuen
        End If
        ver = 0
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If cuen = "" Then
            cuen = "*"
            TextBox1.Text += " " + cuen
        End If
        If cuen <> "" And num2 <> "" Then
            Button16.PerformClick()
            num1 = TextBox1.Text
            cuen = "*"
            TextBox1.Text += " " + cuen
        End If
        ver = 0
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If cuen = "" Then
            cuen = "/"
            TextBox1.Text += " " + cuen
        End If
        If cuen <> "" And num2 <> "" Then
            Button16.PerformClick()
            num1 = TextBox1.Text
            cuen = "/"
            TextBox1.Text += " " + cuen
        End If
        ver = 0
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If cuen = "" And ver = 0 Then
            num1 += "."
            TextBox1.Text = num1
            ver = 1
        ElseIf ver = 0 And num2 <> "" Then
            If cuen = "+" Or cuen = "-" Or cuen = "*" Or cuen = "/" Then
                num2 += "."
                TextBox1.Text = num1 + " " + cuen + " " + num2
                ver = 1

            End If
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If cuen <> "" And num2 <> "" Then
            Select Case cuen
                Case "+"
                    res = Val(num1) + Val(num2)
                Case "-"
                    res = Val(num1) - Val(num2)
                Case "*"
                    res = Val(num1) * Val(num2)
                Case "/"
                    res = Val(num1) / Val(num2)

            End Select

            TextBox1.Text = Str(res)
            Consulta = "INSERT INTO cuentas Values ('" + num1 + "', '" + cuen + "', '" + num2 + "', '" + Str(res) + "');"
            consultar()

            num1 = Str(res)
            num2 = ""
            cuen = ""
            ver = 0

            actTabla()
        End If
        
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actTabla()
    End Sub

    Private Sub actTabla()
        ListBox1.Items.Clear()
        Consulta = "select * from cuentas;"
        consultar()
        DataGridView1.DataSource = resu

        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim text As String = Str(DataGridView1.Rows(i).Cells(0).Value) + " " + DataGridView1.Rows(i).Cells(1).Value + " " + Str(DataGridView1.Rows(i).Cells(2).Value) + " = " + Str(DataGridView1.Rows(i).Cells(3).Value)
            If text.Length < 43 Then
                ListBox1.Items.Add(text)
            Else
                text = text.Substring(0, 37) + "..."
                ListBox1.Items.Add(text)
            End If

        Next

    End Sub

End Class
