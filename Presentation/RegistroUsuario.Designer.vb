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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroUsuario))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrarRegistroUsuario = New System.Windows.Forms.Button()
        Me.btnMinimizarRegistroUsuario = New System.Windows.Forms.Button()
        Me.btnRegresarLogin = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtRegistroUsuario = New System.Windows.Forms.TextBox()
        Me.txtRegistroContrasena = New System.Windows.Forms.TextBox()
        Me.txtRegistroEmail = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.btnRegresarLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 136)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 220)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Email"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(30, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(220, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrar.Location = New System.Drawing.Point(89, 281)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(107, 34)
        Me.btnRegistrar.TabIndex = 32
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtRegistroUsuario
        '
        Me.txtRegistroUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistroUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtRegistroUsuario.Location = New System.Drawing.Point(25, 156)
        Me.txtRegistroUsuario.Multiline = True
        Me.txtRegistroUsuario.Name = "txtRegistroUsuario"
        Me.txtRegistroUsuario.Size = New System.Drawing.Size(225, 20)
        Me.txtRegistroUsuario.TabIndex = 36
        '
        'txtRegistroContrasena
        '
        Me.txtRegistroContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistroContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtRegistroContrasena.Location = New System.Drawing.Point(25, 198)
        Me.txtRegistroContrasena.Multiline = True
        Me.txtRegistroContrasena.Name = "txtRegistroContrasena"
        Me.txtRegistroContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRegistroContrasena.Size = New System.Drawing.Size(225, 20)
        Me.txtRegistroContrasena.TabIndex = 37
        '
        'txtRegistroEmail
        '
        Me.txtRegistroEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistroEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtRegistroEmail.Location = New System.Drawing.Point(25, 240)
        Me.txtRegistroEmail.Multiline = True
        Me.txtRegistroEmail.Name = "txtRegistroEmail"
        Me.txtRegistroEmail.Size = New System.Drawing.Size(225, 20)
        Me.txtRegistroEmail.TabIndex = 38
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
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(336, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 38)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RegistroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(506, 336)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtRegistroEmail)
        Me.Controls.Add(Me.txtRegistroContrasena)
        Me.Controls.Add(Me.txtRegistroUsuario)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents btnMinimizarRegistroUsuario As Button
    Friend WithEvents btnCerrarRegistroUsuario As Button
    Friend WithEvents btnRegresarLogin As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtRegistroUsuario As TextBox
    Friend WithEvents txtRegistroContrasena As TextBox
    Friend WithEvents txtRegistroEmail As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
