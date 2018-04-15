<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.matTable = New System.Windows.Forms.DataGridView()
        Me.matMaterialCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matMassCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matConductivityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matSpecHeatCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matTempCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEndTime = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTimeStep = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSampleRate = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtExtTemp = New System.Windows.Forms.TextBox()
        Me.interactionTable = New System.Windows.Forms.DataGridView()
        Me.InteractionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EfficiencyCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contactAreaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deltaXCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.matTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.interactionTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'matTable
        '
        Me.matTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.matTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.matTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.matMaterialCol, Me.matMassCol, Me.matConductivityCol, Me.matSpecHeatCol, Me.matTempCol})
        Me.matTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.matTable.Location = New System.Drawing.Point(3, 103)
        Me.matTable.Name = "matTable"
        Me.matTable.Size = New System.Drawing.Size(678, 138)
        Me.matTable.TabIndex = 0
        '
        'matMaterialCol
        '
        Me.matMaterialCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.matMaterialCol.HeaderText = "Material"
        Me.matMaterialCol.Name = "matMaterialCol"
        Me.matMaterialCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.matMaterialCol.Width = 50
        '
        'matMassCol
        '
        Me.matMassCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.matMassCol.HeaderText = "Mass (lbm)"
        Me.matMassCol.Name = "matMassCol"
        Me.matMassCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.matMassCol.Width = 57
        '
        'matConductivityCol
        '
        Me.matConductivityCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.matConductivityCol.HeaderText = "Thermal Conductivity (BTU-in/hr-ft^2-F)"
        Me.matConductivityCol.Name = "matConductivityCol"
        Me.matConductivityCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.matConductivityCol.Width = 178
        '
        'matSpecHeatCol
        '
        Me.matSpecHeatCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.matSpecHeatCol.HeaderText = "Specific Heat (Btu/lbm-F)"
        Me.matSpecHeatCol.Name = "matSpecHeatCol"
        Me.matSpecHeatCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.matSpecHeatCol.Width = 119
        '
        'matTempCol
        '
        Me.matTempCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.matTempCol.HeaderText = "Start Temperature (F)"
        Me.matTempCol.Name = "matTempCol"
        Me.matTempCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.matTempCol.Width = 91
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEndTime)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 38)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "End Time (min)"
        '
        'txtEndTime
        '
        Me.txtEndTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEndTime.Location = New System.Drawing.Point(3, 16)
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.Size = New System.Drawing.Size(123, 20)
        Me.txtEndTime.TabIndex = 0
        Me.txtEndTime.Text = "60"
        Me.txtEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTimeStep)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(138, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 38)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time Step (s)"
        '
        'txtTimeStep
        '
        Me.txtTimeStep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTimeStep.Location = New System.Drawing.Point(3, 16)
        Me.txtTimeStep.Name = "txtTimeStep"
        Me.txtTimeStep.Size = New System.Drawing.Size(123, 20)
        Me.txtTimeStep.TabIndex = 0
        Me.txtTimeStep.Text = "0.0005"
        Me.txtTimeStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSampleRate)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(273, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(129, 38)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sample Rate (s)"
        '
        'txtSampleRate
        '
        Me.txtSampleRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSampleRate.Location = New System.Drawing.Point(3, 16)
        Me.txtSampleRate.Name = "txtSampleRate"
        Me.txtSampleRate.Size = New System.Drawing.Size(123, 20)
        Me.txtSampleRate.TabIndex = 0
        Me.txtSampleRate.Text = ".5"
        Me.txtSampleRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtExtTemp)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(408, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(129, 38)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "External Temp (F)"
        '
        'txtExtTemp
        '
        Me.txtExtTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExtTemp.Location = New System.Drawing.Point(3, 16)
        Me.txtExtTemp.Name = "txtExtTemp"
        Me.txtExtTemp.Size = New System.Drawing.Size(123, 20)
        Me.txtExtTemp.TabIndex = 0
        Me.txtExtTemp.Text = "100"
        Me.txtExtTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'interactionTable
        '
        Me.interactionTable.AllowUserToAddRows = False
        Me.interactionTable.AllowUserToDeleteRows = False
        Me.interactionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.interactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.interactionTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InteractionCol, Me.EfficiencyCol, Me.contactAreaCol, Me.deltaXCol})
        Me.interactionTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.interactionTable.Location = New System.Drawing.Point(3, 247)
        Me.interactionTable.Name = "interactionTable"
        Me.interactionTable.Size = New System.Drawing.Size(678, 138)
        Me.interactionTable.TabIndex = 5
        '
        'InteractionCol
        '
        Me.InteractionCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.InteractionCol.HeaderText = "Interaction"
        Me.InteractionCol.Name = "InteractionCol"
        Me.InteractionCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.InteractionCol.Width = 63
        '
        'EfficiencyCol
        '
        Me.EfficiencyCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EfficiencyCol.HeaderText = "Efficiency (0.00)"
        Me.EfficiencyCol.Name = "EfficiencyCol"
        Me.EfficiencyCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EfficiencyCol.Width = 80
        '
        'contactAreaCol
        '
        Me.contactAreaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.contactAreaCol.HeaderText = "Contact Area (in^2)"
        Me.contactAreaCol.Name = "contactAreaCol"
        Me.contactAreaCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.contactAreaCol.Width = 70
        '
        'deltaXCol
        '
        Me.deltaXCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.deltaXCol.HeaderText = "Thermal Gradiant (in)"
        Me.deltaXCol.Name = "deltaXCol"
        Me.deltaXCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.deltaXCol.Width = 87
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtFilePath)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 391)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(678, 44)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Output File Path"
        '
        'txtFilePath
        '
        Me.txtFilePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFilePath.Location = New System.Drawing.Point(3, 16)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(672, 20)
        Me.txtFilePath.TabIndex = 0
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.Chartreuse
        Me.btnRun.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRun.Location = New System.Drawing.Point(560, 441)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(121, 45)
        Me.btnRun.TabIndex = 7
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 489)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(684, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Status"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.matTable, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRun, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.interactionTable, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(684, 489)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox4, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 53)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(678, 44)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.98618!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.01382!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(678, 44)
        Me.TableLayoutPanel3.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thermal Conduction  Calculator"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 511)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(575, 400)
        Me.Name = "MainForm"
        Me.Text = "Thermal Conduction Calculator"
        CType(Me.matTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.interactionTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents matTable As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEndTime As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTimeStep As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSampleRate As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtExtTemp As TextBox
    Friend WithEvents interactionTable As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnRun As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents matMassCol As DataGridViewTextBoxColumn
    Friend WithEvents matSpecHeatCol As DataGridViewTextBoxColumn
    Friend WithEvents matTempCol As DataGridViewTextBoxColumn
    Friend WithEvents contactAreaCol As DataGridViewTextBoxColumn
    Friend WithEvents deltaXCol As DataGridViewTextBoxColumn
    Friend WithEvents matMaterialCol As DataGridViewTextBoxColumn
    Friend WithEvents matConductivityCol As DataGridViewTextBoxColumn
    Friend WithEvents InteractionCol As DataGridViewTextBoxColumn
    Friend WithEvents EfficiencyCol As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
End Class
