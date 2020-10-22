<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calc))
        Me.txtpantalla = New System.Windows.Forms.TextBox()
        Me.btnborrartodo = New System.Windows.Forms.Button()
        Me.btnborrarderecha = New System.Windows.Forms.Button()
        Me.btnporcentaje = New System.Windows.Forms.Button()
        Me.btnmasmenos = New System.Windows.Forms.Button()
        Me.btnraiz = New System.Windows.Forms.Button()
        Me.btnpotencia = New System.Windows.Forms.Button()
        Me.btndivicion = New System.Windows.Forms.Button()
        Me.btnnueve = New System.Windows.Forms.Button()
        Me.btnocho = New System.Windows.Forms.Button()
        Me.btnsiete = New System.Windows.Forms.Button()
        Me.btninversa = New System.Windows.Forms.Button()
        Me.btnmultiplicacion = New System.Windows.Forms.Button()
        Me.btnseis = New System.Windows.Forms.Button()
        Me.btncinco = New System.Windows.Forms.Button()
        Me.btncuatro = New System.Windows.Forms.Button()
        Me.btnigual = New System.Windows.Forms.Button()
        Me.btnresta = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btnuno = New System.Windows.Forms.Button()
        Me.btnsuma = New System.Windows.Forms.Button()
        Me.btnpunto = New System.Windows.Forms.Button()
        Me.btncero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtpantalla
        '
        Me.txtpantalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpantalla.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpantalla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtpantalla.Location = New System.Drawing.Point(12, 35)
        Me.txtpantalla.Multiline = True
        Me.txtpantalla.Name = "txtpantalla"
        Me.txtpantalla.Size = New System.Drawing.Size(284, 50)
        Me.txtpantalla.TabIndex = 0
        '
        'btnborrartodo
        '
        Me.btnborrartodo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnborrartodo.Location = New System.Drawing.Point(12, 91)
        Me.btnborrartodo.Name = "btnborrartodo"
        Me.btnborrartodo.Size = New System.Drawing.Size(52, 48)
        Me.btnborrartodo.TabIndex = 1
        Me.btnborrartodo.Text = "CE"
        Me.btnborrartodo.UseVisualStyleBackColor = False
        '
        'btnborrarderecha
        '
        Me.btnborrarderecha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnborrarderecha.Location = New System.Drawing.Point(70, 91)
        Me.btnborrarderecha.Name = "btnborrarderecha"
        Me.btnborrarderecha.Size = New System.Drawing.Size(52, 48)
        Me.btnborrarderecha.TabIndex = 2
        Me.btnborrarderecha.Text = "<--"
        Me.btnborrarderecha.UseVisualStyleBackColor = False
        '
        'btnporcentaje
        '
        Me.btnporcentaje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnporcentaje.Location = New System.Drawing.Point(128, 91)
        Me.btnporcentaje.Name = "btnporcentaje"
        Me.btnporcentaje.Size = New System.Drawing.Size(52, 48)
        Me.btnporcentaje.TabIndex = 3
        Me.btnporcentaje.Text = "%"
        Me.btnporcentaje.UseVisualStyleBackColor = False
        '
        'btnmasmenos
        '
        Me.btnmasmenos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnmasmenos.Location = New System.Drawing.Point(186, 91)
        Me.btnmasmenos.Name = "btnmasmenos"
        Me.btnmasmenos.Size = New System.Drawing.Size(52, 48)
        Me.btnmasmenos.TabIndex = 4
        Me.btnmasmenos.Text = "+/-"
        Me.btnmasmenos.UseVisualStyleBackColor = False
        '
        'btnraiz
        '
        Me.btnraiz.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnraiz.Location = New System.Drawing.Point(244, 91)
        Me.btnraiz.Name = "btnraiz"
        Me.btnraiz.Size = New System.Drawing.Size(52, 48)
        Me.btnraiz.TabIndex = 5
        Me.btnraiz.Text = "√"
        Me.btnraiz.UseVisualStyleBackColor = False
        '
        'btnpotencia
        '
        Me.btnpotencia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnpotencia.Location = New System.Drawing.Point(244, 145)
        Me.btnpotencia.Name = "btnpotencia"
        Me.btnpotencia.Size = New System.Drawing.Size(52, 48)
        Me.btnpotencia.TabIndex = 10
        Me.btnpotencia.Text = "^"
        Me.btnpotencia.UseVisualStyleBackColor = False
        '
        'btndivicion
        '
        Me.btndivicion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btndivicion.Location = New System.Drawing.Point(186, 145)
        Me.btndivicion.Name = "btndivicion"
        Me.btndivicion.Size = New System.Drawing.Size(52, 48)
        Me.btndivicion.TabIndex = 9
        Me.btndivicion.Text = "/"
        Me.btndivicion.UseVisualStyleBackColor = False
        '
        'btnnueve
        '
        Me.btnnueve.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnnueve.Location = New System.Drawing.Point(128, 145)
        Me.btnnueve.Name = "btnnueve"
        Me.btnnueve.Size = New System.Drawing.Size(52, 48)
        Me.btnnueve.TabIndex = 8
        Me.btnnueve.Text = "9"
        Me.btnnueve.UseVisualStyleBackColor = False
        '
        'btnocho
        '
        Me.btnocho.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnocho.Location = New System.Drawing.Point(70, 145)
        Me.btnocho.Name = "btnocho"
        Me.btnocho.Size = New System.Drawing.Size(52, 48)
        Me.btnocho.TabIndex = 7
        Me.btnocho.Text = "8"
        Me.btnocho.UseVisualStyleBackColor = False
        '
        'btnsiete
        '
        Me.btnsiete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnsiete.Location = New System.Drawing.Point(12, 145)
        Me.btnsiete.Name = "btnsiete"
        Me.btnsiete.Size = New System.Drawing.Size(52, 48)
        Me.btnsiete.TabIndex = 6
        Me.btnsiete.Text = "7"
        Me.btnsiete.UseVisualStyleBackColor = False
        '
        'btninversa
        '
        Me.btninversa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btninversa.Location = New System.Drawing.Point(244, 199)
        Me.btninversa.Name = "btninversa"
        Me.btninversa.Size = New System.Drawing.Size(52, 48)
        Me.btninversa.TabIndex = 15
        Me.btninversa.Text = "1/x"
        Me.btninversa.UseVisualStyleBackColor = False
        '
        'btnmultiplicacion
        '
        Me.btnmultiplicacion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnmultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmultiplicacion.Location = New System.Drawing.Point(186, 199)
        Me.btnmultiplicacion.Name = "btnmultiplicacion"
        Me.btnmultiplicacion.Size = New System.Drawing.Size(52, 48)
        Me.btnmultiplicacion.TabIndex = 14
        Me.btnmultiplicacion.Text = "*"
        Me.btnmultiplicacion.UseVisualStyleBackColor = False
        '
        'btnseis
        '
        Me.btnseis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnseis.Location = New System.Drawing.Point(128, 199)
        Me.btnseis.Name = "btnseis"
        Me.btnseis.Size = New System.Drawing.Size(52, 48)
        Me.btnseis.TabIndex = 13
        Me.btnseis.Text = "6"
        Me.btnseis.UseVisualStyleBackColor = False
        '
        'btncinco
        '
        Me.btncinco.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btncinco.Location = New System.Drawing.Point(70, 199)
        Me.btncinco.Name = "btncinco"
        Me.btncinco.Size = New System.Drawing.Size(52, 48)
        Me.btncinco.TabIndex = 12
        Me.btncinco.Text = "5"
        Me.btncinco.UseVisualStyleBackColor = False
        '
        'btncuatro
        '
        Me.btncuatro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btncuatro.Location = New System.Drawing.Point(12, 199)
        Me.btncuatro.Name = "btncuatro"
        Me.btncuatro.Size = New System.Drawing.Size(52, 48)
        Me.btncuatro.TabIndex = 11
        Me.btncuatro.Text = "4"
        Me.btncuatro.UseVisualStyleBackColor = False
        '
        'btnigual
        '
        Me.btnigual.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnigual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnigual.Location = New System.Drawing.Point(244, 253)
        Me.btnigual.Name = "btnigual"
        Me.btnigual.Size = New System.Drawing.Size(52, 102)
        Me.btnigual.TabIndex = 20
        Me.btnigual.Text = "="
        Me.btnigual.UseVisualStyleBackColor = False
        '
        'btnresta
        '
        Me.btnresta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnresta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresta.Location = New System.Drawing.Point(186, 253)
        Me.btnresta.Name = "btnresta"
        Me.btnresta.Size = New System.Drawing.Size(52, 48)
        Me.btnresta.TabIndex = 19
        Me.btnresta.Text = "-"
        Me.btnresta.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn3.Location = New System.Drawing.Point(128, 253)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(52, 48)
        Me.btn3.TabIndex = 18
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn2.Location = New System.Drawing.Point(70, 253)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(52, 48)
        Me.btn2.TabIndex = 17
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btnuno
        '
        Me.btnuno.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnuno.Location = New System.Drawing.Point(12, 253)
        Me.btnuno.Name = "btnuno"
        Me.btnuno.Size = New System.Drawing.Size(52, 48)
        Me.btnuno.TabIndex = 16
        Me.btnuno.Text = "1"
        Me.btnuno.UseVisualStyleBackColor = False
        '
        'btnsuma
        '
        Me.btnsuma.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnsuma.Location = New System.Drawing.Point(186, 307)
        Me.btnsuma.Name = "btnsuma"
        Me.btnsuma.Size = New System.Drawing.Size(52, 48)
        Me.btnsuma.TabIndex = 24
        Me.btnsuma.Text = "+"
        Me.btnsuma.UseVisualStyleBackColor = False
        '
        'btnpunto
        '
        Me.btnpunto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnpunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpunto.Location = New System.Drawing.Point(128, 307)
        Me.btnpunto.Name = "btnpunto"
        Me.btnpunto.Size = New System.Drawing.Size(52, 48)
        Me.btnpunto.TabIndex = 23
        Me.btnpunto.Text = "."
        Me.btnpunto.UseVisualStyleBackColor = False
        '
        'btncero
        '
        Me.btncero.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btncero.Location = New System.Drawing.Point(12, 307)
        Me.btncero.Name = "btncero"
        Me.btncero.Size = New System.Drawing.Size(110, 48)
        Me.btncero.TabIndex = 21
        Me.btncero.Text = "0"
        Me.btncero.UseVisualStyleBackColor = False
        '
        'Calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 388)
        Me.Controls.Add(Me.btnsuma)
        Me.Controls.Add(Me.btnpunto)
        Me.Controls.Add(Me.btncero)
        Me.Controls.Add(Me.btnigual)
        Me.Controls.Add(Me.btnresta)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btnuno)
        Me.Controls.Add(Me.btninversa)
        Me.Controls.Add(Me.btnmultiplicacion)
        Me.Controls.Add(Me.btnseis)
        Me.Controls.Add(Me.btncinco)
        Me.Controls.Add(Me.btncuatro)
        Me.Controls.Add(Me.btnpotencia)
        Me.Controls.Add(Me.btndivicion)
        Me.Controls.Add(Me.btnnueve)
        Me.Controls.Add(Me.btnocho)
        Me.Controls.Add(Me.btnsiete)
        Me.Controls.Add(Me.btnraiz)
        Me.Controls.Add(Me.btnmasmenos)
        Me.Controls.Add(Me.btnporcentaje)
        Me.Controls.Add(Me.btnborrarderecha)
        Me.Controls.Add(Me.btnborrartodo)
        Me.Controls.Add(Me.txtpantalla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calc"
        Me.Text = "Calc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpantalla As TextBox
    Friend WithEvents btnborrartodo As Button
    Friend WithEvents btnborrarderecha As Button
    Friend WithEvents btnporcentaje As Button
    Friend WithEvents btnmasmenos As Button
    Friend WithEvents btnraiz As Button
    Friend WithEvents btnpotencia As Button
    Friend WithEvents btndivicion As Button
    Friend WithEvents btnnueve As Button
    Friend WithEvents btnocho As Button
    Friend WithEvents btnsiete As Button
    Friend WithEvents btninversa As Button
    Friend WithEvents btnmultiplicacion As Button
    Friend WithEvents btnseis As Button
    Friend WithEvents btncinco As Button
    Friend WithEvents btncuatro As Button
    Friend WithEvents btnigual As Button
    Friend WithEvents btnresta As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btnuno As Button
    Friend WithEvents btnsuma As Button
    Friend WithEvents btnpunto As Button
    Friend WithEvents btncero As Button
End Class
