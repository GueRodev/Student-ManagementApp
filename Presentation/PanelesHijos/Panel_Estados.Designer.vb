<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel_Estados
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Estados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlEstadoEstudiantes = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dgv_Estudiantes_Estados = New System.Windows.Forms.DataGridView()
        Me.btnBuscarIdentificacion = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_Buscar_Identificacion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgv_EstudiantesMaterias = New System.Windows.Forms.DataGridView()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_Porcentaje_Aprobado = New System.Windows.Forms.Label()
        Me.pnlEstadoEstudiantes.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Estudiantes_Estados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_EstudiantesMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlEstadoEstudiantes
        '
        Me.pnlEstadoEstudiantes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlEstadoEstudiantes.Controls.Add(Me.lbl_Porcentaje_Aprobado)
        Me.pnlEstadoEstudiantes.Controls.Add(Me.Label3)
        Me.pnlEstadoEstudiantes.Controls.Add(Me.Guna2PictureBox2)
        Me.pnlEstadoEstudiantes.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.pnlEstadoEstudiantes.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.pnlEstadoEstudiantes.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlEstadoEstudiantes.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlEstadoEstudiantes.Location = New System.Drawing.Point(198, 142)
        Me.pnlEstadoEstudiantes.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlEstadoEstudiantes.Name = "pnlEstadoEstudiantes"
        Me.pnlEstadoEstudiantes.Size = New System.Drawing.Size(903, 64)
        Me.pnlEstadoEstudiantes.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(65, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 38)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "ESTADOS ESTUDIANTES"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(3, 1)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(69, 49)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 6
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'dgv_Estudiantes_Estados
        '
        Me.dgv_Estudiantes_Estados.AllowUserToOrderColumns = True
        Me.dgv_Estudiantes_Estados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_Estudiantes_Estados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Estudiantes_Estados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_Estudiantes_Estados.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Estudiantes_Estados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Estudiantes_Estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Estudiantes_Estados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Estudiantes_Estados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Estudiantes_Estados.EnableHeadersVisualStyles = False
        Me.dgv_Estudiantes_Estados.GridColor = System.Drawing.Color.White
        Me.dgv_Estudiantes_Estados.Location = New System.Drawing.Point(192, 379)
        Me.dgv_Estudiantes_Estados.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv_Estudiantes_Estados.Name = "dgv_Estudiantes_Estados"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Estudiantes_Estados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Estudiantes_Estados.RowHeadersVisible = False
        Me.dgv_Estudiantes_Estados.RowHeadersWidth = 82
        Me.dgv_Estudiantes_Estados.Size = New System.Drawing.Size(909, 161)
        Me.dgv_Estudiantes_Estados.TabIndex = 41
        '
        'btnBuscarIdentificacion
        '
        Me.btnBuscarIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBuscarIdentificacion.AutoRoundedCorners = True
        Me.btnBuscarIdentificacion.BorderRadius = 11
        Me.btnBuscarIdentificacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarIdentificacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBuscarIdentificacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBuscarIdentificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBuscarIdentificacion.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBuscarIdentificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBuscarIdentificacion.FillColor = System.Drawing.Color.Aqua
        Me.btnBuscarIdentificacion.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.btnBuscarIdentificacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscarIdentificacion.ForeColor = System.Drawing.Color.White
        Me.btnBuscarIdentificacion.Image = CType(resources.GetObject("btnBuscarIdentificacion.Image"), System.Drawing.Image)
        Me.btnBuscarIdentificacion.Location = New System.Drawing.Point(1025, 338)
        Me.btnBuscarIdentificacion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarIdentificacion.Name = "btnBuscarIdentificacion"
        Me.btnBuscarIdentificacion.Size = New System.Drawing.Size(72, 25)
        Me.btnBuscarIdentificacion.TabIndex = 42
        '
        'txt_Buscar_Identificacion
        '
        Me.txt_Buscar_Identificacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Buscar_Identificacion.AutoRoundedCorners = True
        Me.txt_Buscar_Identificacion.BorderRadius = 15
        Me.txt_Buscar_Identificacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Buscar_Identificacion.DefaultText = ""
        Me.txt_Buscar_Identificacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Buscar_Identificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Buscar_Identificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Buscar_Identificacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Buscar_Identificacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Buscar_Identificacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Buscar_Identificacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Buscar_Identificacion.IconLeft = CType(resources.GetObject("txt_Buscar_Identificacion.IconLeft"), System.Drawing.Image)
        Me.txt_Buscar_Identificacion.Location = New System.Drawing.Point(199, 335)
        Me.txt_Buscar_Identificacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Buscar_Identificacion.Name = "txt_Buscar_Identificacion"
        Me.txt_Buscar_Identificacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Buscar_Identificacion.PlaceholderText = "Buscar"
        Me.txt_Buscar_Identificacion.SelectedText = ""
        Me.txt_Buscar_Identificacion.Size = New System.Drawing.Size(817, 32)
        Me.txt_Buscar_Identificacion.TabIndex = 44
        '
        'dgv_EstudiantesMaterias
        '
        Me.dgv_EstudiantesMaterias.AllowUserToOrderColumns = True
        Me.dgv_EstudiantesMaterias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_EstudiantesMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_EstudiantesMaterias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_EstudiantesMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_EstudiantesMaterias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_EstudiantesMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_EstudiantesMaterias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificacion, Me.Nombre, Me.Apellidos, Me.Carrera})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_EstudiantesMaterias.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_EstudiantesMaterias.EnableHeadersVisualStyles = False
        Me.dgv_EstudiantesMaterias.GridColor = System.Drawing.Color.White
        Me.dgv_EstudiantesMaterias.Location = New System.Drawing.Point(198, 208)
        Me.dgv_EstudiantesMaterias.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv_EstudiantesMaterias.Name = "dgv_EstudiantesMaterias"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_EstudiantesMaterias.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_EstudiantesMaterias.RowHeadersVisible = False
        Me.dgv_EstudiantesMaterias.RowHeadersWidth = 82
        Me.dgv_EstudiantesMaterias.Size = New System.Drawing.Size(903, 105)
        Me.dgv_EstudiantesMaterias.TabIndex = 53
        '
        'Identificacion
        '
        Me.Identificacion.DataPropertyName = "Identificacion"
        Me.Identificacion.HeaderText = "Identificación"
        Me.Identificacion.MinimumWidth = 6
        Me.Identificacion.Name = "Identificacion"
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        '
        'Apellidos
        '
        Me.Apellidos.DataPropertyName = "Apellidos"
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.MinimumWidth = 6
        Me.Apellidos.Name = "Apellidos"
        '
        'Carrera
        '
        Me.Carrera.DataPropertyName = "Carrera"
        Me.Carrera.HeaderText = "Carrera"
        Me.Carrera.MinimumWidth = 6
        Me.Carrera.Name = "Carrera"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Aprobadas"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Pendientes"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Matriculadas"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'lbl_Porcentaje_Aprobado
        '
        Me.lbl_Porcentaje_Aprobado.AutoSize = True
        Me.lbl_Porcentaje_Aprobado.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Porcentaje_Aprobado.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Porcentaje_Aprobado.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_Porcentaje_Aprobado.Location = New System.Drawing.Point(502, 22)
        Me.lbl_Porcentaje_Aprobado.Name = "lbl_Porcentaje_Aprobado"
        Me.lbl_Porcentaje_Aprobado.Size = New System.Drawing.Size(63, 23)
        Me.lbl_Porcentaje_Aprobado.TabIndex = 54
        Me.lbl_Porcentaje_Aprobado.Text = "Label1"
        '
        'Panel_Estados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.dgv_EstudiantesMaterias)
        Me.Controls.Add(Me.txt_Buscar_Identificacion)
        Me.Controls.Add(Me.btnBuscarIdentificacion)
        Me.Controls.Add(Me.dgv_Estudiantes_Estados)
        Me.Controls.Add(Me.pnlEstadoEstudiantes)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Panel_Estados"
        Me.Size = New System.Drawing.Size(1113, 565)
        Me.pnlEstadoEstudiantes.ResumeLayout(False)
        Me.pnlEstadoEstudiantes.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Estudiantes_Estados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_EstudiantesMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlEstadoEstudiantes As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents dgv_Estudiantes_Estados As DataGridView
    Friend WithEvents btnBuscarIdentificacion As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txt_Buscar_Identificacion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgv_EstudiantesMaterias As DataGridView
    Friend WithEvents Identificacion As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Carrera As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_Porcentaje_Aprobado As Label
End Class
