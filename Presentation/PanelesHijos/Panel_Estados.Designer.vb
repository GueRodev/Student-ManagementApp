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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Estados))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_Estudiantes_Mostrar = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlEstadoEstudiantes = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dgv_Estudiantes_Estados = New System.Windows.Forms.DataGridView()
        Me.btnBuscarIdentificacion = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_Buscar_Identificacion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estudiante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_Estudiantes_Mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEstadoEstudiantes.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Estudiantes_Estados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Estudiantes_Mostrar
        '
        Me.dgv_Estudiantes_Mostrar.AllowUserToOrderColumns = True
        Me.dgv_Estudiantes_Mostrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_Estudiantes_Mostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Estudiantes_Mostrar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_Estudiantes_Mostrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Estudiantes_Mostrar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Estudiantes_Mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Estudiantes_Mostrar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Identificacion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Estudiantes_Mostrar.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Estudiantes_Mostrar.EnableHeadersVisualStyles = False
        Me.dgv_Estudiantes_Mostrar.GridColor = System.Drawing.Color.White
        Me.dgv_Estudiantes_Mostrar.Location = New System.Drawing.Point(210, 167)
        Me.dgv_Estudiantes_Mostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_Estudiantes_Mostrar.Name = "dgv_Estudiantes_Mostrar"
        Me.dgv_Estudiantes_Mostrar.RowHeadersVisible = False
        Me.dgv_Estudiantes_Mostrar.RowHeadersWidth = 82
        Me.dgv_Estudiantes_Mostrar.Size = New System.Drawing.Size(494, 92)
        Me.dgv_Estudiantes_Mostrar.TabIndex = 39
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 10
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Identificacion
        '
        Me.Identificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Identificacion.DataPropertyName = "Identificacion"
        Me.Identificacion.HeaderText = "Identificacion"
        Me.Identificacion.MinimumWidth = 10
        Me.Identificacion.Name = "Identificacion"
        Me.Identificacion.ReadOnly = True
        '
        'pnlEstadoEstudiantes
        '
        Me.pnlEstadoEstudiantes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlEstadoEstudiantes.Controls.Add(Me.Label3)
        Me.pnlEstadoEstudiantes.Controls.Add(Me.Guna2PictureBox2)
        Me.pnlEstadoEstudiantes.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.pnlEstadoEstudiantes.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.pnlEstadoEstudiantes.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlEstadoEstudiantes.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlEstadoEstudiantes.Location = New System.Drawing.Point(210, 115)
        Me.pnlEstadoEstudiantes.Name = "pnlEstadoEstudiantes"
        Me.pnlEstadoEstudiantes.Size = New System.Drawing.Size(494, 52)
        Me.pnlEstadoEstudiantes.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(178, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 37)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "ESTADOS"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(2, 1)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(52, 40)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Estudiantes_Estados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Estudiantes_Estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Estudiantes_Estados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Estudiante, Me.Apellidos, Me.Materia, Me.Estado})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Estudiantes_Estados.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Estudiantes_Estados.EnableHeadersVisualStyles = False
        Me.dgv_Estudiantes_Estados.GridColor = System.Drawing.Color.White
        Me.dgv_Estudiantes_Estados.Location = New System.Drawing.Point(124, 308)
        Me.dgv_Estudiantes_Estados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_Estudiantes_Estados.Name = "dgv_Estudiantes_Estados"
        Me.dgv_Estudiantes_Estados.RowHeadersVisible = False
        Me.dgv_Estudiantes_Estados.RowHeadersWidth = 82
        Me.dgv_Estudiantes_Estados.Size = New System.Drawing.Size(682, 131)
        Me.dgv_Estudiantes_Estados.TabIndex = 41
        '
        'btnBuscarIdentificacion
        '
        Me.btnBuscarIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBuscarIdentificacion.AutoRoundedCorners = True
        Me.btnBuscarIdentificacion.BorderRadius = 9
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
        Me.btnBuscarIdentificacion.Location = New System.Drawing.Point(752, 275)
        Me.btnBuscarIdentificacion.Name = "btnBuscarIdentificacion"
        Me.btnBuscarIdentificacion.Size = New System.Drawing.Size(54, 20)
        Me.btnBuscarIdentificacion.TabIndex = 42
        '
        'txt_Buscar_Identificacion
        '
        Me.txt_Buscar_Identificacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Buscar_Identificacion.AutoRoundedCorners = True
        Me.txt_Buscar_Identificacion.BorderRadius = 12
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
        Me.txt_Buscar_Identificacion.Location = New System.Drawing.Point(133, 272)
        Me.txt_Buscar_Identificacion.Name = "txt_Buscar_Identificacion"
        Me.txt_Buscar_Identificacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Buscar_Identificacion.PlaceholderText = "Buscar"
        Me.txt_Buscar_Identificacion.SelectedText = ""
        Me.txt_Buscar_Identificacion.Size = New System.Drawing.Size(613, 26)
        Me.txt_Buscar_Identificacion.TabIndex = 44
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Identificacion"
        Me.Column1.HeaderText = "Identificacion"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Estudiante
        '
        Me.Estudiante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Estudiante.DataPropertyName = "Estudiante"
        Me.Estudiante.HeaderText = "Estudiante"
        Me.Estudiante.MinimumWidth = 10
        Me.Estudiante.Name = "Estudiante"
        Me.Estudiante.ReadOnly = True
        '
        'Apellidos
        '
        Me.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Apellidos.DataPropertyName = "Apellidos"
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.MinimumWidth = 10
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.ReadOnly = True
        '
        'Materia
        '
        Me.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Materia.DataPropertyName = "Materia"
        Me.Materia.HeaderText = "Materia"
        Me.Materia.MinimumWidth = 10
        Me.Materia.Name = "Materia"
        Me.Materia.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 10
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Panel_Estados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.txt_Buscar_Identificacion)
        Me.Controls.Add(Me.btnBuscarIdentificacion)
        Me.Controls.Add(Me.dgv_Estudiantes_Estados)
        Me.Controls.Add(Me.pnlEstadoEstudiantes)
        Me.Controls.Add(Me.dgv_Estudiantes_Mostrar)
        Me.Name = "Panel_Estados"
        Me.Size = New System.Drawing.Size(835, 459)
        CType(Me.dgv_Estudiantes_Mostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEstadoEstudiantes.ResumeLayout(False)
        Me.pnlEstadoEstudiantes.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Estudiantes_Estados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_Estudiantes_Mostrar As DataGridView
    Friend WithEvents pnlEstadoEstudiantes As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents dgv_Estudiantes_Estados As DataGridView
    Friend WithEvents btnBuscarIdentificacion As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txt_Buscar_Identificacion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identificacion As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Estudiante As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Materia As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
