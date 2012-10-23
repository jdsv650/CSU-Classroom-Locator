<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Map_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Close_button = New System.Windows.Forms.Button()
        Me.Building_Info_label = New System.Windows.Forms.Label()
        Me.Closeup_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Building_Name_label = New System.Windows.Forms.Label()
        Me.CCT_label = New System.Windows.Forms.Label()
        Me.Illges_label = New System.Windows.Forms.Label()
        Me.Arnold_label = New System.Windows.Forms.Label()
        Me.Howard_label = New System.Windows.Forms.Label()
        Me.Building_comboBox = New System.Windows.Forms.ComboBox()
        Me.Course_Info_label = New System.Windows.Forms.Label()
        Me.CourseList_UpDown = New System.Windows.Forms.NumericUpDown()
        Me.Close_Info_button = New System.Windows.Forms.Button()
        Me.SearchByBuilding_label = New System.Windows.Forms.Label()
        Me.Days_label = New System.Windows.Forms.Label()
        Me.Days_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Submit_Query_button = New System.Windows.Forms.Button()
        Me.HR_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.HR_label = New System.Windows.Forms.Label()
        Me.MIN_label = New System.Windows.Forms.Label()
        Me.MIN_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Or_label = New System.Windows.Forms.Label()
        Me.Search_by_code_label = New System.Windows.Forms.Label()
        Me.Section_label = New System.Windows.Forms.Label()
        Me.Query_By_Code_button = New System.Windows.Forms.Button()
        Me.CourseCode_textBox = New System.Windows.Forms.TextBox()
        Me.Section_textBox = New System.Windows.Forms.TextBox()
        Me.Query_panel = New System.Windows.Forms.Panel()
        Me.AM_PM_comboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Map_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Closeup_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseList_UpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HR_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MIN_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Query_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Map_PictureBox
        '
        Me.Map_PictureBox.BackColor = System.Drawing.SystemColors.Control
        Me.Map_PictureBox.Image = Global.ClassroomLocator.My.Resources.Resources.CSU_Main_Small
        Me.Map_PictureBox.Location = New System.Drawing.Point(12, 12)
        Me.Map_PictureBox.Name = "Map_PictureBox"
        Me.Map_PictureBox.Size = New System.Drawing.Size(450, 400)
        Me.Map_PictureBox.TabIndex = 0
        Me.Map_PictureBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Close_button)
        Me.Panel1.Controls.Add(Me.Building_Info_label)
        Me.Panel1.Controls.Add(Me.Closeup_PictureBox)
        Me.Panel1.Controls.Add(Me.Building_Name_label)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 400)
        Me.Panel1.TabIndex = 2
        '
        'Close_button
        '
        Me.Close_button.ForeColor = System.Drawing.Color.Red
        Me.Close_button.Location = New System.Drawing.Point(208, 152)
        Me.Close_button.Name = "Close_button"
        Me.Close_button.Size = New System.Drawing.Size(103, 38)
        Me.Close_button.TabIndex = 3
        Me.Close_button.Text = "Close"
        Me.Close_button.UseVisualStyleBackColor = True
        '
        'Building_Info_label
        '
        Me.Building_Info_label.AutoSize = True
        Me.Building_Info_label.Location = New System.Drawing.Point(18, 234)
        Me.Building_Info_label.Name = "Building_Info_label"
        Me.Building_Info_label.Size = New System.Drawing.Size(137, 20)
        Me.Building_Info_label.TabIndex = 2
        Me.Building_Info_label.Text = "No Building Info"
        '
        'Closeup_PictureBox
        '
        Me.Closeup_PictureBox.Image = Global.ClassroomLocator.My.Resources.Resources.Grey
        Me.Closeup_PictureBox.Location = New System.Drawing.Point(18, 52)
        Me.Closeup_PictureBox.Name = "Closeup_PictureBox"
        Me.Closeup_PictureBox.Size = New System.Drawing.Size(160, 160)
        Me.Closeup_PictureBox.TabIndex = 1
        Me.Closeup_PictureBox.TabStop = False
        '
        'Building_Name_label
        '
        Me.Building_Name_label.AutoSize = True
        Me.Building_Name_label.Location = New System.Drawing.Point(15, 21)
        Me.Building_Name_label.Name = "Building_Name_label"
        Me.Building_Name_label.Size = New System.Drawing.Size(176, 20)
        Me.Building_Name_label.TabIndex = 0
        Me.Building_Name_label.Text = "No Building Selected"
        '
        'CCT_label
        '
        Me.CCT_label.BackColor = System.Drawing.SystemColors.Control
        Me.CCT_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CCT_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCT_label.ForeColor = System.Drawing.Color.Red
        Me.CCT_label.Location = New System.Drawing.Point(345, 164)
        Me.CCT_label.Name = "CCT_label"
        Me.CCT_label.Size = New System.Drawing.Size(69, 41)
        Me.CCT_label.TabIndex = 3
        Me.CCT_label.Text = " "
        Me.CCT_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Illges_label
        '
        Me.Illges_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Illges_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Illges_label.ForeColor = System.Drawing.Color.Red
        Me.Illges_label.Location = New System.Drawing.Point(169, 248)
        Me.Illges_label.Name = "Illges_label"
        Me.Illges_label.Size = New System.Drawing.Size(20, 33)
        Me.Illges_label.TabIndex = 4
        Me.Illges_label.Text = " "
        Me.Illges_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Arnold_label
        '
        Me.Arnold_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Arnold_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Arnold_label.ForeColor = System.Drawing.Color.Red
        Me.Arnold_label.Location = New System.Drawing.Point(195, 248)
        Me.Arnold_label.Margin = New System.Windows.Forms.Padding(0)
        Me.Arnold_label.Name = "Arnold_label"
        Me.Arnold_label.Size = New System.Drawing.Size(25, 36)
        Me.Arnold_label.TabIndex = 5
        Me.Arnold_label.Text = " "
        '
        'Howard_label
        '
        Me.Howard_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Howard_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Howard_label.ForeColor = System.Drawing.Color.Red
        Me.Howard_label.Location = New System.Drawing.Point(220, 217)
        Me.Howard_label.Margin = New System.Windows.Forms.Padding(0)
        Me.Howard_label.Name = "Howard_label"
        Me.Howard_label.Size = New System.Drawing.Size(22, 51)
        Me.Howard_label.TabIndex = 6
        Me.Howard_label.Text = " "
        Me.Howard_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Building_comboBox
        '
        Me.Building_comboBox.FormattingEnabled = True
        Me.Building_comboBox.Items.AddRange(New Object() {"No Selection", "CCT", "Illges", "Arnold", "Howard"})
        Me.Building_comboBox.Location = New System.Drawing.Point(16, 35)
        Me.Building_comboBox.Name = "Building_comboBox"
        Me.Building_comboBox.Size = New System.Drawing.Size(133, 21)
        Me.Building_comboBox.TabIndex = 7
        '
        'Course_Info_label
        '
        Me.Course_Info_label.AutoSize = True
        Me.Course_Info_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course_Info_label.Location = New System.Drawing.Point(496, 35)
        Me.Course_Info_label.Name = "Course_Info_label"
        Me.Course_Info_label.Size = New System.Drawing.Size(130, 20)
        Me.Course_Info_label.TabIndex = 8
        Me.Course_Info_label.Text = "No Course Info"
        Me.Course_Info_label.Visible = False
        '
        'CourseList_UpDown
        '
        Me.CourseList_UpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseList_UpDown.Location = New System.Drawing.Point(664, 33)
        Me.CourseList_UpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.CourseList_UpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CourseList_UpDown.Name = "CourseList_UpDown"
        Me.CourseList_UpDown.Size = New System.Drawing.Size(37, 26)
        Me.CourseList_UpDown.TabIndex = 9
        Me.CourseList_UpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CourseList_UpDown.Visible = False
        '
        'Close_Info_button
        '
        Me.Close_Info_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Info_button.ForeColor = System.Drawing.Color.Red
        Me.Close_Info_button.Location = New System.Drawing.Point(737, 375)
        Me.Close_Info_button.Name = "Close_Info_button"
        Me.Close_Info_button.Size = New System.Drawing.Size(95, 37)
        Me.Close_Info_button.TabIndex = 10
        Me.Close_Info_button.Text = "Reset All"
        Me.Close_Info_button.UseVisualStyleBackColor = True
        '
        'SearchByBuilding_label
        '
        Me.SearchByBuilding_label.AutoSize = True
        Me.SearchByBuilding_label.Location = New System.Drawing.Point(44, 19)
        Me.SearchByBuilding_label.Name = "SearchByBuilding_label"
        Me.SearchByBuilding_label.Size = New System.Drawing.Size(77, 13)
        Me.SearchByBuilding_label.TabIndex = 11
        Me.SearchByBuilding_label.Text = "Select Building"
        '
        'Days_label
        '
        Me.Days_label.AutoSize = True
        Me.Days_label.Location = New System.Drawing.Point(166, 19)
        Me.Days_label.Name = "Days_label"
        Me.Days_label.Size = New System.Drawing.Size(69, 13)
        Me.Days_label.TabIndex = 12
        Me.Days_label.Text = "Filter By: Day"
        '
        'Days_ComboBox
        '
        Me.Days_ComboBox.FormattingEnabled = True
        Me.Days_ComboBox.Items.AddRange(New Object() {"Any", "M", "T", "W", "R", "F"})
        Me.Days_ComboBox.Location = New System.Drawing.Point(169, 36)
        Me.Days_ComboBox.Name = "Days_ComboBox"
        Me.Days_ComboBox.Size = New System.Drawing.Size(55, 21)
        Me.Days_ComboBox.TabIndex = 19
        '
        'Submit_Query_button
        '
        Me.Submit_Query_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit_Query_button.Location = New System.Drawing.Point(135, 72)
        Me.Submit_Query_button.Name = "Submit_Query_button"
        Me.Submit_Query_button.Size = New System.Drawing.Size(137, 33)
        Me.Submit_Query_button.TabIndex = 20
        Me.Submit_Query_button.Text = "Search By Building"
        Me.Submit_Query_button.UseVisualStyleBackColor = True
        '
        'HR_NumericUpDown
        '
        Me.HR_NumericUpDown.Location = New System.Drawing.Point(245, 37)
        Me.HR_NumericUpDown.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.HR_NumericUpDown.Name = "HR_NumericUpDown"
        Me.HR_NumericUpDown.Size = New System.Drawing.Size(36, 20)
        Me.HR_NumericUpDown.TabIndex = 22
        '
        'HR_label
        '
        Me.HR_label.AutoSize = True
        Me.HR_label.Location = New System.Drawing.Point(247, 21)
        Me.HR_label.Name = "HR_label"
        Me.HR_label.Size = New System.Drawing.Size(23, 13)
        Me.HR_label.TabIndex = 23
        Me.HR_label.Text = "HR"
        '
        'MIN_label
        '
        Me.MIN_label.AutoSize = True
        Me.MIN_label.Location = New System.Drawing.Point(287, 21)
        Me.MIN_label.Name = "MIN_label"
        Me.MIN_label.Size = New System.Drawing.Size(27, 13)
        Me.MIN_label.TabIndex = 24
        Me.MIN_label.Text = "MIN"
        '
        'MIN_NumericUpDown
        '
        Me.MIN_NumericUpDown.Location = New System.Drawing.Point(287, 37)
        Me.MIN_NumericUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MIN_NumericUpDown.Name = "MIN_NumericUpDown"
        Me.MIN_NumericUpDown.Size = New System.Drawing.Size(37, 20)
        Me.MIN_NumericUpDown.TabIndex = 25
        '
        'Or_label
        '
        Me.Or_label.AutoSize = True
        Me.Or_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Or_label.Location = New System.Drawing.Point(186, 118)
        Me.Or_label.Name = "Or_label"
        Me.Or_label.Size = New System.Drawing.Size(28, 20)
        Me.Or_label.TabIndex = 26
        Me.Or_label.Text = "Or"
        '
        'Search_by_code_label
        '
        Me.Search_by_code_label.AutoSize = True
        Me.Search_by_code_label.Location = New System.Drawing.Point(109, 148)
        Me.Search_by_code_label.Name = "Search_by_code_label"
        Me.Search_by_code_label.Size = New System.Drawing.Size(68, 13)
        Me.Search_by_code_label.TabIndex = 27
        Me.Search_by_code_label.Text = "Course Code"
        '
        'Section_label
        '
        Me.Section_label.AutoSize = True
        Me.Section_label.Location = New System.Drawing.Point(219, 148)
        Me.Section_label.Name = "Section_label"
        Me.Section_label.Size = New System.Drawing.Size(95, 13)
        Me.Section_label.TabIndex = 29
        Me.Section_label.Text = "Section (Required)"
        '
        'Query_By_Code_button
        '
        Me.Query_By_Code_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Query_By_Code_button.Location = New System.Drawing.Point(125, 203)
        Me.Query_By_Code_button.Name = "Query_By_Code_button"
        Me.Query_By_Code_button.Size = New System.Drawing.Size(161, 35)
        Me.Query_By_Code_button.TabIndex = 31
        Me.Query_By_Code_button.Text = "Search By Code && Section"
        Me.Query_By_Code_button.UseVisualStyleBackColor = True
        '
        'CourseCode_textBox
        '
        Me.CourseCode_textBox.Location = New System.Drawing.Point(99, 164)
        Me.CourseCode_textBox.Name = "CourseCode_textBox"
        Me.CourseCode_textBox.Size = New System.Drawing.Size(100, 20)
        Me.CourseCode_textBox.TabIndex = 32
        '
        'Section_textBox
        '
        Me.Section_textBox.Location = New System.Drawing.Point(214, 164)
        Me.Section_textBox.Name = "Section_textBox"
        Me.Section_textBox.Size = New System.Drawing.Size(100, 20)
        Me.Section_textBox.TabIndex = 33
        '
        'Query_panel
        '
        Me.Query_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Query_panel.Controls.Add(Me.Label1)
        Me.Query_panel.Controls.Add(Me.AM_PM_comboBox)
        Me.Query_panel.Controls.Add(Me.Building_comboBox)
        Me.Query_panel.Controls.Add(Me.MIN_label)
        Me.Query_panel.Controls.Add(Me.MIN_NumericUpDown)
        Me.Query_panel.Controls.Add(Me.Section_textBox)
        Me.Query_panel.Controls.Add(Me.Days_label)
        Me.Query_panel.Controls.Add(Me.Or_label)
        Me.Query_panel.Controls.Add(Me.Section_label)
        Me.Query_panel.Controls.Add(Me.HR_NumericUpDown)
        Me.Query_panel.Controls.Add(Me.HR_label)
        Me.Query_panel.Controls.Add(Me.CourseCode_textBox)
        Me.Query_panel.Controls.Add(Me.Search_by_code_label)
        Me.Query_panel.Controls.Add(Me.SearchByBuilding_label)
        Me.Query_panel.Controls.Add(Me.Days_ComboBox)
        Me.Query_panel.Controls.Add(Me.Submit_Query_button)
        Me.Query_panel.Controls.Add(Me.Query_By_Code_button)
        Me.Query_panel.Location = New System.Drawing.Point(468, 12)
        Me.Query_panel.Name = "Query_panel"
        Me.Query_panel.Size = New System.Drawing.Size(425, 325)
        Me.Query_panel.TabIndex = 34
        '
        'AM_PM_comboBox
        '
        Me.AM_PM_comboBox.FormattingEnabled = True
        Me.AM_PM_comboBox.Items.AddRange(New Object() {"AM", "PM"})
        Me.AM_PM_comboBox.Location = New System.Drawing.Point(330, 37)
        Me.AM_PM_comboBox.Name = "AM_PM_comboBox"
        Me.AM_PM_comboBox.Size = New System.Drawing.Size(41, 21)
        Me.AM_PM_comboBox.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "&&"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.CourseList_UpDown)
        Me.Controls.Add(Me.Course_Info_label)
        Me.Controls.Add(Me.Close_Info_button)
        Me.Controls.Add(Me.Howard_label)
        Me.Controls.Add(Me.Arnold_label)
        Me.Controls.Add(Me.Illges_label)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CCT_label)
        Me.Controls.Add(Me.Map_PictureBox)
        Me.Controls.Add(Me.Query_panel)
        Me.Name = "Form1"
        Me.Text = "Classroom Locator"
        CType(Me.Map_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Closeup_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseList_UpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HR_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MIN_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Query_panel.ResumeLayout(False)
        Me.Query_panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Map_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CCT_label As System.Windows.Forms.Label
    Friend WithEvents Building_Info_label As System.Windows.Forms.Label
    Friend WithEvents Closeup_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Building_Name_label As System.Windows.Forms.Label
    Friend WithEvents Illges_label As System.Windows.Forms.Label
    Friend WithEvents Arnold_label As System.Windows.Forms.Label
    Friend WithEvents Howard_label As System.Windows.Forms.Label
    Friend WithEvents Close_button As System.Windows.Forms.Button
    Friend WithEvents Building_comboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Course_Info_label As System.Windows.Forms.Label
    Friend WithEvents CourseList_UpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Close_Info_button As System.Windows.Forms.Button
    Friend WithEvents SearchByBuilding_label As System.Windows.Forms.Label
    Friend WithEvents Days_label As System.Windows.Forms.Label
    Friend WithEvents Days_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Submit_Query_button As System.Windows.Forms.Button
    Friend WithEvents HR_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents HR_label As System.Windows.Forms.Label
    Friend WithEvents MIN_label As System.Windows.Forms.Label
    Friend WithEvents MIN_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Or_label As System.Windows.Forms.Label
    Friend WithEvents Search_by_code_label As System.Windows.Forms.Label
    Friend WithEvents Section_label As System.Windows.Forms.Label
    Friend WithEvents Query_By_Code_button As System.Windows.Forms.Button
    Friend WithEvents CourseCode_textBox As System.Windows.Forms.TextBox
    Friend WithEvents Section_textBox As System.Windows.Forms.TextBox
    Friend WithEvents Query_panel As System.Windows.Forms.Panel
    Friend WithEvents AM_PM_comboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
