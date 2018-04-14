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
        CType(Me.matTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.interactionTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'matTable
        '
        Me.matTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.matTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.matTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.matMaterialCol, Me.matMassCol, Me.matConductivityCol, Me.matSpecHeatCol, Me.matTempCol})
        Me.matTable.Location = New System.Drawing.Point(12, 60)
        Me.matTable.Name = "matTable"
        Me.matTable.Size = New System.Drawing.Size(846, 180)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 42)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "End Time (min)"
        '
        'txtEndTime
        '
        Me.txtEndTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEndTime.Location = New System.Drawing.Point(3, 16)
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.Size = New System.Drawing.Size(130, 20)
        Me.txtEndTime.TabIndex = 0
        Me.txtEndTime.Text = "60"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTimeStep)
        Me.GroupBox2.Location = New System.Drawing.Point(154, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 42)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time Step (s)"
        '
        'txtTimeStep
        '
        Me.txtTimeStep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTimeStep.Location = New System.Drawing.Point(3, 16)
        Me.txtTimeStep.Name = "txtTimeStep"
        Me.txtTimeStep.Size = New System.Drawing.Size(130, 20)
        Me.txtTimeStep.TabIndex = 0
        Me.txtTimeStep.Text = "0.0005"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSampleRate)
        Me.GroupBox3.Location = New System.Drawing.Point(296, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(136, 42)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sample Rate (s)"
        '
        'txtSampleRate
        '
        Me.txtSampleRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSampleRate.Location = New System.Drawing.Point(3, 16)
        Me.txtSampleRate.Name = "txtSampleRate"
        Me.txtSampleRate.Size = New System.Drawing.Size(130, 20)
        Me.txtSampleRate.TabIndex = 0
        Me.txtSampleRate.Text = ".5"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtExtTemp)
        Me.GroupBox4.Location = New System.Drawing.Point(438, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(136, 42)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "External Temp (F)"
        '
        'txtExtTemp
        '
        Me.txtExtTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExtTemp.Location = New System.Drawing.Point(3, 16)
        Me.txtExtTemp.Name = "txtExtTemp"
        Me.txtExtTemp.Size = New System.Drawing.Size(130, 20)
        Me.txtExtTemp.TabIndex = 0
        Me.txtExtTemp.Text = "100"
        '
        'interactionTable
        '
        Me.interactionTable.AllowUserToAddRows = False
        Me.interactionTable.AllowUserToDeleteRows = False
        Me.interactionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.interactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.interactionTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InteractionCol, Me.EfficiencyCol, Me.contactAreaCol, Me.deltaXCol})
        Me.interactionTable.Location = New System.Drawing.Point(12, 246)
        Me.interactionTable.Name = "interactionTable"
        Me.interactionTable.Size = New System.Drawing.Size(846, 193)
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
        Me.GroupBox5.Location = New System.Drawing.Point(12, 445)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(559, 42)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Output File Path"
        '
        'txtFilePath
        '
        Me.txtFilePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFilePath.Location = New System.Drawing.Point(3, 16)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(553, 20)
        Me.txtFilePath.TabIndex = 0
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.Chartreuse
        Me.btnRun.Location = New System.Drawing.Point(737, 461)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(121, 61)
        Me.btnRun.TabIndex = 7
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 541)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(870, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 563)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.interactionTable)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.matTable)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
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
End Class
