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
        Me.txt_Asignar_Estudiante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_Asignar_Materia = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_AsignarEstado = New System.Windows.Forms.ComboBox()
        Me.btnAsignarMateria = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.dgv_AsignarMateria = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_AsignarEstudiante = New System.Windows.Forms.DataGridView()
        Me.EstudianteID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estudiante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_IDEstudiante = New System.Windows.Forms.Label()
        Me.lbl_IDMateria = New System.Windows.Forms.Label()
        Me.btnDeshacerUltimoRegistro = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnl_VistaMaterias.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEstadoEstudiantes.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_AsignarMateria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_AsignarEstudiante, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnl_VistaMaterias.Location = New System.Drawing.Point(182, 252)
        Me.pnl_VistaMaterias.Name = "pnl_VistaMaterias"
        Me.pnl_VistaMaterias.Size = New System.Drawing.Size(549, 40)
        Me.pnl_VistaMaterias.TabIndex = 44
        '
        'lbl_Materias_Asignar
        '
        Me.lbl_Materias_Asignar.AutoSize = True
        Me.lbl_Materias_Asignar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Materias_Asignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Materias_Asignar.ForeColor = System.Drawing.Color.White
        Me.lbl_Materias_Asignar.Location = New System.Drawing.Point(184, 8)
        Me.lbl_Materias_Asignar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Materias_Asignar.Name = "lbl_Materias_Asignar"
        Me.lbl_Materias_Asignar.Size = New System.Drawing.Size(195, 29)
        Me.lbl_Materias_Asignar.TabIndex = 34
        Me.lbl_Materias_Asignar.Text = "Asignar Materia"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(10, 1)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(52, 40)
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
        Me.pnlEstadoEstudiantes.Location = New System.Drawing.Point(182, 121)
        Me.pnlEstadoEstudiantes.Name = "pnlEstadoEstudiantes"
        Me.pnlEstadoEstudiantes.Size = New System.Drawing.Size(549, 41)
        Me.pnlEstadoEstudiantes.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(146, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 29)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Seleccionar Estudiante"
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
        'txt_Asignar_Estudiante
        '
        Me.txt_Asignar_Estudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Asignar_Estudiante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Asignar_Estudiante.DefaultText = ""
        Me.txt_Asignar_Estudiante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Asignar_Estudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Asignar_Estudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Asignar_Estudiante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Asignar_Estudiante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Asignar_Estudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_Asignar_Estudiante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Asignar_Estudiante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Asignar_Estudiante.Location = New System.Drawing.Point(182, 386)
        Me.txt_Asignar_Estudiante.Margin = New System.Windows.Forms.Padding(7)
        Me.txt_Asignar_Estudiante.Name = "txt_Asignar_Estudiante"
        Me.txt_Asignar_Estudiante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Asignar_Estudiante.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Asignar_Estudiante.PlaceholderText = "Nombre "
        Me.txt_Asignar_Estudiante.SelectedText = ""
        Me.txt_Asignar_Estudiante.Size = New System.Drawing.Size(138, 21)
        Me.txt_Asignar_Estudiante.TabIndex = 47
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
        Me.txt_Asignar_Materia.Location = New System.Drawing.Point(329, 386)
        Me.txt_Asignar_Materia.Margin = New System.Windows.Forms.Padding(7)
        Me.txt_Asignar_Materia.Name = "txt_Asignar_Materia"
        Me.txt_Asignar_Materia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Asignar_Materia.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_Asignar_Materia.PlaceholderText = "Materia"
        Me.txt_Asignar_Materia.SelectedText = ""
        Me.txt_Asignar_Materia.Size = New System.Drawing.Size(226, 21)
        Me.txt_Asignar_Materia.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(676, 387)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Estado"
        '
        'cbo_AsignarEstado
        '
        Me.cbo_AsignarEstado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_AsignarEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cbo_AsignarEstado.FormattingEnabled = True
        Me.cbo_AsignarEstado.Items.AddRange(New Object() {"APROBADO", "MATRICULADO", "PENDIENTE"})
        Me.cbo_AsignarEstado.Location = New System.Drawing.Point(565, 386)
        Me.cbo_AsignarEstado.Name = "cbo_AsignarEstado"
        Me.cbo_AsignarEstado.Size = New System.Drawing.Size(106, 21)
        Me.cbo_AsignarEstado.TabIndex = 49
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
        Me.btnAsignarMateria.Location = New System.Drawing.Point(329, 410)
        Me.btnAsignarMateria.Name = "btnAsignarMateria"
        Me.btnAsignarMateria.Size = New System.Drawing.Size(102, 26)
        Me.btnAsignarMateria.TabIndex = 50
        Me.btnAsignarMateria.Text = "Asignar"
        '
        'dgv_AsignarMateria
        '
        Me.dgv_AsignarMateria.AllowUserToOrderColumns = True
        Me.dgv_AsignarMateria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_AsignarMateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_AsignarMateria.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_AsignarMateria.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_AsignarMateria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_AsignarMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_AsignarMateria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Materia})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_AsignarMateria.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_AsignarMateria.EnableHeadersVisualStyles = False
        Me.dgv_AsignarMateria.GridColor = System.Drawing.Color.White
        Me.dgv_AsignarMateria.Location = New System.Drawing.Point(182, 292)
        Me.dgv_AsignarMateria.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_AsignarMateria.Name = "dgv_AsignarMateria"
        Me.dgv_AsignarMateria.RowHeadersVisible = False
        Me.dgv_AsignarMateria.RowHeadersWidth = 82
        Me.dgv_AsignarMateria.Size = New System.Drawing.Size(549, 91)
        Me.dgv_AsignarMateria.TabIndex = 51
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Materia
        '
        Me.Materia.DataPropertyName = "Nombre"
        Me.Materia.HeaderText = "Nombre"
        Me.Materia.Name = "Materia"
        Me.Materia.ReadOnly = True
        '
        'dgv_AsignarEstudiante
        '
        Me.dgv_AsignarEstudiante.AllowUserToOrderColumns = True
        Me.dgv_AsignarEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_AsignarEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_AsignarEstudiante.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_AsignarEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_AsignarEstudiante.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_AsignarEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_AsignarEstudiante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EstudianteID, Me.Estudiante})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_AsignarEstudiante.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_AsignarEstudiante.EnableHeadersVisualStyles = False
        Me.dgv_AsignarEstudiante.GridColor = System.Drawing.Color.White
        Me.dgv_AsignarEstudiante.Location = New System.Drawing.Point(182, 160)
        Me.dgv_AsignarEstudiante.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_AsignarEstudiante.Name = "dgv_AsignarEstudiante"
        Me.dgv_AsignarEstudiante.RowHeadersVisible = False
        Me.dgv_AsignarEstudiante.RowHeadersWidth = 82
        Me.dgv_AsignarEstudiante.Size = New System.Drawing.Size(549, 85)
        Me.dgv_AsignarEstudiante.TabIndex = 52
        '
        'EstudianteID
        '
        Me.EstudianteID.DataPropertyName = "ID"
        Me.EstudianteID.HeaderText = "ID"
        Me.EstudianteID.Name = "EstudianteID"
        Me.EstudianteID.ReadOnly = True
        '
        'Estudiante
        '
        Me.Estudiante.DataPropertyName = "Nombre"
        Me.Estudiante.HeaderText = "Nombre"
        Me.Estudiante.Name = "Estudiante"
        Me.Estudiante.ReadOnly = True
        '
        'lbl_IDEstudiante
        '
        Me.lbl_IDEstudiante.AutoSize = True
        Me.lbl_IDEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IDEstudiante.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_IDEstudiante.Location = New System.Drawing.Point(122, 197)
        Me.lbl_IDEstudiante.Name = "lbl_IDEstudiante"
        Me.lbl_IDEstudiante.Size = New System.Drawing.Size(22, 17)
        Me.lbl_IDEstudiante.TabIndex = 53
        Me.lbl_IDEstudiante.Text = "ID"
        Me.lbl_IDEstudiante.Visible = False
        '
        'lbl_IDMateria
        '
        Me.lbl_IDMateria.AutoSize = True
        Me.lbl_IDMateria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IDMateria.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_IDMateria.Location = New System.Drawing.Point(122, 308)
        Me.lbl_IDMateria.Name = "lbl_IDMateria"
        Me.lbl_IDMateria.Size = New System.Drawing.Size(22, 17)
        Me.lbl_IDMateria.TabIndex = 54
        Me.lbl_IDMateria.Text = "ID"
        Me.lbl_IDMateria.Visible = False
        '
        'btnDeshacerUltimoRegistro
        '
        Me.btnDeshacerUltimoRegistro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDeshacerUltimoRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeshacerUltimoRegistro.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeshacerUltimoRegistro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeshacerUltimoRegistro.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeshacerUltimoRegistro.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeshacerUltimoRegistro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeshacerUltimoRegistro.FillColor = System.Drawing.Color.Snow
        Me.btnDeshacerUltimoRegistro.FillColor2 = System.Drawing.Color.Red
        Me.btnDeshacerUltimoRegistro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeshacerUltimoRegistro.ForeColor = System.Drawing.Color.White
        Me.btnDeshacerUltimoRegistro.Image = CType(resources.GetObject("btnDeshacerUltimoRegistro.Image"), System.Drawing.Image)
        Me.btnDeshacerUltimoRegistro.Location = New System.Drawing.Point(453, 410)
        Me.btnDeshacerUltimoRegistro.Name = "btnDeshacerUltimoRegistro"
        Me.btnDeshacerUltimoRegistro.Size = New System.Drawing.Size(102, 26)
        Me.btnDeshacerUltimoRegistro.TabIndex = 55
        Me.btnDeshacerUltimoRegistro.Text = "Deshacer"
        '
        'Panel_Asignar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.btnDeshacerUltimoRegistro)
        Me.Controls.Add(Me.lbl_IDMateria)
        Me.Controls.Add(Me.lbl_IDEstudiante)
        Me.Controls.Add(Me.dgv_AsignarEstudiante)
        Me.Controls.Add(Me.dgv_AsignarMateria)
        Me.Controls.Add(Me.btnAsignarMateria)
        Me.Controls.Add(Me.cbo_AsignarEstado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Asignar_Materia)
        Me.Controls.Add(Me.txt_Asignar_Estudiante)
        Me.Controls.Add(Me.pnlEstadoEstudiantes)
        Me.Controls.Add(Me.pnl_VistaMaterias)
        Me.Name = "Panel_Asignar"
        Me.Size = New System.Drawing.Size(835, 459)
        Me.pnl_VistaMaterias.ResumeLayout(False)
        Me.pnl_VistaMaterias.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEstadoEstudiantes.ResumeLayout(False)
        Me.pnlEstadoEstudiantes.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_AsignarMateria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_AsignarEstudiante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_VistaMaterias As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lbl_Materias_Asignar As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlEstadoEstudiantes As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txt_Asignar_Estudiante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Asignar_Materia As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_AsignarEstado As ComboBox
    Friend WithEvents btnAsignarMateria As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgv_AsignarMateria As DataGridView
    Friend WithEvents dgv_AsignarEstudiante As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Materia As DataGridViewTextBoxColumn
    Friend WithEvents EstudianteID As DataGridViewTextBoxColumn
    Friend WithEvents Estudiante As DataGridViewTextBoxColumn
    Friend WithEvents lbl_IDEstudiante As Label
    Friend WithEvents lbl_IDMateria As Label
    Friend WithEvents btnDeshacerUltimoRegistro As Guna.UI2.WinForms.Guna2GradientButton
End Class
