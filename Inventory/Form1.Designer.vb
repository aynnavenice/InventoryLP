<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Adm_frm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adm_frm))
        Me.Lptp_invntryDataSet3 = New Inventory.lptp_invntryDataSet3()
        Me.InvtrydataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Invtry_dataTableAdapter = New Inventory.lptp_invntryDataSet3TableAdapters.invtry_dataTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SerialNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentSectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InclusionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lptp_invntryDataSet5 = New Inventory.lptp_invntryDataSet5()
        Me.Lptp_invntryDataSet4 = New Inventory.lptp_invntryDataSet4()
        Me.LptpinvntryDataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inv_dataTableAdapter = New Inventory.lptp_invntryDataSet5TableAdapters.inv_dataTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.Lptp_invntryDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvtrydataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lptp_invntryDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lptp_invntryDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LptpinvntryDataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lptp_invntryDataSet3
        '
        Me.Lptp_invntryDataSet3.DataSetName = "lptp_invntryDataSet3"
        Me.Lptp_invntryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvtrydataBindingSource
        '
        Me.InvtrydataBindingSource.DataMember = "invtry_data"
        Me.InvtrydataBindingSource.DataSource = Me.Lptp_invntryDataSet3
        '
        'Invtry_dataTableAdapter
        '
        Me.Invtry_dataTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SerialNumberDataGridViewTextBoxColumn, Me.AssetIDDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.StudentSectionDataGridViewTextBoxColumn, Me.AssetStatusDataGridViewTextBoxColumn, Me.TeacherIDDataGridViewTextBoxColumn, Me.InclusionDataGridViewTextBoxColumn, Me.InventoryStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InvdataBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(145, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1054, 425)
        Me.DataGridView1.TabIndex = 0
        '
        'SerialNumberDataGridViewTextBoxColumn
        '
        Me.SerialNumberDataGridViewTextBoxColumn.DataPropertyName = "Serial_Number"
        Me.SerialNumberDataGridViewTextBoxColumn.HeaderText = "Serial_Number"
        Me.SerialNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SerialNumberDataGridViewTextBoxColumn.Name = "SerialNumberDataGridViewTextBoxColumn"
        Me.SerialNumberDataGridViewTextBoxColumn.Width = 125
        '
        'AssetIDDataGridViewTextBoxColumn
        '
        Me.AssetIDDataGridViewTextBoxColumn.DataPropertyName = "Asset_ID"
        Me.AssetIDDataGridViewTextBoxColumn.HeaderText = "Asset_ID"
        Me.AssetIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AssetIDDataGridViewTextBoxColumn.Name = "AssetIDDataGridViewTextBoxColumn"
        Me.AssetIDDataGridViewTextBoxColumn.Width = 125
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name"
        Me.StudentNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        Me.StudentNameDataGridViewTextBoxColumn.Width = 125
        '
        'StudentSectionDataGridViewTextBoxColumn
        '
        Me.StudentSectionDataGridViewTextBoxColumn.DataPropertyName = "Student_Section"
        Me.StudentSectionDataGridViewTextBoxColumn.HeaderText = "Student_Section"
        Me.StudentSectionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StudentSectionDataGridViewTextBoxColumn.Name = "StudentSectionDataGridViewTextBoxColumn"
        Me.StudentSectionDataGridViewTextBoxColumn.Width = 125
        '
        'AssetStatusDataGridViewTextBoxColumn
        '
        Me.AssetStatusDataGridViewTextBoxColumn.DataPropertyName = "Asset_Status"
        Me.AssetStatusDataGridViewTextBoxColumn.HeaderText = "Asset_Status"
        Me.AssetStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AssetStatusDataGridViewTextBoxColumn.Name = "AssetStatusDataGridViewTextBoxColumn"
        Me.AssetStatusDataGridViewTextBoxColumn.Width = 125
        '
        'TeacherIDDataGridViewTextBoxColumn
        '
        Me.TeacherIDDataGridViewTextBoxColumn.DataPropertyName = "Teacher_ID"
        Me.TeacherIDDataGridViewTextBoxColumn.HeaderText = "Teacher_ID"
        Me.TeacherIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TeacherIDDataGridViewTextBoxColumn.Name = "TeacherIDDataGridViewTextBoxColumn"
        Me.TeacherIDDataGridViewTextBoxColumn.Width = 125
        '
        'InclusionDataGridViewTextBoxColumn
        '
        Me.InclusionDataGridViewTextBoxColumn.DataPropertyName = "Inclusion"
        Me.InclusionDataGridViewTextBoxColumn.HeaderText = "Inclusion"
        Me.InclusionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InclusionDataGridViewTextBoxColumn.Name = "InclusionDataGridViewTextBoxColumn"
        Me.InclusionDataGridViewTextBoxColumn.Width = 125
        '
        'InventoryStatusDataGridViewTextBoxColumn
        '
        Me.InventoryStatusDataGridViewTextBoxColumn.DataPropertyName = "Inventory_Status"
        Me.InventoryStatusDataGridViewTextBoxColumn.HeaderText = "Inventory_Status"
        Me.InventoryStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InventoryStatusDataGridViewTextBoxColumn.Name = "InventoryStatusDataGridViewTextBoxColumn"
        Me.InventoryStatusDataGridViewTextBoxColumn.Width = 125
        '
        'InvdataBindingSource
        '
        Me.InvdataBindingSource.DataMember = "inv_data"
        Me.InvdataBindingSource.DataSource = Me.Lptp_invntryDataSet5
        '
        'Lptp_invntryDataSet5
        '
        Me.Lptp_invntryDataSet5.DataSetName = "lptp_invntryDataSet5"
        Me.Lptp_invntryDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lptp_invntryDataSet4
        '
        Me.Lptp_invntryDataSet4.DataSetName = "lptp_invntryDataSet4"
        Me.Lptp_invntryDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LptpinvntryDataSet4BindingSource
        '
        Me.LptpinvntryDataSet4BindingSource.DataSource = Me.Lptp_invntryDataSet4
        Me.LptpinvntryDataSet4BindingSource.Position = 0
        '
        'Inv_dataTableAdapter
        '
        Me.Inv_dataTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(145, 588)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SIGN OUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(145, 533)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "PRINT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Adm_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1342, 668)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Name = "Adm_frm"
        Me.Text = "ADMIN DASHBOARD"
        CType(Me.Lptp_invntryDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvtrydataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lptp_invntryDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lptp_invntryDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LptpinvntryDataSet4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lptp_invntryDataSet3 As lptp_invntryDataSet3
    Friend WithEvents InvtrydataBindingSource As BindingSource
    Friend WithEvents Invtry_dataTableAdapter As lptp_invntryDataSet3TableAdapters.invtry_dataTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentSectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeacherIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InclusionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Lptp_invntryDataSet4 As lptp_invntryDataSet4
    Friend WithEvents LptpinvntryDataSet4BindingSource As BindingSource
    Friend WithEvents Lptp_invntryDataSet5 As lptp_invntryDataSet5
    Friend WithEvents InvdataBindingSource As BindingSource
    Friend WithEvents Inv_dataTableAdapter As lptp_invntryDataSet5TableAdapters.inv_dataTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
