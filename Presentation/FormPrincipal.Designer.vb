<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelTitulo.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(798, 0)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(38, 27)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelTitulo.Controls.Add(Me.btnSalir)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(835, 23)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(768, -2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(31, 27)
        Me.btnRestaurar.TabIndex = 8
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(768, -2)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(31, 27)
        Me.btnMaximizar.TabIndex = 7
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(730, -2)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(38, 27)
        Me.btnMinimizar.TabIndex = 6
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelLateral.Controls.Add(Me.Button7)
        Me.PanelLateral.Controls.Add(Me.Button6)
        Me.PanelLateral.Controls.Add(Me.Button5)
        Me.PanelLateral.Controls.Add(Me.Button4)
        Me.PanelLateral.Controls.Add(Me.Button3)
        Me.PanelLateral.Controls.Add(Me.Button2)
        Me.PanelLateral.Controls.Add(Me.Button1)
        Me.PanelLateral.Controls.Add(Me.PictureBox2)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 23)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(161, 436)
        Me.PanelLateral.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(162, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 38)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Inicio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 38)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Usuarios"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(0, 146)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 38)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Estudiantes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(0, 223)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(161, 38)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Materias"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(0, 261)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(161, 38)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "Asignar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(0, 390)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(161, 38)
        Me.Button6.TabIndex = 32
        Me.Button6.Text = "Cerrar Sesion"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(-1, 185)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(161, 38)
        Me.Button7.TabIndex = 33
        Me.Button7.Text = "Cursos"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(825, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 436)
        Me.Panel1.TabIndex = 2
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(835, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPrincipal"
        Me.Text = "FormPrincipal"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelLateral.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel1 As Panel
End Class
