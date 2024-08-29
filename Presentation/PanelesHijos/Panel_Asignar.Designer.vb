<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel_Asignar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Asignar))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_VistaMaterias = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lbl_Materias_Asignar = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlEstadoEstudiantes = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txt_Materia = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_Nota = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_Asignar_Estado_Nota = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.dgv_Materias = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_EstudiantesMaterias = New System.Windows.Forms.DataGridView()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_IDEstudiante = New System.Windows.Forms.Label()
        Me.lbl_IDMateria = New System.Windows.Forms.Label()
        Me.btnDeshacer = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.cbo_Estado = New System.Windows.Forms.ComboBox()
        Me.btn_Limpiar_Estados = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnl_VistaMaterias.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEstadoEstudiantes.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Materias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_EstudiantesMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_VistaMaterias
        '
        Me.pnl_VistaMaterias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_VistaMaterias.Controls.Add(Me.lbl_Materias_Asignar)
        Me.pnl_VistaMaterias.Controls.Add(Me.Guna2PictureBox1)
        Me.pnl_VistaMaterias.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.pnl_VistaMaterias.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.pnl_VistaMaterias.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnl_VistaMaterias.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnl_VistaMaterias.Location = New System.Drawing.Point(199, 310)
        Me.pnl_VistaMaterias.Margin = New System.Windows.Forms.Padding(4)
        Me.pnl_VistaMaterias.Name = "pnl_VistaMaterias"
        Me.pnl_VistaMaterias.Size = New System.Drawing.Size(865, 49)
        Me.pnl_VistaMaterias.TabIndex = 44
        '
        'lbl_Materias_Asignar
        '
        Me.lbl_Materias_Asignar.AutoSize = True
        Me.lbl_Materias_Asignar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Materias_Asignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Materias_Asignar.ForeColor = System.Drawing.Color.White
        Me.lbl_Materias_Asignar.Location = New System.Drawing.Point(313, 10)
        Me.lbl_Materias_Asignar.Name = "lbl_Materias_Asignar"
        Me.lbl_Materias_Asignar.Size = New System.Drawing.Size(249, 36)
        Me.lbl_Materias_Asignar.TabIndex = 34
        Me.lbl_Materias_Asignar.Text = "Asignar Estados"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(13, 1)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(69, 49)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 6
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
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
        Me.pnlEstadoEstudiantes.Location = New System.Drawing.Point(199, 149)
        Me.pnlEstadoEstudiantes.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlEstadoEstudiantes.Name = "pnlEstadoEstudiantes"
        Me.pnlEstadoEstudiantes.Size = New System.Drawing.Size(865, 50)
        Me.pnlEstadoEstudiantes.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(262, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(342, 36)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Seleccionar Estudiante"
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
        'txt_Materia
        '
        Me.txt_Materia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Materia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Materia.DefaultText = ""
        Me.txt_Materia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Materia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Materia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Materia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Materia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Materia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_Materia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Materia.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Materia.Location = New System.Drawing.Point(199, 39)
        Me.txt_Materia.Margin = New System.Windows.Forms.Padding(9)
        Me.txt_Materia.Name = "txt_Materia"
        Me.txt_Materia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Materia.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Materia.PlaceholderText = "Materia"
        Me.txt_Materia.SelectedText = ""
        Me.txt_Materia.Size = New System.Drawing.Size(283, 26)
        Me.txt_Materia.TabIndex = 47
        Me.txt_Materia.Visible = False
        '
        'txt_Nota
        '
        Me.txt_Nota.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Nota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Nota.DefaultText = ""
        Me.txt_Nota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Nota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Nota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Nota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Nota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Nota.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_Nota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Nota.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Nota.Location = New System.Drawing.Point(494, 488)
        Me.txt_Nota.Margin = New System.Windows.Forms.Padding(9)
        Me.txt_Nota.Name = "txt_Nota"
        Me.txt_Nota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Nota.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Nota.PlaceholderText = "Nota"
        Me.txt_Nota.SelectedText = ""
        Me.txt_Nota.Size = New System.Drawing.Size(274, 31)
        Me.txt_Nota.TabIndex = 48
        '
        'btn_Asignar_Estado_Nota
        '
        Me.btn_Asignar_Estado_Nota.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Asignar_Estado_Nota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Asignar_Estado_Nota.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Asignar_Estado_Nota.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Asignar_Estado_Nota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Asignar_Estado_Nota.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Asignar_Estado_Nota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Asignar_Estado_Nota.FillColor = System.Drawing.Color.Aqua
        Me.btn_Asignar_Estado_Nota.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.btn_Asignar_Estado_Nota.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Asignar_Estado_Nota.ForeColor = System.Drawing.Color.White
        Me.btn_Asignar_Estado_Nota.Image = CType(resources.GetObject("btn_Asignar_Estado_Nota.Image"), System.Drawing.Image)
        Me.btn_Asignar_Estado_Nota.Location = New System.Drawing.Point(781, 488)
        Me.btn_Asignar_Estado_Nota.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Asignar_Estado_Nota.Name = "btn_Asignar_Estado_Nota"
        Me.btn_Asignar_Estado_Nota.Size = New System.Drawing.Size(136, 32)
        Me.btn_Asignar_Estado_Nota.TabIndex = 50
        Me.btn_Asignar_Estado_Nota.Text = "Asignar"
        '
        'dgv_Materias
        '
        Me.dgv_Materias.AllowUserToOrderColumns = True
        Me.dgv_Materias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_Materias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Materias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_Materias.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Materias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Materias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column5, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Materias.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_Materias.EnableHeadersVisualStyles = False
        Me.dgv_Materias.GridColor = System.Drawing.Color.White
        Me.dgv_Materias.Location = New System.Drawing.Point(199, 359)
        Me.dgv_Materias.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv_Materias.Name = "dgv_Materias"
        Me.dgv_Materias.RowHeadersVisible = False
        Me.dgv_Materias.RowHeadersWidth = 82
        Me.dgv_Materias.Size = New System.Drawing.Size(865, 112)
        Me.dgv_Materias.TabIndex = 51
        '
        'Column1
        '
        Me.Column1.HeaderText = "EstudianteId"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "MateriaId"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Materia"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Estado"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nota"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'dgv_EstudiantesMaterias
        '
        Me.dgv_EstudiantesMaterias.AllowUserToOrderColumns = True
        Me.dgv_EstudiantesMaterias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_EstudiantesMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_EstudiantesMaterias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_EstudiantesMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_EstudiantesMaterias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_EstudiantesMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_EstudiantesMaterias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificacion, Me.Nombre, Me.Apellidos, Me.Carrera})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_EstudiantesMaterias.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_EstudiantesMaterias.EnableHeadersVisualStyles = False
        Me.dgv_EstudiantesMaterias.GridColor = System.Drawing.Color.White
        Me.dgv_EstudiantesMaterias.Location = New System.Drawing.Point(199, 197)
        Me.dgv_EstudiantesMaterias.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv_EstudiantesMaterias.Name = "dgv_EstudiantesMaterias"
        Me.dgv_EstudiantesMaterias.RowHeadersVisible = False
        Me.dgv_EstudiantesMaterias.RowHeadersWidth = 82
        Me.dgv_EstudiantesMaterias.Size = New System.Drawing.Size(865, 105)
        Me.dgv_EstudiantesMaterias.TabIndex = 52
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
        'lbl_IDEstudiante
        '
        Me.lbl_IDEstudiante.AutoSize = True
        Me.lbl_IDEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IDEstudiante.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_IDEstudiante.Location = New System.Drawing.Point(23, 42)
        Me.lbl_IDEstudiante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_IDEstudiante.Name = "lbl_IDEstudiante"
        Me.lbl_IDEstudiante.Size = New System.Drawing.Size(28, 23)
        Me.lbl_IDEstudiante.TabIndex = 53
        Me.lbl_IDEstudiante.Text = "ID"
        Me.lbl_IDEstudiante.Visible = False
        '
        'lbl_IDMateria
        '
        Me.lbl_IDMateria.AutoSize = True
        Me.lbl_IDMateria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IDMateria.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_IDMateria.Location = New System.Drawing.Point(23, 247)
        Me.lbl_IDMateria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_IDMateria.Name = "lbl_IDMateria"
        Me.lbl_IDMateria.Size = New System.Drawing.Size(28, 23)
        Me.lbl_IDMateria.TabIndex = 54
        Me.lbl_IDMateria.Text = "ID"
        Me.lbl_IDMateria.Visible = False
        '
        'btnDeshacer
        '
        Me.btnDeshacer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDeshacer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeshacer.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeshacer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeshacer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeshacer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeshacer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeshacer.FillColor = System.Drawing.Color.Snow
        Me.btnDeshacer.FillColor2 = System.Drawing.Color.Red
        Me.btnDeshacer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeshacer.ForeColor = System.Drawing.Color.White
        Me.btnDeshacer.Image = CType(resources.GetObject("btnDeshacer.Image"), System.Drawing.Image)
        Me.btnDeshacer.Location = New System.Drawing.Point(527, 39)
        Me.btnDeshacer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(136, 32)
        Me.btnDeshacer.TabIndex = 55
        Me.btnDeshacer.Text = "Deshacer"
        '
        'cbo_Estado
        '
        Me.cbo_Estado.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Estado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cbo_Estado.FormattingEnabled = True
        Me.cbo_Estado.Location = New System.Drawing.Point(199, 487)
        Me.cbo_Estado.Name = "cbo_Estado"
        Me.cbo_Estado.Size = New System.Drawing.Size(283, 31)
        Me.cbo_Estado.TabIndex = 57
        '
        'btn_Limpiar_Estados
        '
        Me.btn_Limpiar_Estados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Limpiar_Estados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Limpiar_Estados.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Limpiar_Estados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Limpiar_Estados.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Limpiar_Estados.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Limpiar_Estados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Limpiar_Estados.FillColor = System.Drawing.Color.Goldenrod
        Me.btn_Limpiar_Estados.FillColor2 = System.Drawing.Color.Yellow
        Me.btn_Limpiar_Estados.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Limpiar_Estados.ForeColor = System.Drawing.Color.White
        Me.btn_Limpiar_Estados.Image = CType(resources.GetObject("btn_Limpiar_Estados.Image"), System.Drawing.Image)
        Me.btn_Limpiar_Estados.Location = New System.Drawing.Point(929, 487)
        Me.btn_Limpiar_Estados.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Limpiar_Estados.Name = "btn_Limpiar_Estados"
        Me.btn_Limpiar_Estados.Size = New System.Drawing.Size(135, 33)
        Me.btn_Limpiar_Estados.TabIndex = 58
        Me.btn_Limpiar_Estados.Text = "Limpiar"
        '
        'Panel_Asignar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.btn_Limpiar_Estados)
        Me.Controls.Add(Me.cbo_Estado)
        Me.Controls.Add(Me.btnDeshacer)
        Me.Controls.Add(Me.lbl_IDMateria)
        Me.Controls.Add(Me.lbl_IDEstudiante)
        Me.Controls.Add(Me.dgv_EstudiantesMaterias)
        Me.Controls.Add(Me.dgv_Materias)
        Me.Controls.Add(Me.btn_Asignar_Estado_Nota)
        Me.Controls.Add(Me.txt_Nota)
        Me.Controls.Add(Me.txt_Materia)
        Me.Controls.Add(Me.pnlEstadoEstudiantes)
        Me.Controls.Add(Me.pnl_VistaMaterias)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Panel_Asignar"
        Me.Size = New System.Drawing.Size(1113, 565)
        Me.pnl_VistaMaterias.ResumeLayout(False)
        Me.pnl_VistaMaterias.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEstadoEstudiantes.ResumeLayout(False)
        Me.pnlEstadoEstudiantes.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Materias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_EstudiantesMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_VistaMaterias As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lbl_Materias_Asignar As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlEstadoEstudiantes As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txt_Materia As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Nota As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_Asignar_Estado_Nota As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgv_Materias As DataGridView
    Friend WithEvents dgv_EstudiantesMaterias As DataGridView
    Friend WithEvents lbl_IDEstudiante As Label
    Friend WithEvents lbl_IDMateria As Label
    Friend WithEvents btnDeshacer As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Identificacion As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Carrera As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents cbo_Estado As ComboBox
    Friend WithEvents btn_Limpiar_Estados As Guna.UI2.WinForms.Guna2GradientButton
End Class
