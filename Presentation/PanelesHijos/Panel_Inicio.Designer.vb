<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel_Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel_Inicio))
        Me.lblCantidadUsuarios = New System.Windows.Forms.Label()
        Me.Pnl_CantidadUser = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Pnl_CantidadEstudiantes = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblCantidadEstudiantes = New System.Windows.Forms.Label()
        Me.Pnl_CantidadMaterias = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_HORA = New System.Windows.Forms.Label()
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Pnl_CantidadUser.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_CantidadEstudiantes.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_CantidadMaterias.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantidadUsuarios
        '
        Me.lblCantidadUsuarios.AutoSize = True
        Me.lblCantidadUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidadUsuarios.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCantidadUsuarios.Location = New System.Drawing.Point(123, 21)
        Me.lblCantidadUsuarios.Name = "lblCantidadUsuarios"
        Me.lblCantidadUsuarios.Size = New System.Drawing.Size(28, 32)
        Me.lblCantidadUsuarios.TabIndex = 0
        Me.lblCantidadUsuarios.Text = "#"
        '
        'Pnl_CantidadUser
        '
        Me.Pnl_CantidadUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Pnl_CantidadUser.Controls.Add(Me.Guna2PictureBox1)
        Me.Pnl_CantidadUser.Controls.Add(Me.lblCantidadUsuarios)
        Me.Pnl_CantidadUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadUser.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadUser.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Pnl_CantidadUser.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pnl_CantidadUser.Location = New System.Drawing.Point(130, 122)
        Me.Pnl_CantidadUser.Name = "Pnl_CantidadUser"
        Me.Pnl_CantidadUser.Size = New System.Drawing.Size(177, 69)
        Me.Pnl_CantidadUser.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(20, 7)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(69, 53)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 5
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Pnl_CantidadEstudiantes
        '
        Me.Pnl_CantidadEstudiantes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Pnl_CantidadEstudiantes.Controls.Add(Me.Guna2PictureBox2)
        Me.Pnl_CantidadEstudiantes.Controls.Add(Me.lblCantidadEstudiantes)
        Me.Pnl_CantidadEstudiantes.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadEstudiantes.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadEstudiantes.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Pnl_CantidadEstudiantes.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pnl_CantidadEstudiantes.Location = New System.Drawing.Point(371, 122)
        Me.Pnl_CantidadEstudiantes.Name = "Pnl_CantidadEstudiantes"
        Me.Pnl_CantidadEstudiantes.Size = New System.Drawing.Size(177, 69)
        Me.Pnl_CantidadEstudiantes.TabIndex = 2
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(15, 8)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(69, 53)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 6
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'lblCantidadEstudiantes
        '
        Me.lblCantidadEstudiantes.AutoSize = True
        Me.lblCantidadEstudiantes.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidadEstudiantes.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadEstudiantes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCantidadEstudiantes.Location = New System.Drawing.Point(134, 21)
        Me.lblCantidadEstudiantes.Name = "lblCantidadEstudiantes"
        Me.lblCantidadEstudiantes.Size = New System.Drawing.Size(28, 32)
        Me.lblCantidadEstudiantes.TabIndex = 0
        Me.lblCantidadEstudiantes.Text = "#"
        '
        'Pnl_CantidadMaterias
        '
        Me.Pnl_CantidadMaterias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Pnl_CantidadMaterias.Controls.Add(Me.Guna2PictureBox3)
        Me.Pnl_CantidadMaterias.Controls.Add(Me.Label2)
        Me.Pnl_CantidadMaterias.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadMaterias.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Pnl_CantidadMaterias.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Pnl_CantidadMaterias.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pnl_CantidadMaterias.Location = New System.Drawing.Point(604, 122)
        Me.Pnl_CantidadMaterias.Name = "Pnl_CantidadMaterias"
        Me.Pnl_CantidadMaterias.Size = New System.Drawing.Size(177, 69)
        Me.Pnl_CantidadMaterias.TabIndex = 3
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(20, 8)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(69, 53)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 7
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(139, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "#"
        '
        'lbl_HORA
        '
        Me.lbl_HORA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_HORA.AutoSize = True
        Me.lbl_HORA.BackColor = System.Drawing.Color.Transparent
        Me.lbl_HORA.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HORA.ForeColor = System.Drawing.Color.White
        Me.lbl_HORA.Location = New System.Drawing.Point(246, 319)
        Me.lbl_HORA.Name = "lbl_HORA"
        Me.lbl_HORA.Size = New System.Drawing.Size(222, 86)
        Me.lbl_HORA.TabIndex = 4
        Me.lbl_HORA.Text = "HORA"
        '
        'tmrHora
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(338, 207)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 118)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'Panel_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbl_HORA)
        Me.Controls.Add(Me.Pnl_CantidadMaterias)
        Me.Controls.Add(Me.Pnl_CantidadEstudiantes)
        Me.Controls.Add(Me.Pnl_CantidadUser)
        Me.Name = "Panel_Inicio"
        Me.Size = New System.Drawing.Size(835, 459)
        Me.Pnl_CantidadUser.ResumeLayout(False)
        Me.Pnl_CantidadUser.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_CantidadEstudiantes.ResumeLayout(False)
        Me.Pnl_CantidadEstudiantes.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_CantidadMaterias.ResumeLayout(False)
        Me.Pnl_CantidadMaterias.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCantidadUsuarios As Label
    Friend WithEvents Pnl_CantidadUser As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Pnl_CantidadEstudiantes As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lblCantidadEstudiantes As Label
    Friend WithEvents Pnl_CantidadMaterias As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_HORA As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents tmrHora As Timer
    Friend WithEvents PictureBox2 As PictureBox
End Class
