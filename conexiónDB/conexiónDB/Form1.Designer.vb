<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCalculadora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCalculadora = New System.Windows.Forms.TabPage()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnComa = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnOcho = New System.Windows.Forms.Button()
        Me.btnCero = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnSeis = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnNueve = New System.Windows.Forms.Button()
        Me.btnCinco = New System.Windows.Forms.Button()
        Me.btnSiete = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnDos = New System.Windows.Forms.Button()
        Me.btnTres = New System.Windows.Forms.Button()
        Me.btnCuatro = New System.Windows.Forms.Button()
        Me.btnUno = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.tabHistorial = New System.Windows.Forms.TabPage()
        Me.dgvHistorial = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.tabCalculadora.SuspendLayout()
        Me.tabHistorial.SuspendLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabCalculadora)
        Me.TabControl1.Controls.Add(Me.tabHistorial)
        Me.TabControl1.Location = New System.Drawing.Point(0, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(387, 588)
        Me.TabControl1.TabIndex = 0
        '
        'tabCalculadora
        '
        Me.tabCalculadora.Controls.Add(Me.btnIgual)
        Me.tabCalculadora.Controls.Add(Me.btnSuma)
        Me.tabCalculadora.Controls.Add(Me.btnComa)
        Me.tabCalculadora.Controls.Add(Me.btnMultiplicacion)
        Me.tabCalculadora.Controls.Add(Me.btnOcho)
        Me.tabCalculadora.Controls.Add(Me.btnCero)
        Me.tabCalculadora.Controls.Add(Me.btnDivision)
        Me.tabCalculadora.Controls.Add(Me.btnSeis)
        Me.tabCalculadora.Controls.Add(Me.btnClear)
        Me.tabCalculadora.Controls.Add(Me.btnNueve)
        Me.tabCalculadora.Controls.Add(Me.btnCinco)
        Me.tabCalculadora.Controls.Add(Me.btnSiete)
        Me.tabCalculadora.Controls.Add(Me.btnResta)
        Me.tabCalculadora.Controls.Add(Me.btnDos)
        Me.tabCalculadora.Controls.Add(Me.btnTres)
        Me.tabCalculadora.Controls.Add(Me.btnCuatro)
        Me.tabCalculadora.Controls.Add(Me.btnUno)
        Me.tabCalculadora.Controls.Add(Me.txtResultado)
        Me.tabCalculadora.Location = New System.Drawing.Point(4, 25)
        Me.tabCalculadora.Name = "tabCalculadora"
        Me.tabCalculadora.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCalculadora.Size = New System.Drawing.Size(379, 559)
        Me.tabCalculadora.TabIndex = 0
        Me.tabCalculadora.Text = "Calculadora"
        Me.tabCalculadora.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(14, 472)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(350, 75)
        Me.btnIgual.TabIndex = 17
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'btnSuma
        '
        Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(289, 380)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(75, 75)
        Me.btnSuma.TabIndex = 16
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnComa
        '
        Me.btnComa.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComa.Location = New System.Drawing.Point(198, 380)
        Me.btnComa.Name = "btnComa"
        Me.btnComa.Size = New System.Drawing.Size(75, 75)
        Me.btnComa.TabIndex = 15
        Me.btnComa.Text = ","
        Me.btnComa.UseVisualStyleBackColor = True
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicacion.Location = New System.Drawing.Point(289, 195)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(75, 75)
        Me.btnMultiplicacion.TabIndex = 14
        Me.btnMultiplicacion.Text = "X"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnOcho
        '
        Me.btnOcho.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcho.Location = New System.Drawing.Point(105, 288)
        Me.btnOcho.Name = "btnOcho"
        Me.btnOcho.Size = New System.Drawing.Size(75, 75)
        Me.btnOcho.TabIndex = 13
        Me.btnOcho.Text = "8"
        Me.btnOcho.UseVisualStyleBackColor = True
        '
        'btnCero
        '
        Me.btnCero.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCero.Location = New System.Drawing.Point(105, 380)
        Me.btnCero.Name = "btnCero"
        Me.btnCero.Size = New System.Drawing.Size(75, 75)
        Me.btnCero.TabIndex = 12
        Me.btnCero.Text = "0"
        Me.btnCero.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(289, 103)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(75, 75)
        Me.btnDivision.TabIndex = 11
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnSeis
        '
        Me.btnSeis.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeis.Location = New System.Drawing.Point(198, 195)
        Me.btnSeis.Name = "btnSeis"
        Me.btnSeis.Size = New System.Drawing.Size(75, 75)
        Me.btnSeis.TabIndex = 10
        Me.btnSeis.Text = "6"
        Me.btnSeis.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(14, 380)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 75)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnNueve
        '
        Me.btnNueve.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNueve.Location = New System.Drawing.Point(198, 288)
        Me.btnNueve.Name = "btnNueve"
        Me.btnNueve.Size = New System.Drawing.Size(75, 75)
        Me.btnNueve.TabIndex = 8
        Me.btnNueve.Text = "9"
        Me.btnNueve.UseVisualStyleBackColor = True
        '
        'btnCinco
        '
        Me.btnCinco.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCinco.Location = New System.Drawing.Point(105, 195)
        Me.btnCinco.Name = "btnCinco"
        Me.btnCinco.Size = New System.Drawing.Size(75, 75)
        Me.btnCinco.TabIndex = 7
        Me.btnCinco.Text = "5"
        Me.btnCinco.UseVisualStyleBackColor = True
        '
        'btnSiete
        '
        Me.btnSiete.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiete.Location = New System.Drawing.Point(14, 288)
        Me.btnSiete.Name = "btnSiete"
        Me.btnSiete.Size = New System.Drawing.Size(75, 75)
        Me.btnSiete.TabIndex = 6
        Me.btnSiete.Text = "7"
        Me.btnSiete.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(289, 288)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(75, 75)
        Me.btnResta.TabIndex = 5
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnDos
        '
        Me.btnDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDos.Location = New System.Drawing.Point(105, 103)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(75, 75)
        Me.btnDos.TabIndex = 4
        Me.btnDos.Text = "2"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'btnTres
        '
        Me.btnTres.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTres.Location = New System.Drawing.Point(198, 103)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(75, 75)
        Me.btnTres.TabIndex = 3
        Me.btnTres.Text = "3"
        Me.btnTres.UseVisualStyleBackColor = True
        '
        'btnCuatro
        '
        Me.btnCuatro.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuatro.Location = New System.Drawing.Point(14, 195)
        Me.btnCuatro.Name = "btnCuatro"
        Me.btnCuatro.Size = New System.Drawing.Size(75, 75)
        Me.btnCuatro.TabIndex = 2
        Me.btnCuatro.Text = "4"
        Me.btnCuatro.UseVisualStyleBackColor = True
        '
        'btnUno
        '
        Me.btnUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUno.Location = New System.Drawing.Point(14, 103)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(75, 75)
        Me.btnUno.TabIndex = 1
        Me.btnUno.Text = "1"
        Me.btnUno.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(14, 24)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(350, 56)
        Me.txtResultado.TabIndex = 0
        '
        'tabHistorial
        '
        Me.tabHistorial.Controls.Add(Me.dgvHistorial)
        Me.tabHistorial.Location = New System.Drawing.Point(4, 25)
        Me.tabHistorial.Name = "tabHistorial"
        Me.tabHistorial.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHistorial.Size = New System.Drawing.Size(379, 559)
        Me.tabHistorial.TabIndex = 1
        Me.tabHistorial.Text = "Historial"
        Me.tabHistorial.UseVisualStyleBackColor = True
        '
        'dgvHistorial
        '
        Me.dgvHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial.Location = New System.Drawing.Point(0, 0)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.RowTemplate.Height = 24
        Me.dgvHistorial.Size = New System.Drawing.Size(379, 559)
        Me.dgvHistorial.TabIndex = 0
        '
        'fCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 584)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "fCalculadora"
        Me.Text = "Calculadora"
        Me.TabControl1.ResumeLayout(False)
        Me.tabCalculadora.ResumeLayout(False)
        Me.tabCalculadora.PerformLayout()
        Me.tabHistorial.ResumeLayout(False)
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabCalculadora As System.Windows.Forms.TabPage
    Friend WithEvents tabHistorial As System.Windows.Forms.TabPage
    Friend WithEvents btnUno As System.Windows.Forms.Button
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents btnSuma As System.Windows.Forms.Button
    Friend WithEvents btnComa As System.Windows.Forms.Button
    Friend WithEvents btnMultiplicacion As System.Windows.Forms.Button
    Friend WithEvents btnOcho As System.Windows.Forms.Button
    Friend WithEvents btnCero As System.Windows.Forms.Button
    Friend WithEvents btnDivision As System.Windows.Forms.Button
    Friend WithEvents btnSeis As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnNueve As System.Windows.Forms.Button
    Friend WithEvents btnCinco As System.Windows.Forms.Button
    Friend WithEvents btnSiete As System.Windows.Forms.Button
    Friend WithEvents btnResta As System.Windows.Forms.Button
    Friend WithEvents btnDos As System.Windows.Forms.Button
    Friend WithEvents btnTres As System.Windows.Forms.Button
    Friend WithEvents btnCuatro As System.Windows.Forms.Button
    Friend WithEvents btnIgual As System.Windows.Forms.Button
    Friend WithEvents dgvHistorial As System.Windows.Forms.DataGridView

End Class
