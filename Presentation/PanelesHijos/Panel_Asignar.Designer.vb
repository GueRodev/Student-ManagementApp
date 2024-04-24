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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Asignar))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_materias_Asignar = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_VistaMaterias = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lbl_Materias_Asignar = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlEstadoEstudiantes = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dgv_Estudiantes_Mostrar = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombreEstudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_Asignar_Materia = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbo_Estado = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_materias_Asignar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_VistaMaterias.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEstadoEstudiantes.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Estudiantes_Mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_materias_Asignar
        '
        Me.dgv_materias_Asignar.AllowUserToOrderColumns = True
        Me.dgv_materias_Asignar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_materias_Asignar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_materias_Asignar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_materias_Asignar.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_materias_Asignar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_materias_Asignar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_materias_Asignar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Materia})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_materias_Asignar.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_materias_Asignar.EnableHeadersVisualStyles = False
        Me.dgv_materias_Asignar.GridColor = System.Drawing.Color.White
        Me.dgv_materias_Asignar.Location = New System.Drawing.Point(365, 550)
        Me.dgv_materias_Asignar.Margin = New System.Windows.Forms.Padding(8)
        Me.dgv_materias_Asignar.Name = "dgv_materias_Asignar"
        Me.dgv_materias_Asignar.RowHeadersVisible = False
        Me.dgv_materias_Asignar.RowHeadersWidth = 82
        Me.dgv_materias_Asignar.Size = New System.Drawing.Size(1098, 146)
        Me.dgv_materias_Asignar.TabIndex = 39
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 10
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
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
        'pnl_VistaMaterias
        '
        Me.pnl_VistaMaterias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_VistaMaterias.Controls.Add(Me.lbl_Materias_Asignar)
        Me.pnl_VistaMaterias.Controls.Add(Me.Guna2PictureBox1)
        Me.pnl_VistaMaterias.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.pnl_VistaMaterias.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.pnl_VistaMaterias.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnl_VistaMaterias.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnl_VistaMaterias.Location = New System.Drawing.Point(365, 469)
        Me.pnl_VistaMaterias.Margin = New System.Windows.Forms.Padding(6)
        Me.pnl_VistaMaterias.Name = "pnl_VistaMaterias"
        Me.pnl_VistaMaterias.Size = New System.Drawing.Size(1098, 76)
        Me.pnl_VistaMaterias.TabIndex = 44
        '
        'lbl_Materias_Asignar
        '
        Me.lbl_Materias_Asignar.AutoSize = True
        Me.lbl_Materias_Asignar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Materias_Asignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Materias_Asignar.ForeColor = System.Drawing.Color.White
        Me.lbl_Materias_Asignar.Location = New System.Drawing.Point(368, 12)
        Me.lbl_Materias_Asignar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Materias_Asignar.Name = "lbl_Materias_Asignar"
        Me.lbl_Materias_Asignar.Size = New System.Drawing.Size(375, 55)
        Me.lbl_Materias_Asignar.TabIndex = 34
        Me.lbl_Materias_Asignar.Text = "Asignar Materia"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(21, 2)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(104, 77)
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
        Me.pnlEstadoEstudiantes.Location = New System.Drawing.Point(574, 233)
        Me.pnlEstadoEstudiantes.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlEstadoEstudiantes.Name = "pnlEstadoEstudiantes"
        Me.pnlEstadoEstudiantes.Size = New System.Drawing.Size(717, 75)
        Me.pnlEstadoEstudiantes.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(153, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(445, 55)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Asignar Estudiante"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(4, 2)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(104, 77)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 6
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'dgv_Estudiantes_Mostrar
        '
        Me.dgv_Estudiantes_Mostrar.AllowUserToOrderColumns = True
        Me.dgv_Estudiantes_Mostrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_Estudiantes_Mostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Estudiantes_Mostrar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_Estudiantes_Mostrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Estudiantes_Mostrar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Estudiantes_Mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Estudiantes_Mostrar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Identificacion})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Estudiantes_Mostrar.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Estudiantes_Mostrar.EnableHeadersVisualStyles = False
        Me.dgv_Estudiantes_Mostrar.GridColor = System.Drawing.Color.White
        Me.dgv_Estudiantes_Mostrar.Location = New System.Drawing.Point(574, 322)
        Me.dgv_Estudiantes_Mostrar.Margin = New System.Windows.Forms.Padding(8)
        Me.dgv_Estudiantes_Mostrar.Name = "dgv_Estudiantes_Mostrar"
        Me.dgv_Estudiantes_Mostrar.RowHeadersVisible = False
        Me.dgv_Estudiantes_Mostrar.RowHeadersWidth = 82
        Me.dgv_Estudiantes_Mostrar.Size = New System.Drawing.Size(717, 99)
        Me.dgv_Estudiantes_Mostrar.TabIndex = 45
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
        'txtNombreEstudiante
        '
        Me.txtNombreEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombreEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreEstudiante.DefaultText = ""
        Me.txtNombreEstudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombreEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombreEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreEstudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreEstudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtNombreEstudiante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtNombreEstudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreEstudiante.Location = New System.Drawing.Point(365, 780)
        Me.txtNombreEstudiante.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.txtNombreEstudiante.Name = "txtNombreEstudiante"
        Me.txtNombreEstudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreEstudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtNombreEstudiante.PlaceholderText = "Nombre"
        Me.txtNombreEstudiante.SelectedText = ""
        Me.txtNombreEstudiante.Size = New System.Drawing.Size(239, 40)
        Me.txtNombreEstudiante.TabIndex = 47
        '
        'txt_Asignar_Materia
        '
        Me.txt_Asignar_Materia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Asignar_Materia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Asignar_Materia.DefaultText = ""
        Me.txt_Asignar_Materia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Asignar_Materia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Asignar_Materia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Asignar_Materia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Asignar_Materia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Asignar_Materia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_Asignar_Materia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Asignar_Materia.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Asignar_Materia.Location = New System.Drawing.Point(623, 780)
        Me.txt_Asignar_Materia.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.txt_Asignar_Materia.Name = "txt_Asignar_Materia"
        Me.txt_Asignar_Materia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Asignar_Materia.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Asignar_Materia.PlaceholderText = "Materia"
        Me.txt_Asignar_Materia.SelectedText = ""
        Me.txt_Asignar_Materia.Size = New System.Drawing.Size(452, 40)
        Me.txt_Asignar_Materia.TabIndex = 48
        '
        'cbo_Estado
        '
        Me.cbo_Estado.BackColor = System.Drawing.Color.Transparent
        Me.cbo_Estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Estado.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_Estado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_Estado.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbo_Estado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cbo_Estado.ItemHeight = 30
        Me.cbo_Estado.Items.AddRange(New Object() {"APROBADO", "PENDIENTE", "MATRICULADO"})
        Me.cbo_Estado.Location = New System.Drawing.Point(1104, 783)
        Me.cbo_Estado.Name = "cbo_Estado"
        Me.cbo_Estado.Size = New System.Drawing.Size(355, 36)
        Me.cbo_Estado.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1227, 737)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 31)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Estado"
        '
        'Panel_Asignar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_Estado)
        Me.Controls.Add(Me.txt_Asignar_Materia)
        Me.Controls.Add(Me.txtNombreEstudiante)
        Me.Controls.Add(Me.pnlEstadoEstudiantes)
        Me.Controls.Add(Me.dgv_Estudiantes_Mostrar)
        Me.Controls.Add(Me.pnl_VistaMaterias)
        Me.Controls.Add(Me.dgv_materias_Asignar)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Panel_Asignar"
        Me.Size = New System.Drawing.Size(1670, 883)
        CType(Me.dgv_materias_Asignar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_VistaMaterias.ResumeLayout(False)
        Me.pnl_VistaMaterias.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEstadoEstudiantes.ResumeLayout(False)
        Me.pnlEstadoEstudiantes.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Estudiantes_Mostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_materias_Asignar As DataGridView
    Friend WithEvents pnl_VistaMaterias As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lbl_Materias_Asignar As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Materia As DataGridViewTextBoxColumn
    Friend WithEvents pnlEstadoEstudiantes As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents dgv_Estudiantes_Mostrar As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identificacion As DataGridViewTextBoxColumn
    Friend WithEvents txtNombreEstudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Asignar_Materia As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbo_Estado As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
End Class
