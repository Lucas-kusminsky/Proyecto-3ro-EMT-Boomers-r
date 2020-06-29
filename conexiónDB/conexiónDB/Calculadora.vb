Public Class fCalculadora
    Public primerValor As Double
    Public calculo As String

    Private Sub btnUno_Click(sender As System.Object, e As System.EventArgs) Handles btnUno.Click
        limpiarOperacion()
        txtResultado.Text = txtResultado.Text + Str(1)
    End Sub

    Private Sub btnDos_Click(sender As System.Object, e As System.EventArgs) Handles btnDos.Click
        limpiarOperacion()
        txtResultado.Text = txtResultado.Text + Str(2)
    End Sub

    Private Sub btnTres_Click(sender As System.Object, e As System.EventArgs) Handles btnTres.Click
        limpiarOperacion()
        txtResultado.Text = txtResultado.Text + Str(3)
    End Sub

    Private Sub btnCuatro_Click(sender As System.Object, e As System.EventArgs) Handles btnCuatro.Click
        limpiarOperacion()
        txtResultado.Text = txtResultado.Text + Str(4)
    End Sub

    Private Sub btnCinco_Click(sender As System.Object, e As System.EventArgs) Handles btnCinco.Click
        limpiarOperacion()
        txtResultado.Text = txtResultado.Text + Str(5)
    End Sub

    Private Sub btnSeis_Click(sender As System.Object, e As System.EventArgs) Handles btnSeis.Click
        limpiarOperacion()
        txtResultado.Text = txtResultado.Text + Str(6)
    End Sub

    Private Sub btnSiete_Click(sender As System.Object, e As System.EventArgs) Handles btnSiete.Click
        limpiarOperacion()
        txtResultado.Text = txtResultado.Text + Str(7)
    End Sub

    Private Sub btnOcho_Click(sender As System.Object, e As System.EventArgs) Handles btnOcho.Click
        limpiarOperacion()
        txtResultado.Text = txtResultado.Text + Str(8)
    End Sub

    Private Sub btnNueve_Click(sender As System.Object, e As System.EventArgs) Handles btnNueve.Click
        limpiarOperacion()
        txtResultado.Text = txtResultado.Text + Str(9)
    End Sub

    Private Sub btnCero_Click(sender As System.Object, e As System.EventArgs) Handles btnCero.Click
        limpiarOperacion()
        txtResultado.Text = txtResultado.Text + Str(0)
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        limpiarPantalla()
    End Sub

    Private Sub btnComa_Click(sender As System.Object, e As System.EventArgs) Handles btnComa.Click
        If (txtResultado.Text.Contains(".") = False And txtResultado.Text.Contains(",") = False And txtResultado.Text <> "" And txtResultado.Text.Contains("+") = False And txtResultado.Text.Contains("-") = False And txtResultado.Text.Contains("/") = False And txtResultado.Text.Contains("X") = False) Then
            txtResultado.Text = txtResultado.Text + "."
        End If
    End Sub

    Private Sub btnDivision_Click(sender As System.Object, e As System.EventArgs) Handles btnDivision.Click
        primerValor = Val(txtResultado.Text)
        calculo = "/"
        txtResultado.Text = calculo
    End Sub

    Private Sub btnMultiplicacion_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiplicacion.Click
        primerValor = Val(txtResultado.Text)
        calculo = "X"
        txtResultado.Text = calculo
    End Sub

    Private Sub btnResta_Click(sender As System.Object, e As System.EventArgs) Handles btnResta.Click
        primerValor = Val(txtResultado.Text)
        calculo = "-"
        txtResultado.Text = calculo
    End Sub

    Private Sub btnSuma_Click(sender As System.Object, e As System.EventArgs) Handles btnSuma.Click
        primerValor = Val(txtResultado.Text)
        calculo = "+"
        txtResultado.Text = calculo
    End Sub

    Private Sub btnIgual_Click(sender As System.Object, e As System.EventArgs) Handles btnIgual.Click
        Dim segundoValor As Double = Val(txtResultado.Text)

        Select Case calculo
            Case "/"
                txtResultado.Text = primerValor / segundoValor
            Case "X"
                txtResultado.Text = primerValor * segundoValor
            Case "-"
                txtResultado.Text = primerValor - segundoValor
            Case "+"
                txtResultado.Text = primerValor + segundoValor
        End Select

        registrarHistorial(Str(primerValor), calculo, Str(segundoValor), Str(txtResultado.Text))
    End Sub

    Private Sub fCalculadora_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conexion()
        cargarHistorial()
    End Sub

    Private Sub cargarHistorial()
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim sql As String = "SELECT primerValor, calculo, segundoValor, resultado FROM historial"
        ds = consultar(sql)

        dgvHistorial.DataSource = ds
        dgvHistorial.DataMember = "Historial"

        dgvHistorial.Columns(0).HeaderText = "1er. Valor"
        dgvHistorial.Columns(1).HeaderText = "Cálculo"
        dgvHistorial.Columns(2).HeaderText = "2do. Valor"
        dgvHistorial.Columns(3).HeaderText = "Resultado"
    End Sub

    Private Sub registrarHistorial(ByVal prim As String, ByVal calc As String, ByVal segu As String, ByVal resu As String)
        Dim sql As String = "INSERT INTO historial (primerValor, calculo, segundoValor, resultado) VALUES ('" & prim & "', '" & calc & "', '" & segu & "', '" & resu & "')"

        consultar(sql)
        cargarHistorial()
    End Sub

    Private Sub limpiarPantalla()
        txtResultado.Text = ""
    End Sub

    Private Sub limpiarOperacion()
        If (txtResultado.Text.Contains("+") = True Or txtResultado.Text.Contains("-") = True Or txtResultado.Text.Contains("/") = True Or txtResultado.Text.Contains("X") = True) Then
            limpiarPantalla()
        End If
    End Sub

    Private Sub txtResultado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtResultado.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
