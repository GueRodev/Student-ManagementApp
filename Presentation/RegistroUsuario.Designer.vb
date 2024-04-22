<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroUsuario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroUsuario))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrarRegistroUsuario = New System.Windows.Forms.Button()
        Me.btnMinimizarRegistroUsuario = New System.Windows.Forms.Button()
        Me.btnRegresarLogin = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorRegistro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_RegistroUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_RegistroContrasena = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_RegistroEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_Registrar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.btnRegresarLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.btnCerrarRegistroUsuario)
        Me.PanelTitulo.Controls.Add(Me.btnMinimizarRegistroUsuario)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(506, 23)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnCerrarRegistroUsuario
        '
        Me.btnCerrarRegistroUsuario.FlatAppearance.BorderSize = 0
        Me.btnCerrarRegistroUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrarRegistroUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrarRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarRegistroUsuario.Image = CType(resources.GetObject("btnCerrarRegistroUsuario.Image"), System.Drawing.Image)
        Me.btnCerrarRegistroUsuario.Location = New System.Drawing.Point(468, -1)
        Me.btnCerrarRegistroUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrarRegistroUsuario.Name = "btnCerrarRegistroUsuario"
        Me.btnCerrarRegistroUsuario.Size = New System.Drawing.Size(38, 27)
        Me.btnCerrarRegistroUsuario.TabIndex = 4
        Me.btnCerrarRegistroUsuario.UseVisualStyleBackColor = True
        '
        'btnMinimizarRegistroUsuario
        '
        Me.btnMinimizarRegistroUsuario.FlatAppearance.BorderSize = 0
        Me.btnMinimizarRegistroUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMinimizarRegistroUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMinimizarRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizarRegistroUsuario.Image = CType(resources.GetObject("btnMinimizarRegistroUsuario.Image"), System.Drawing.Image)
        Me.btnMinimizarRegistroUsuario.Location = New System.Drawing.Point(430, -1)
        Me.btnMinimizarRegistroUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizarRegistroUsuario.Name = "btnMinimizarRegistroUsuario"
        Me.btnMinimizarRegistroUsuario.Size = New System.Drawing.Size(38, 27)
        Me.btnMinimizarRegistroUsuario.TabIndex = 5
        Me.btnMinimizarRegistroUsuario.UseVisualStyleBackColor = True
        '
        'btnRegresarLogin
        '
        Me.btnRegresarLogin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRegresarLogin.Image = CType(resources.GetObject("btnRegresarLogin.Image"), System.Drawing.Image)
        Me.btnRegresarLogin.Location = New System.Drawing.Point(277, 23)
        Me.btnRegresarLogin.Name = "btnRegresarLogin"
        Me.btnRegresarLogin.Size = New System.Drawing.Size(229, 313)
        Me.btnRegresarLogin.TabIndex = 1
        Me.btnRegresarLogin.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(57, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(171, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(9, 313)
        Me.Panel1.TabIndex = 39
        '
        'ErrorRegistro
        '
        Me.ErrorRegistro.ContainerControl = Me
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(82, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Crear Cuenta"
        '
        'txt_RegistroUsuario
        '
        Me.txt_RegistroUsuario.AutoRoundedCorners = True
        Me.txt_RegistroUsuario.BorderRadius = 10
        Me.txt_RegistroUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_RegistroUsuario.DefaultText = ""
        Me.txt_RegistroUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_RegistroUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_RegistroUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_RegistroUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_RegistroUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_RegistroUsuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_RegistroUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_RegistroUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_RegistroUsuario.IconLeft = CType(resources.GetObject("txt_RegistroUsuario.IconLeft"), System.Drawing.Image)
        Me.txt_RegistroUsuario.Location = New System.Drawing.Point(15, 139)
        Me.txt_RegistroUsuario.Name = "txt_RegistroUsuario"
        Me.txt_RegistroUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_RegistroUsuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_RegistroUsuario.PlaceholderText = "Usuario"
        Me.txt_RegistroUsuario.SelectedText = ""
        Me.txt_RegistroUsuario.Size = New System.Drawing.Size(257, 23)
        Me.txt_RegistroUsuario.TabIndex = 42
        '
        'txt_RegistroContrasena
        '
        Me.txt_RegistroContrasena.AutoRoundedCorners = True
        Me.txt_RegistroContrasena.BorderRadius = 10
        Me.txt_RegistroContrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_RegistroContrasena.DefaultText = ""
        Me.txt_RegistroContrasena.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_RegistroContrasena.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_RegistroContrasena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_RegistroContrasena.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_RegistroContrasena.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_RegistroContrasena.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_RegistroContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_RegistroContrasena.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_RegistroContrasena.IconLeft = CType(resources.GetObject("txt_RegistroContrasena.IconLeft"), System.Drawing.Image)
        Me.txt_RegistroContrasena.Location = New System.Drawing.Point(15, 180)
        Me.txt_RegistroContrasena.Name = "txt_RegistroContrasena"
        Me.txt_RegistroContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_RegistroContrasena.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_RegistroContrasena.PlaceholderText = "Contraseña"
        Me.txt_RegistroContrasena.SelectedText = ""
        Me.txt_RegistroContrasena.Size = New System.Drawing.Size(257, 23)
        Me.txt_RegistroContrasena.TabIndex = 43
        '
        'txt_RegistroEmail
        '
        Me.txt_RegistroEmail.AutoRoundedCorners = True
        Me.txt_RegistroEmail.BorderRadius = 10
        Me.txt_RegistroEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_RegistroEmail.DefaultText = ""
        Me.txt_RegistroEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_RegistroEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_RegistroEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_RegistroEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_RegistroEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_RegistroEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_RegistroEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_RegistroEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_RegistroEmail.IconLeft = CType(resources.GetObject("txt_RegistroEmail.IconLeft"), System.Drawing.Image)
        Me.txt_RegistroEmail.Location = New System.Drawing.Point(15, 222)
        Me.txt_RegistroEmail.Name = "txt_RegistroEmail"
        Me.txt_RegistroEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_RegistroEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txt_RegistroEmail.PlaceholderText = "Email"
        Me.txt_RegistroEmail.SelectedText = ""
        Me.txt_RegistroEmail.Size = New System.Drawing.Size(257, 23)
        Me.txt_RegistroEmail.TabIndex = 44
        '
        'btn_Registrar
        '
        Me.btn_Registrar.AutoRoundedCorners = True
        Me.btn_Registrar.BorderRadius = 14
        Me.btn_Registrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Registrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Registrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Registrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Registrar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Registrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Registrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Registrar.FillColor2 = System.Drawing.Color.DarkSeaGreen
        Me.btn_Registrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Registrar.ForeColor = System.Drawing.Color.White
        Me.btn_Registrar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Registrar.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Registrar.Location = New System.Drawing.Point(81, 264)
        Me.btn_Registrar.Name = "btn_Registrar"
        Me.btn_Registrar.Size = New System.Drawing.Size(116, 30)
        Me.btn_Registrar.TabIndex = 45
        Me.btn_Registrar.Text = "Crear"
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(346, 159)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(107, 34)
        Me.btnVolver.TabIndex = 46
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'RegistroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(506, 336)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btn_Registrar)
        Me.Controls.Add(Me.txt_RegistroEmail)
        Me.Controls.Add(Me.txt_RegistroContrasena)
        Me.Controls.Add(Me.txt_RegistroUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnRegresarLogin)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistroUsuario"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistroUsuario"
        Me.PanelTitulo.ResumeLayout(False)
        CType(Me.btnRegresarLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents btnMinimizarRegistroUsuario As Button
    Friend WithEvents btnCerrarRegistroUsuario As Button
    Friend WithEvents btnRegresarLogin As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorRegistro As ErrorProvider
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_RegistroUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_RegistroEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_RegistroContrasena As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_Registrar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnVolver As Button
End Class
