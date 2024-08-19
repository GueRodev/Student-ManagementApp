<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel_Asignar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Asignar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_VistaMaterias = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lbl_Materias_Asignar = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlEstadoEstudiantes = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtMateriaNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNota = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.btnAsignarMateria = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.dgv_Materias = New System.Windows.Forms.DataGridView()
        Me.dgv_EstudiantesMaterias = New System.Windows.Forms.DataGridView()
        Me.lbl_IDEstudiante = New System.Windows.Forms.Label()
        Me.lbl_IDMateria = New System.Windows.Forms.Label()
        Me.btnDeshacer = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Materia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.pnl_VistaMaterias.Location = New System.Drawing.Point(243, 310)
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
        Me.lbl_Materias_Asignar.Location = New System.Drawing.Point(327, 10)
        Me.lbl_Materias_Asignar.Name = "lbl_Materias_Asignar"
        Me.lbl_Materias_Asignar.Size = New System.Drawing.Size(239, 36)
        Me.lbl_Materias_Asignar.TabIndex = 34
        Me.lbl_Materias_Asignar.Text = "Asignar Materia"
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
        Me.pnlEstadoEstudiantes.Location = New System.Drawing.Point(243, 149)
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
        'txtMateriaNombre
        '
        Me.txtMateriaNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMateriaNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMateriaNombre.DefaultText = ""
        Me.txtMateriaNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMateriaNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMateriaNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMateriaNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMateriaNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMateriaNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtMateriaNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtMateriaNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMateriaNombre.Location = New System.Drawing.Point(243, 475)
        Me.txtMateriaNombre.Margin = New System.Windows.Forms.Padding(9)
        Me.txtMateriaNombre.Name = "txtMateriaNombre"
        Me.txtMateriaNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMateriaNombre.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtMateriaNombre.PlaceholderText = "Materia"
        Me.txtMateriaNombre.SelectedText = ""
        Me.txtMateriaNombre.Size = New System.Drawing.Size(184, 26)
        Me.txtMateriaNombre.TabIndex = 47
        '
        'txtNota
        '
        Me.txtNota.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNota.DefaultText = ""
        Me.txtNota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNota.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtNota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtNota.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNota.Location = New System.Drawing.Point(439, 475)
        Me.txtNota.Margin = New System.Windows.Forms.Padding(9)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNota.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtNota.PlaceholderText = "Nota"
        Me.txtNota.SelectedText = ""
        Me.txtNota.Size = New System.Drawing.Size(301, 26)
        Me.txtNota.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(901, 476)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"APROBADO", "MATRICULADO", "PENDIENTE"})
        Me.cboEstado.Location = New System.Drawing.Point(753, 475)
        Me.cboEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(140, 24)
        Me.cboEstado.TabIndex = 49
        '
        'btnAsignarMateria
        '
        Me.btnAsignarMateria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAsignarMateria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAsignarMateria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAsignarMateria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAsignarMateria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAsignarMateria.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAsignarMateria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAsignarMateria.FillColor = System.Drawing.Color.Aqua
        Me.btnAsignarMateria.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.btnAsignarMateria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAsignarMateria.ForeColor = System.Drawing.Color.White
        Me.btnAsignarMateria.Image = CType(resources.GetObject("btnAsignarMateria.Image"), System.Drawing.Image)
        Me.btnAsignarMateria.Location = New System.Drawing.Point(439, 505)
        Me.btnAsignarMateria.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAsignarMateria.Name = "btnAsignarMateria"
        Me.btnAsignarMateria.Size = New System.Drawing.Size(136, 32)
        Me.btnAsignarMateria.TabIndex = 50
        Me.btnAsignarMateria.Text = "Asignar"
        '
        'dgv_Materias
        '
        Me.dgv_Materias.AllowUserToOrderColumns = True
        Me.dgv_Materias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_Materias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Materias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_Materias.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Materias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Materias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Materia, Me.Estado, Me.Nota})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Materias.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Materias.EnableHeadersVisualStyles = False
        Me.dgv_Materias.GridColor = System.Drawing.Color.White
        Me.dgv_Materias.Location = New System.Drawing.Point(243, 359)
        Me.dgv_Materias.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv_Materias.Name = "dgv_Materias"
        Me.dgv_Materias.RowHeadersVisible = False
        Me.dgv_Materias.RowHeadersWidth = 82
        Me.dgv_Materias.Size = New System.Drawing.Size(865, 112)
        Me.dgv_Materias.TabIndex = 51
        '
        'dgv_EstudiantesMaterias
        '
        Me.dgv_EstudiantesMaterias.AllowUserToOrderColumns = True
        Me.dgv_EstudiantesMaterias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_EstudiantesMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_EstudiantesMaterias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_EstudiantesMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_EstudiantesMaterias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_EstudiantesMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_EstudiantesMaterias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificacion, Me.Nombre, Me.Apellidos, Me.Carrera})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_EstudiantesMaterias.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_EstudiantesMaterias.EnableHeadersVisualStyles = False
        Me.dgv_EstudiantesMaterias.GridColor = System.Drawing.Color.White
        Me.dgv_EstudiantesMaterias.Location = New System.Drawing.Point(243, 197)
        Me.dgv_EstudiantesMaterias.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv_EstudiantesMaterias.Name = "dgv_EstudiantesMaterias"
        Me.dgv_EstudiantesMaterias.RowHeadersVisible = False
        Me.dgv_EstudiantesMaterias.RowHeadersWidth = 82
        Me.dgv_EstudiantesMaterias.Size = New System.Drawing.Size(865, 105)
        Me.dgv_EstudiantesMaterias.TabIndex = 52
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
        Me.btnDeshacer.Location = New System.Drawing.Point(604, 505)
        Me.btnDeshacer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(136, 32)
        Me.btnDeshacer.TabIndex = 55
        Me.btnDeshacer.Text = "Deshacer"
        '
        'Materia
        '
        Me.Materia.HeaderText = "Materia"
        Me.Materia.MinimumWidth = 6
        Me.Materia.Name = "Materia"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        '
        'Nota
        '
        Me.Nota.HeaderText = "Nota"
        Me.Nota.MinimumWidth = 6
        Me.Nota.Name = "Nota"
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
        'Panel_Asignar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.btnDeshacer)
        Me.Controls.Add(Me.lbl_IDMateria)
        Me.Controls.Add(Me.lbl_IDEstudiante)
        Me.Controls.Add(Me.dgv_EstudiantesMaterias)
        Me.Controls.Add(Me.dgv_Materias)
        Me.Controls.Add(Me.btnAsignarMateria)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.txtMateriaNombre)
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
    Friend WithEvents txtMateriaNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNota As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents btnAsignarMateria As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgv_Materias As DataGridView
    Friend WithEvents dgv_EstudiantesMaterias As DataGridView
    Friend WithEvents lbl_IDEstudiante As Label
    Friend WithEvents lbl_IDMateria As Label
    Friend WithEvents btnDeshacer As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Materia As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Nota As DataGridViewTextBoxColumn
    Friend WithEvents Identificacion As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Carrera As DataGridViewTextBoxColumn
End Class
