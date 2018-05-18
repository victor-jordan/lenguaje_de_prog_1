<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.BtnAlquileres = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnPeliculas = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAlquileres
        '
        Me.BtnAlquileres.Location = New System.Drawing.Point(12, 11)
        Me.BtnAlquileres.Name = "BtnAlquileres"
        Me.BtnAlquileres.Size = New System.Drawing.Size(268, 58)
        Me.BtnAlquileres.TabIndex = 0
        Me.BtnAlquileres.Text = "Alquileres"
        Me.BtnAlquileres.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.Location = New System.Drawing.Point(12, 75)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(268, 58)
        Me.BtnClientes.TabIndex = 1
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnPeliculas
        '
        Me.BtnPeliculas.Location = New System.Drawing.Point(12, 139)
        Me.BtnPeliculas.Name = "BtnPeliculas"
        Me.BtnPeliculas.Size = New System.Drawing.Size(268, 58)
        Me.BtnPeliculas.TabIndex = 2
        Me.BtnPeliculas.Text = "Películas"
        Me.BtnPeliculas.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(12, 203)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(268, 58)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 272)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnPeliculas)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.BtnAlquileres)
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAlquileres As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnPeliculas As Button
    Friend WithEvents BtnSalir As Button
End Class
