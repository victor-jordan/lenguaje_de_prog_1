<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPelicula
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
        Me.DgvPeliculas = New System.Windows.Forms.DataGridView()
        Me.GrpbDatos = New System.Windows.Forms.GroupBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.CmbFormato = New System.Windows.Forms.ComboBox()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.lblFormato = New System.Windows.Forms.Label()
        Me.lblDirector = New System.Windows.Forms.Label()
        Me.TxtDirector = New System.Windows.Forms.TextBox()
        Me.LblAnio = New System.Windows.Forms.Label()
        Me.TxtAnio = New System.Windows.Forms.TextBox()
        Me.LblGenero = New System.Windows.Forms.Label()
        Me.TxtGenero = New System.Windows.Forms.TextBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblId = New System.Windows.Forms.Label()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        CType(Me.DgvPeliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvPeliculas
        '
        Me.DgvPeliculas.AllowUserToAddRows = False
        Me.DgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPeliculas.Dock = System.Windows.Forms.DockStyle.Right
        Me.DgvPeliculas.Location = New System.Drawing.Point(371, 0)
        Me.DgvPeliculas.Name = "DgvPeliculas"
        Me.DgvPeliculas.Size = New System.Drawing.Size(575, 273)
        Me.DgvPeliculas.TabIndex = 0
        '
        'GrpbDatos
        '
        Me.GrpbDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpbDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrpbDatos.Controls.Add(Me.BtnReset)
        Me.GrpbDatos.Controls.Add(Me.CmbFormato)
        Me.GrpbDatos.Controls.Add(Me.BtnBorrar)
        Me.GrpbDatos.Controls.Add(Me.BtnCancelar)
        Me.GrpbDatos.Controls.Add(Me.LblPrecio)
        Me.GrpbDatos.Controls.Add(Me.TxtPrecio)
        Me.GrpbDatos.Controls.Add(Me.BtnAgregar)
        Me.GrpbDatos.Controls.Add(Me.lblFormato)
        Me.GrpbDatos.Controls.Add(Me.lblDirector)
        Me.GrpbDatos.Controls.Add(Me.TxtDirector)
        Me.GrpbDatos.Controls.Add(Me.LblAnio)
        Me.GrpbDatos.Controls.Add(Me.TxtAnio)
        Me.GrpbDatos.Controls.Add(Me.LblGenero)
        Me.GrpbDatos.Controls.Add(Me.TxtGenero)
        Me.GrpbDatos.Controls.Add(Me.LblTitulo)
        Me.GrpbDatos.Controls.Add(Me.LblId)
        Me.GrpbDatos.Controls.Add(Me.TxtTitulo)
        Me.GrpbDatos.Location = New System.Drawing.Point(0, 5)
        Me.GrpbDatos.Name = "GrpbDatos"
        Me.GrpbDatos.Size = New System.Drawing.Size(365, 268)
        Me.GrpbDatos.TabIndex = 1
        Me.GrpbDatos.TabStop = False
        Me.GrpbDatos.Text = "Datos de Pelicula"
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(175, 230)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(140, 23)
        Me.BtnReset.TabIndex = 19
        Me.BtnReset.Text = "Resetear"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'CmbFormato
        '
        Me.CmbFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbFormato.FormattingEnabled = True
        Me.CmbFormato.Items.AddRange(New Object() {"VHS", "DVD", "BRY", "TDI", "HD"})
        Me.CmbFormato.Location = New System.Drawing.Point(187, 114)
        Me.CmbFormato.Name = "CmbFormato"
        Me.CmbFormato.Size = New System.Drawing.Size(128, 21)
        Me.CmbFormato.TabIndex = 18
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(175, 201)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(140, 23)
        Me.BtnBorrar.TabIndex = 17
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(12, 230)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(140, 23)
        Me.BtnCancelar.TabIndex = 18
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(184, 144)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.LblPrecio.TabIndex = 7
        Me.LblPrecio.Text = "Precio"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(187, 160)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(128, 20)
        Me.TxtPrecio.TabIndex = 19
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(12, 201)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(140, 23)
        Me.BtnAgregar.TabIndex = 16
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'lblFormato
        '
        Me.lblFormato.AutoSize = True
        Me.lblFormato.Location = New System.Drawing.Point(184, 97)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(45, 13)
        Me.lblFormato.TabIndex = 8
        Me.lblFormato.Text = "Formato"
        '
        'lblDirector
        '
        Me.lblDirector.AutoSize = True
        Me.lblDirector.Location = New System.Drawing.Point(184, 50)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(44, 13)
        Me.lblDirector.TabIndex = 9
        Me.lblDirector.Text = "Director"
        '
        'TxtDirector
        '
        Me.TxtDirector.Location = New System.Drawing.Point(187, 66)
        Me.TxtDirector.Name = "TxtDirector"
        Me.TxtDirector.Size = New System.Drawing.Size(128, 20)
        Me.TxtDirector.TabIndex = 17
        '
        'LblAnio
        '
        Me.LblAnio.AutoSize = True
        Me.LblAnio.Location = New System.Drawing.Point(9, 144)
        Me.LblAnio.Name = "LblAnio"
        Me.LblAnio.Size = New System.Drawing.Size(26, 13)
        Me.LblAnio.TabIndex = 10
        Me.LblAnio.Text = "Año"
        '
        'TxtAnio
        '
        Me.TxtAnio.Location = New System.Drawing.Point(12, 160)
        Me.TxtAnio.Name = "TxtAnio"
        Me.TxtAnio.Size = New System.Drawing.Size(82, 20)
        Me.TxtAnio.TabIndex = 16
        '
        'LblGenero
        '
        Me.LblGenero.AutoSize = True
        Me.LblGenero.Location = New System.Drawing.Point(9, 97)
        Me.LblGenero.Name = "LblGenero"
        Me.LblGenero.Size = New System.Drawing.Size(42, 13)
        Me.LblGenero.TabIndex = 11
        Me.LblGenero.Text = "Genero"
        '
        'TxtGenero
        '
        Me.TxtGenero.Location = New System.Drawing.Point(12, 113)
        Me.TxtGenero.Name = "TxtGenero"
        Me.TxtGenero.Size = New System.Drawing.Size(130, 20)
        Me.TxtGenero.TabIndex = 15
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Location = New System.Drawing.Point(9, 50)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(33, 13)
        Me.LblTitulo.TabIndex = 12
        Me.LblTitulo.Text = "Titulo"
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(12, 25)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(57, 13)
        Me.LblId.TabIndex = 13
        Me.LblId.Text = "pelicula_id"
        '
        'TxtTitulo
        '
        Me.TxtTitulo.Location = New System.Drawing.Point(12, 66)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Size = New System.Drawing.Size(130, 20)
        Me.TxtTitulo.TabIndex = 14
        '
        'FrmPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 273)
        Me.Controls.Add(Me.GrpbDatos)
        Me.Controls.Add(Me.DgvPeliculas)
        Me.Name = "FrmPelicula"
        Me.Text = "FrmPelicula"
        CType(Me.DgvPeliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpbDatos.ResumeLayout(False)
        Me.GrpbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvPeliculas As DataGridView
    Friend WithEvents GrpbDatos As GroupBox
    Private WithEvents CmbFormato As ComboBox
    Private WithEvents LblPrecio As Label
    Private WithEvents TxtPrecio As TextBox
    Private WithEvents lblFormato As Label
    Private WithEvents lblDirector As Label
    Private WithEvents TxtDirector As TextBox
    Private WithEvents LblAnio As Label
    Private WithEvents TxtAnio As TextBox
    Private WithEvents LblGenero As Label
    Private WithEvents TxtGenero As TextBox
    Private WithEvents LblTitulo As Label
    Private WithEvents LblId As Label
    Private WithEvents TxtTitulo As TextBox
    Private WithEvents BtnReset As Button
    Private WithEvents BtnCancelar As Button
    Private WithEvents BtnBorrar As Button
    Private WithEvents BtnAgregar As Button
End Class
