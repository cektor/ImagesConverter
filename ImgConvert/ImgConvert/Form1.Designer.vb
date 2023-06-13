<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.pbPreview = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFormats = New System.Windows.Forms.ComboBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnOpenImage = New System.Windows.Forms.Button()
        Me.dgvFiles = New System.Windows.Forms.DataGridView()
        Me.fileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClearList
        '
        Me.btnClearList.Location = New System.Drawing.Point(23, 417)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(264, 25)
        Me.btnClearList.TabIndex = 9
        Me.btnClearList.Text = "Listeyi Temizle"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(23, 381)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(264, 25)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Listeyi Kaldır"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'pbPreview
        '
        Me.pbPreview.BackColor = System.Drawing.Color.Transparent
        Me.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPreview.Location = New System.Drawing.Point(24, 128)
        Me.pbPreview.Name = "pbPreview"
        Me.pbPreview.Size = New System.Drawing.Size(264, 249)
        Me.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPreview.TabIndex = 7
        Me.pbPreview.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbFormats)
        Me.Panel1.Controls.Add(Me.btnOpenImage)
        Me.Panel1.Controls.Add(Me.btnConvert)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 64)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Çeviri Formatı :"
        '
        'cmbFormats
        '
        Me.cmbFormats.FormattingEnabled = True
        Me.cmbFormats.Items.AddRange(New Object() {"BMP", "GIF", "PNG", "JPG", "TIFF"})
        Me.cmbFormats.Location = New System.Drawing.Point(85, 36)
        Me.cmbFormats.Name = "cmbFormats"
        Me.cmbFormats.Size = New System.Drawing.Size(103, 21)
        Me.cmbFormats.TabIndex = 2
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(192, 35)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(65, 23)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Çeviri Yap"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnOpenImage
        '
        Me.btnOpenImage.Location = New System.Drawing.Point(4, 5)
        Me.btnOpenImage.Name = "btnOpenImage"
        Me.btnOpenImage.Size = New System.Drawing.Size(71, 23)
        Me.btnOpenImage.TabIndex = 0
        Me.btnOpenImage.Text = "Görsel Aç"
        Me.btnOpenImage.UseVisualStyleBackColor = True
        '
        'dgvFiles
        '
        Me.dgvFiles.AllowUserToAddRows = False
        Me.dgvFiles.AllowUserToDeleteRows = False
        Me.dgvFiles.AllowUserToOrderColumns = True
        Me.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFiles.BackgroundColor = System.Drawing.Color.White
        Me.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fileName})
        Me.dgvFiles.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvFiles.Location = New System.Drawing.Point(294, 63)
        Me.dgvFiles.MultiSelect = False
        Me.dgvFiles.Name = "dgvFiles"
        Me.dgvFiles.ReadOnly = True
        Me.dgvFiles.RowHeadersWidth = 77
        Me.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFiles.Size = New System.Drawing.Size(391, 379)
        Me.dgvFiles.TabIndex = 5
        '
        'fileName
        '
        Me.fileName.HeaderText = "Dosya Adı"
        Me.fileName.Name = "fileName"
        Me.fileName.ReadOnly = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(506, 455)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(179, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ALG Yazılım && Elektronik Inc.© 2023"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(703, 478)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.pbPreview)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvFiles)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "İmage's Converter"
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClearList As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents pbPreview As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFormats As ComboBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnOpenImage As Button
    Friend WithEvents dgvFiles As DataGridView
    Friend WithEvents fileName As DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
