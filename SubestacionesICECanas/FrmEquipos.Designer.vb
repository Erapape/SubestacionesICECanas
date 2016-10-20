<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEquipos
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkSCADA = New System.Windows.Forms.CheckBox()
        Me.TxtRemota = New System.Windows.Forms.TextBox()
        Me.TxtICERemota = New System.Windows.Forms.TextBox()
        Me.TxtLocalizacion = New System.Windows.Forms.TextBox()
        Me.TxtUbicacion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtICEControl = New System.Windows.Forms.TextBox()
        Me.TxtControl = New System.Windows.Forms.TextBox()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.TxtICEMarca = New System.Windows.Forms.TextBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(443, 366)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 34)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(334, 366)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 34)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(225, 366)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(116, 366)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(103, 34)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 182)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(621, 152)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSCADA)
        Me.GroupBox1.Controls.Add(Me.TxtRemota)
        Me.GroupBox1.Controls.Add(Me.TxtICERemota)
        Me.GroupBox1.Controls.Add(Me.TxtLocalizacion)
        Me.GroupBox1.Controls.Add(Me.TxtUbicacion)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtICEControl)
        Me.GroupBox1.Controls.Add(Me.TxtControl)
        Me.GroupBox1.Controls.Add(Me.TxtModelo)
        Me.GroupBox1.Controls.Add(Me.TxtICEMarca)
        Me.GroupBox1.Controls.Add(Me.TxtTipo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtMarca)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 135)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'chkSCADA
        '
        Me.chkSCADA.AutoSize = True
        Me.chkSCADA.Location = New System.Drawing.Point(508, 72)
        Me.chkSCADA.Name = "chkSCADA"
        Me.chkSCADA.Size = New System.Drawing.Size(62, 17)
        Me.chkSCADA.TabIndex = 49
        Me.chkSCADA.Text = "SCADA"
        Me.chkSCADA.UseVisualStyleBackColor = True
        '
        'TxtRemota
        '
        Me.TxtRemota.Location = New System.Drawing.Point(57, 69)
        Me.TxtRemota.Name = "TxtRemota"
        Me.TxtRemota.Size = New System.Drawing.Size(146, 20)
        Me.TxtRemota.TabIndex = 48
        '
        'TxtICERemota
        '
        Me.TxtICERemota.Location = New System.Drawing.Point(295, 69)
        Me.TxtICERemota.Name = "TxtICERemota"
        Me.TxtICERemota.Size = New System.Drawing.Size(185, 20)
        Me.TxtICERemota.TabIndex = 47
        '
        'TxtLocalizacion
        '
        Me.TxtLocalizacion.Location = New System.Drawing.Point(81, 95)
        Me.TxtLocalizacion.Name = "TxtLocalizacion"
        Me.TxtLocalizacion.Size = New System.Drawing.Size(360, 20)
        Me.TxtLocalizacion.TabIndex = 46
        '
        'TxtUbicacion
        '
        Me.TxtUbicacion.Location = New System.Drawing.Point(508, 95)
        Me.TxtUbicacion.Name = "TxtUbicacion"
        Me.TxtUbicacion.Size = New System.Drawing.Size(124, 20)
        Me.TxtUbicacion.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(447, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Ubicación"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Localización"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(210, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "N° ICE Remota"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Remota"
        '
        'TxtICEControl
        '
        Me.TxtICEControl.Location = New System.Drawing.Point(488, 43)
        Me.TxtICEControl.Name = "TxtICEControl"
        Me.TxtICEControl.Size = New System.Drawing.Size(144, 20)
        Me.TxtICEControl.TabIndex = 39
        '
        'TxtControl
        '
        Me.TxtControl.Location = New System.Drawing.Point(256, 43)
        Me.TxtControl.Name = "TxtControl"
        Me.TxtControl.Size = New System.Drawing.Size(146, 20)
        Me.TxtControl.TabIndex = 38
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(57, 43)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(146, 20)
        Me.TxtModelo.TabIndex = 37
        '
        'TxtICEMarca
        '
        Me.TxtICEMarca.Location = New System.Drawing.Point(486, 16)
        Me.TxtICEMarca.Name = "TxtICEMarca"
        Me.TxtICEMarca.Size = New System.Drawing.Size(146, 20)
        Me.TxtICEMarca.TabIndex = 36
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(256, 17)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(146, 20)
        Me.TxtTipo.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(408, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "N° ICE Control"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Control"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(408, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "N° ICE Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Tipo"
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(57, 16)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(146, 20)
        Me.TxtMarca.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Marca"
        '
        'FrmEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 410)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmEquipos"
        Me.Text = "FrmEquipos"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSCADA As System.Windows.Forms.CheckBox
    Friend WithEvents TxtRemota As System.Windows.Forms.TextBox
    Friend WithEvents TxtICERemota As System.Windows.Forms.TextBox
    Friend WithEvents TxtLocalizacion As System.Windows.Forms.TextBox
    Friend WithEvents TxtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtICEControl As System.Windows.Forms.TextBox
    Friend WithEvents TxtControl As System.Windows.Forms.TextBox
    Friend WithEvents TxtModelo As System.Windows.Forms.TextBox
    Friend WithEvents TxtICEMarca As System.Windows.Forms.TextBox
    Friend WithEvents TxtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
