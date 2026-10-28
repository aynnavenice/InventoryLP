<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Asset_Grid = New System.Windows.Forms.DataGridView()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentSectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InclusionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Transaction_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lptp_invntryDataSet2 = New Inventory.lptp_invntryDataSet2()
        Me.InvtrydataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lptp_invntryDataSet1 = New Inventory.lptp_invntryDataSet1()
        Me.grp_asset_details = New System.Windows.Forms.GroupBox()
        Me.btn_update_record = New System.Windows.Forms.Button()
        Me.cmb_inv_status = New System.Windows.Forms.ComboBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.cmb_asst_stat = New System.Windows.Forms.ComboBox()
        Me.btn_addrecord = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_stdnt_sctn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Stdnt_Nm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_asst_inc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_SN = New System.Windows.Forms.Label()
        Me.txt_asst_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_asst_sn = New System.Windows.Forms.TextBox()
        Me.Invtry_dataTableAdapter = New Inventory.lptp_invntryDataSet1TableAdapters.invtry_dataTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Teacher_IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Teacher_IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Inv_dataTableAdapter = New Inventory.lptp_invntryDataSet2TableAdapters.inv_dataTableAdapter()
        CType(Me.Asset_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lptp_invntryDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvtrydataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lptp_invntryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_asset_details.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Asset_Grid
        '
        Me.Asset_Grid.AllowUserToAddRows = False
        Me.Asset_Grid.AllowUserToDeleteRows = False
        Me.Asset_Grid.AutoGenerateColumns = False
        Me.Asset_Grid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Asset_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Asset_Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentNameDataGridViewTextBoxColumn, Me.StudentSectionDataGridViewTextBoxColumn, Me.AssetIDDataGridViewTextBoxColumn, Me.SerialNumberDataGridViewTextBoxColumn, Me.AssetStatusDataGridViewTextBoxColumn, Me.InclusionDataGridViewTextBoxColumn, Me.InventoryStatusDataGridViewTextBoxColumn, Me.Transaction_ID})
        Me.Asset_Grid.DataSource = Me.InvdataBindingSource
        Me.Asset_Grid.Location = New System.Drawing.Point(333, 49)
        Me.Asset_Grid.Name = "Asset_Grid"
        Me.Asset_Grid.ReadOnly = True
        Me.Asset_Grid.RowHeadersWidth = 51
        Me.Asset_Grid.RowTemplate.Height = 24
        Me.Asset_Grid.Size = New System.Drawing.Size(1005, 520)
        Me.Asset_Grid.TabIndex = 0
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name"
        Me.StudentNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        Me.StudentNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentNameDataGridViewTextBoxColumn.Width = 125
        '
        'StudentSectionDataGridViewTextBoxColumn
        '
        Me.StudentSectionDataGridViewTextBoxColumn.DataPropertyName = "Student_Section"
        Me.StudentSectionDataGridViewTextBoxColumn.HeaderText = "Student_Section"
        Me.StudentSectionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StudentSectionDataGridViewTextBoxColumn.Name = "StudentSectionDataGridViewTextBoxColumn"
        Me.StudentSectionDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentSectionDataGridViewTextBoxColumn.Width = 125
        '
        'AssetIDDataGridViewTextBoxColumn
        '
        Me.AssetIDDataGridViewTextBoxColumn.DataPropertyName = "Asset_ID"
        Me.AssetIDDataGridViewTextBoxColumn.HeaderText = "Asset_ID"
        Me.AssetIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AssetIDDataGridViewTextBoxColumn.Name = "AssetIDDataGridViewTextBoxColumn"
        Me.AssetIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.AssetIDDataGridViewTextBoxColumn.Width = 125
        '
        'SerialNumberDataGridViewTextBoxColumn
        '
        Me.SerialNumberDataGridViewTextBoxColumn.DataPropertyName = "Serial_Number"
        Me.SerialNumberDataGridViewTextBoxColumn.HeaderText = "Serial_Number"
        Me.SerialNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SerialNumberDataGridViewTextBoxColumn.Name = "SerialNumberDataGridViewTextBoxColumn"
        Me.SerialNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.SerialNumberDataGridViewTextBoxColumn.Width = 125
        '
        'AssetStatusDataGridViewTextBoxColumn
        '
        Me.AssetStatusDataGridViewTextBoxColumn.DataPropertyName = "Asset_Status"
        Me.AssetStatusDataGridViewTextBoxColumn.HeaderText = "Asset_Status"
        Me.AssetStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AssetStatusDataGridViewTextBoxColumn.Name = "AssetStatusDataGridViewTextBoxColumn"
        Me.AssetStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.AssetStatusDataGridViewTextBoxColumn.Width = 125
        '
        'InclusionDataGridViewTextBoxColumn
        '
        Me.InclusionDataGridViewTextBoxColumn.DataPropertyName = "Inclusion"
        Me.InclusionDataGridViewTextBoxColumn.HeaderText = "Inclusion"
        Me.InclusionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InclusionDataGridViewTextBoxColumn.Name = "InclusionDataGridViewTextBoxColumn"
        Me.InclusionDataGridViewTextBoxColumn.ReadOnly = True
        Me.InclusionDataGridViewTextBoxColumn.Width = 125
        '
        'InventoryStatusDataGridViewTextBoxColumn
        '
        Me.InventoryStatusDataGridViewTextBoxColumn.DataPropertyName = "Inventory_Status"
        Me.InventoryStatusDataGridViewTextBoxColumn.HeaderText = "Inventory_Status"
        Me.InventoryStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InventoryStatusDataGridViewTextBoxColumn.Name = "InventoryStatusDataGridViewTextBoxColumn"
        Me.InventoryStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.InventoryStatusDataGridViewTextBoxColumn.Width = 125
        '
        'Transaction_ID
        '
        Me.Transaction_ID.DataPropertyName = "Transaction_ID"
        Me.Transaction_ID.HeaderText = "Transaction_ID"
        Me.Transaction_ID.MinimumWidth = 6
        Me.Transaction_ID.Name = "Transaction_ID"
        Me.Transaction_ID.ReadOnly = True
        Me.Transaction_ID.Width = 125
        '
        'InvdataBindingSource
        '
        Me.InvdataBindingSource.DataMember = "inv_data"
        Me.InvdataBindingSource.DataSource = Me.Lptp_invntryDataSet2
        '
        'Lptp_invntryDataSet2
        '
        Me.Lptp_invntryDataSet2.DataSetName = "lptp_invntryDataSet2"
        Me.Lptp_invntryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvtrydataBindingSource
        '
        Me.InvtrydataBindingSource.DataMember = "invtry_data"
        Me.InvtrydataBindingSource.DataSource = Me.Lptp_invntryDataSet1
        '
        'Lptp_invntryDataSet1
        '
        Me.Lptp_invntryDataSet1.DataSetName = "lptp_invntryDataSet1"
        Me.Lptp_invntryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grp_asset_details
        '
        Me.grp_asset_details.Controls.Add(Me.btn_update_record)
        Me.grp_asset_details.Controls.Add(Me.cmb_inv_status)
        Me.grp_asset_details.Controls.Add(Me.btn_logout)
        Me.grp_asset_details.Controls.Add(Me.cmb_asst_stat)
        Me.grp_asset_details.Controls.Add(Me.btn_addrecord)
        Me.grp_asset_details.Controls.Add(Me.Label6)
        Me.grp_asset_details.Controls.Add(Me.txt_stdnt_sctn)
        Me.grp_asset_details.Controls.Add(Me.Label3)
        Me.grp_asset_details.Controls.Add(Me.txt_Stdnt_Nm)
        Me.grp_asset_details.Controls.Add(Me.Label4)
        Me.grp_asset_details.Controls.Add(Me.Label5)
        Me.grp_asset_details.Controls.Add(Me.txt_asst_inc)
        Me.grp_asset_details.Controls.Add(Me.Label2)
        Me.grp_asset_details.Controls.Add(Me.lbl_SN)
        Me.grp_asset_details.Controls.Add(Me.txt_asst_id)
        Me.grp_asset_details.Controls.Add(Me.Label1)
        Me.grp_asset_details.Controls.Add(Me.txt_asst_sn)
        Me.grp_asset_details.Dock = System.Windows.Forms.DockStyle.Left
        Me.grp_asset_details.Location = New System.Drawing.Point(0, 0)
        Me.grp_asset_details.Name = "grp_asset_details"
        Me.grp_asset_details.Size = New System.Drawing.Size(284, 678)
        Me.grp_asset_details.TabIndex = 4
        Me.grp_asset_details.TabStop = False
        '
        'btn_update_record
        '
        Me.btn_update_record.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_update_record.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update_record.Location = New System.Drawing.Point(142, 502)
        Me.btn_update_record.Name = "btn_update_record"
        Me.btn_update_record.Size = New System.Drawing.Size(126, 39)
        Me.btn_update_record.TabIndex = 11
        Me.btn_update_record.Text = "Update Record"
        Me.btn_update_record.UseVisualStyleBackColor = False
        '
        'cmb_inv_status
        '
        Me.cmb_inv_status.FormattingEnabled = True
        Me.cmb_inv_status.Location = New System.Drawing.Point(21, 463)
        Me.cmb_inv_status.Name = "cmb_inv_status"
        Me.cmb_inv_status.Size = New System.Drawing.Size(235, 24)
        Me.cmb_inv_status.TabIndex = 23
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_logout.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_logout.Location = New System.Drawing.Point(77, 605)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(120, 45)
        Me.btn_logout.TabIndex = 5
        Me.btn_logout.Text = "Sign Out"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'cmb_asst_stat
        '
        Me.cmb_asst_stat.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_asst_stat.FormattingEnabled = True
        Me.cmb_asst_stat.Location = New System.Drawing.Point(21, 331)
        Me.cmb_asst_stat.Name = "cmb_asst_stat"
        Me.cmb_asst_stat.Size = New System.Drawing.Size(235, 25)
        Me.cmb_asst_stat.TabIndex = 14
        '
        'btn_addrecord
        '
        Me.btn_addrecord.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_addrecord.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addrecord.Location = New System.Drawing.Point(21, 502)
        Me.btn_addrecord.Name = "btn_addrecord"
        Me.btn_addrecord.Size = New System.Drawing.Size(114, 39)
        Me.btn_addrecord.TabIndex = 22
        Me.btn_addrecord.Text = "Add Record"
        Me.btn_addrecord.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Student Section"
        '
        'txt_stdnt_sctn
        '
        Me.txt_stdnt_sctn.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stdnt_sctn.Location = New System.Drawing.Point(21, 144)
        Me.txt_stdnt_sctn.Name = "txt_stdnt_sctn"
        Me.txt_stdnt_sctn.Size = New System.Drawing.Size(235, 28)
        Me.txt_stdnt_sctn.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Student Name"
        '
        'txt_Stdnt_Nm
        '
        Me.txt_Stdnt_Nm.Location = New System.Drawing.Point(21, 85)
        Me.txt_Stdnt_Nm.Name = "txt_Stdnt_Nm"
        Me.txt_Stdnt_Nm.Size = New System.Drawing.Size(235, 22)
        Me.txt_Stdnt_Nm.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 444)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Inclusion (Optional)"
        '
        'txt_asst_inc
        '
        Me.txt_asst_inc.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_asst_inc.Location = New System.Drawing.Point(21, 387)
        Me.txt_asst_inc.Multiline = True
        Me.txt_asst_inc.Name = "txt_asst_inc"
        Me.txt_asst_inc.Size = New System.Drawing.Size(235, 42)
        Me.txt_asst_inc.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Asset Status"
        '
        'lbl_SN
        '
        Me.lbl_SN.AutoSize = True
        Me.lbl_SN.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SN.Location = New System.Drawing.Point(18, 245)
        Me.lbl_SN.Name = "lbl_SN"
        Me.lbl_SN.Size = New System.Drawing.Size(88, 17)
        Me.lbl_SN.TabIndex = 7
        Me.lbl_SN.Text = "Asset ID"
        '
        'txt_asst_id
        '
        Me.txt_asst_id.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_asst_id.Location = New System.Drawing.Point(21, 264)
        Me.txt_asst_id.Name = "txt_asst_id"
        Me.txt_asst_id.Size = New System.Drawing.Size(235, 28)
        Me.txt_asst_id.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Serial Number"
        '
        'txt_asst_sn
        '
        Me.txt_asst_sn.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_asst_sn.Location = New System.Drawing.Point(21, 205)
        Me.txt_asst_sn.Name = "txt_asst_sn"
        Me.txt_asst_sn.Size = New System.Drawing.Size(235, 28)
        Me.txt_asst_sn.TabIndex = 4
        '
        'Invtry_dataTableAdapter
        '
        Me.Invtry_dataTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(384, 634)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 8
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Teacher_IDToolStripLabel, Me.Teacher_IDToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(284, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1066, 31)
        Me.FillByToolStrip.TabIndex = 10
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'Teacher_IDToolStripLabel
        '
        Me.Teacher_IDToolStripLabel.Name = "Teacher_IDToolStripLabel"
        Me.Teacher_IDToolStripLabel.Size = New System.Drawing.Size(84, 28)
        Me.Teacher_IDToolStripLabel.Text = "Teacher_ID:"
        '
        'Teacher_IDToolStripTextBox
        '
        Me.Teacher_IDToolStripTextBox.Name = "Teacher_IDToolStripTextBox"
        Me.Teacher_IDToolStripTextBox.Size = New System.Drawing.Size(100, 31)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 28)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'Inv_dataTableAdapter
        '
        Me.Inv_dataTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 678)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grp_asset_details)
        Me.Controls.Add(Me.Asset_Grid)
        Me.Name = "Form2"
        Me.Text = "INVENTORY LIST"
        CType(Me.Asset_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lptp_invntryDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvtrydataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lptp_invntryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_asset_details.ResumeLayout(False)
        Me.grp_asset_details.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Asset_Grid As DataGridView
    Friend WithEvents Lptp_invntryDataSet1 As lptp_invntryDataSet1
    Friend WithEvents InvtrydataBindingSource As BindingSource
    Friend WithEvents Invtry_dataTableAdapter As lptp_invntryDataSet1TableAdapters.invtry_dataTableAdapter
    Friend WithEvents grp_asset_details As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_asst_inc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_SN As Label
    Friend WithEvents txt_asst_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_asst_sn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_stdnt_sctn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Stdnt_Nm As TextBox
    Friend WithEvents btn_addrecord As Button
    Friend WithEvents cmb_asst_stat As ComboBox
    Friend WithEvents cmb_inv_status As ComboBox
    Friend WithEvents btn_logout As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Lptp_invntryDataSet2 As lptp_invntryDataSet2
    Friend WithEvents InvdataBindingSource As BindingSource
    Friend WithEvents Inv_dataTableAdapter As lptp_invntryDataSet2TableAdapters.inv_dataTableAdapter
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents Teacher_IDToolStripLabel As ToolStripLabel
    Friend WithEvents Teacher_IDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents btn_update_record As Button
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentSectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerialNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InclusionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Transaction_ID As DataGridViewTextBoxColumn
End Class
