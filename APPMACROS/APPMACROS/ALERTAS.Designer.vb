<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALERTAS
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
        Me.bg = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.CheckedListBox()
        Me.aHojas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.atextofil = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.alGrupo = New System.Windows.Forms.ComboBox()
        Me.aClasificacion = New System.Windows.Forms.ComboBox()
        Me.aCliente = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bg
        '
        Me.bg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bg.Location = New System.Drawing.Point(947, 248)
        Me.bg.Name = "bg"
        Me.bg.Size = New System.Drawing.Size(221, 26)
        Me.bg.TabIndex = 79
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DeepPink
        Me.Label8.Location = New System.Drawing.Point(1022, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 32)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "BG'S"
        '
        'lb1
        '
        Me.lb1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lb1.FormattingEnabled = True
        Me.lb1.Location = New System.Drawing.Point(704, 213)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(164, 119)
        Me.lb1.TabIndex = 77
        '
        'aHojas
        '
        Me.aHojas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.aHojas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.aHojas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.aHojas.FormattingEnabled = True
        Me.aHojas.Location = New System.Drawing.Point(22, 213)
        Me.aHojas.Name = "aHojas"
        Me.aHojas.Size = New System.Drawing.Size(322, 28)
        Me.aHojas.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepPink
        Me.Label7.Location = New System.Drawing.Point(144, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 32)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "ALERTA"
        '
        'ListBox4
        '
        Me.ListBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox4.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.HorizontalExtent = 7000
        Me.ListBox4.HorizontalScrollbar = True
        Me.ListBox4.ItemHeight = 23
        Me.ListBox4.Location = New System.Drawing.Point(22, 400)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.ScrollAlwaysVisible = True
        Me.ListBox4.Size = New System.Drawing.Size(1173, 257)
        Me.ListBox4.TabIndex = 74
        '
        'btnRegresar
        '
        Me.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRegresar.AutoSize = True
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(724, 343)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(117, 38)
        Me.btnRegresar.TabIndex = 73
        Me.btnRegresar.Text = "REGRESAR"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnAplicar
        '
        Me.btnAplicar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAplicar.AutoSize = True
        Me.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAplicar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicar.Location = New System.Drawing.Point(337, 343)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(97, 38)
        Me.btnAplicar.TabIndex = 72
        Me.btnAplicar.Text = "APLICAR"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'atextofil
        '
        Me.atextofil.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.atextofil.Location = New System.Drawing.Point(946, 178)
        Me.atextofil.Name = "atextofil"
        Me.atextofil.Size = New System.Drawing.Size(221, 26)
        Me.atextofil.TabIndex = 71
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepPink
        Me.Label6.Location = New System.Drawing.Point(940, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 32)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "PALABRAS CLAVE"
        '
        'alGrupo
        '
        Me.alGrupo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.alGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.alGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.alGrupo.FormattingEnabled = True
        Me.alGrupo.Location = New System.Drawing.Point(642, 135)
        Me.alGrupo.Name = "alGrupo"
        Me.alGrupo.Size = New System.Drawing.Size(289, 28)
        Me.alGrupo.TabIndex = 69
        '
        'aClasificacion
        '
        Me.aClasificacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.aClasificacion.FormattingEnabled = True
        Me.aClasificacion.Location = New System.Drawing.Point(405, 258)
        Me.aClasificacion.Name = "aClasificacion"
        Me.aClasificacion.Size = New System.Drawing.Size(186, 28)
        Me.aClasificacion.TabIndex = 68
        '
        'aCliente
        '
        Me.aCliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.aCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.aCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.aCliente.Location = New System.Drawing.Point(405, 135)
        Me.aCliente.Name = "aCliente"
        Me.aCliente.Size = New System.Drawing.Size(186, 28)
        Me.aCliente.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepPink
        Me.Label5.Location = New System.Drawing.Point(718, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 32)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "PRIORIDAD"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepPink
        Me.Label4.Location = New System.Drawing.Point(648, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 32)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "ASSIGNMENT GROUP"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepPink
        Me.Label3.Location = New System.Drawing.Point(399, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 32)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "CLASIFICACIÓN"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepPink
        Me.Label2.Location = New System.Drawing.Point(422, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 32)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "CUSTOMER"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepPink
        Me.Label1.Location = New System.Drawing.Point(296, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(635, 62)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "ALERTAS DE MONITOREO"
        '
        'ALERTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 686)
        Me.Controls.Add(Me.bg)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.aHojas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.atextofil)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.alGrupo)
        Me.Controls.Add(Me.aClasificacion)
        Me.Controls.Add(Me.aCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ALERTAS"
        Me.Text = "ALERTAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lb1 As CheckedListBox
    Friend WithEvents aHojas As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnAplicar As Button
    Friend WithEvents atextofil As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents alGrupo As ComboBox
    Friend WithEvents aClasificacion As ComboBox
    Friend WithEvents aCliente As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
