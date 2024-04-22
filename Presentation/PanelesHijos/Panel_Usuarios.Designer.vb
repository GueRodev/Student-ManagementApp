<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel_Usuarios
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Usuarios))
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardarUsuario = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEditarUsuario = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEliminarUsuario = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtGuardarUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGuardarEmailUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_ID_Usuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorIconoUsuario = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtGuardarPasswordUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIconoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AllowUserToOrderColumns = True
        Me.dgv_usuarios.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_usuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgv_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_usuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Usuario, Me.Email, Me.Rol})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_usuarios.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_usuarios.EnableHeadersVisualStyles = False
        Me.dgv_usuarios.GridColor = System.Drawing.Color.White
        Me.dgv_usuarios.Location = New System.Drawing.Point(133, 225)
        Me.dgv_usuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.RowHeadersVisible = False
        Me.dgv_usuarios.Size = New System.Drawing.Size(646, 173)
        Me.dgv_usuarios.TabIndex = 13
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ID.DataPropertyName = "ID"
        Me.ID.FillWeight = 20.0!
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Email
        '
        Me.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'Rol
        '
        Me.Rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Rol.DataPropertyName = "Rol"
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        Me.Rol.ReadOnly = True
        '
        'btnGuardarUsuario
        '
        Me.btnGuardarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGuardarUsuario.AutoRoundedCorners = True
        Me.btnGuardarUsuario.BorderRadius = 10
        Me.btnGuardarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardarUsuario.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardarUsuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuardarUsuario.FillColor2 = System.Drawing.Color.Green
        Me.btnGuardarUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnGuardarUsuario.Image = CType(resources.GetObject("btnGuardarUsuario.Image"), System.Drawing.Image)
        Me.btnGuardarUsuario.Location = New System.Drawing.Point(488, 160)
        Me.btnGuardarUsuario.Name = "btnGuardarUsuario"
        Me.btnGuardarUsuario.Size = New System.Drawing.Size(93, 23)
        Me.btnGuardarUsuario.TabIndex = 14
        Me.btnGuardarUsuario.Text = "Guardar"
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditarUsuario.AutoRoundedCorners = True
        Me.btnEditarUsuario.BorderRadius = 10
        Me.btnEditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarUsuario.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditarUsuario.FillColor = System.Drawing.Color.Aqua
        Me.btnEditarUsuario.FillColor2 = System.Drawing.Color.DodgerBlue
        Me.btnEditarUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnEditarUsuario.Image = CType(resources.GetObject("btnEditarUsuario.Image"), System.Drawing.Image)
        Me.btnEditarUsuario.Location = New System.Drawing.Point(587, 160)
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(93, 23)
        Me.btnEditarUsuario.TabIndex = 15
        Me.btnEditarUsuario.Text = "Editar"
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEliminarUsuario.AutoRoundedCorners = True
        Me.btnEliminarUsuario.BorderRadius = 10
        Me.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEliminarUsuario.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEliminarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEliminarUsuario.FillColor = System.Drawing.Color.Salmon
        Me.btnEliminarUsuario.FillColor2 = System.Drawing.Color.OrangeRed
        Me.btnEliminarUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnEliminarUsuario.Image = CType(resources.GetObject("btnEliminarUsuario.Image"), System.Drawing.Image)
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(683, 160)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(93, 23)
        Me.btnEliminarUsuario.TabIndex = 16
        Me.btnEliminarUsuario.Text = "Eliminar"
        '
        'txtGuardarUsuario
        '
        Me.txtGuardarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtGuardarUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardarUsuario.DefaultText = ""
        Me.txtGuardarUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuardarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuardarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardarUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardarUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardarUsuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtGuardarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtGuardarUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardarUsuario.IconLeft = CType(resources.GetObject("txtGuardarUsuario.IconLeft"), System.Drawing.Image)
        Me.txtGuardarUsuario.Location = New System.Drawing.Point(174, 197)
        Me.txtGuardarUsuario.Name = "txtGuardarUsuario"
        Me.txtGuardarUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardarUsuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtGuardarUsuario.PlaceholderText = "Usuario"
        Me.txtGuardarUsuario.SelectedText = ""
        Me.txtGuardarUsuario.Size = New System.Drawing.Size(195, 21)
        Me.txtGuardarUsuario.TabIndex = 17
        '
        'txtGuardarEmailUsuario
        '
        Me.txtGuardarEmailUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtGuardarEmailUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardarEmailUsuario.DefaultText = ""
        Me.txtGuardarEmailUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuardarEmailUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuardarEmailUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardarEmailUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardarEmailUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardarEmailUsuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtGuardarEmailUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtGuardarEmailUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardarEmailUsuario.IconLeft = CType(resources.GetObject("txtGuardarEmailUsuario.IconLeft"), System.Drawing.Image)
        Me.txtGuardarEmailUsuario.Location = New System.Drawing.Point(375, 197)
        Me.txtGuardarEmailUsuario.Name = "txtGuardarEmailUsuario"
        Me.txtGuardarEmailUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardarEmailUsuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtGuardarEmailUsuario.PlaceholderText = "Email"
        Me.txtGuardarEmailUsuario.SelectedText = ""
        Me.txtGuardarEmailUsuario.Size = New System.Drawing.Size(202, 21)
        Me.txtGuardarEmailUsuario.TabIndex = 19
        '
        'txt_ID_Usuario
        '
        Me.txt_ID_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_ID_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ID_Usuario.DefaultText = ""
        Me.txt_ID_Usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_ID_Usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_ID_Usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ID_Usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ID_Usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ID_Usuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID_Usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_ID_Usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ID_Usuario.Location = New System.Drawing.Point(133, 197)
        Me.txt_ID_Usuario.Name = "txt_ID_Usuario"
        Me.txt_ID_Usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ID_Usuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_ID_Usuario.PlaceholderText = "ID"
        Me.txt_ID_Usuario.SelectedText = ""
        Me.txt_ID_Usuario.Size = New System.Drawing.Size(35, 21)
        Me.txt_ID_Usuario.TabIndex = 20
        '
        'ErrorIconoUsuario
        '
        Me.ErrorIconoUsuario.ContainerControl = Me
        '
        'txtGuardarPasswordUsuario
        '
        Me.txtGuardarPasswordUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtGuardarPasswordUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardarPasswordUsuario.DefaultText = ""
        Me.txtGuardarPasswordUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuardarPasswordUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuardarPasswordUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardarPasswordUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardarPasswordUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardarPasswordUsuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtGuardarPasswordUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtGuardarPasswordUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardarPasswordUsuario.IconLeft = CType(resources.GetObject("txtGuardarPasswordUsuario.IconLeft"), System.Drawing.Image)
        Me.txtGuardarPasswordUsuario.Location = New System.Drawing.Point(583, 197)
        Me.txtGuardarPasswordUsuario.Name = "txtGuardarPasswordUsuario"
        Me.txtGuardarPasswordUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtGuardarPasswordUsuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtGuardarPasswordUsuario.PlaceholderText = "Password"
        Me.txtGuardarPasswordUsuario.SelectedText = ""
        Me.txtGuardarPasswordUsuario.Size = New System.Drawing.Size(196, 21)
        Me.txtGuardarPasswordUsuario.TabIndex = 18
        '
        'Panel_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.txt_ID_Usuario)
        Me.Controls.Add(Me.txtGuardarEmailUsuario)
        Me.Controls.Add(Me.txtGuardarPasswordUsuario)
        Me.Controls.Add(Me.txtGuardarUsuario)
        Me.Controls.Add(Me.btnEliminarUsuario)
        Me.Controls.Add(Me.btnEditarUsuario)
        Me.Controls.Add(Me.btnGuardarUsuario)
        Me.Controls.Add(Me.dgv_usuarios)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Panel_Usuarios"
        Me.Size = New System.Drawing.Size(835, 459)
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIconoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_usuarios As DataGridView
    Friend WithEvents btnGuardarUsuario As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEditarUsuario As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEliminarUsuario As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtGuardarUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGuardarEmailUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_ID_Usuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorIconoUsuario As ErrorProvider
    Friend WithEvents txtGuardarPasswordUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Rol As DataGridViewTextBoxColumn
End Class
