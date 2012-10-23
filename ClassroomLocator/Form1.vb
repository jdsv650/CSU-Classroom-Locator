Public Class Form1

    Dim courses As New CourseList
    Dim coursesInBuilding As New CourseList
    Dim coursesByCode As New CourseList
    'starts with Sunday as first day of week and search on all days
    Dim searchDays() As Boolean = {True, True, True, True, True, True, True}
    Dim currentBuilding As String = "No Selection"
    Dim isByBuilding As Boolean


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' initialization
        Panel1.Visible = False 'Panel1 is CloseUp Panel

        CCT_label.Parent = Map_PictureBox
        CCT_label.BackColor = Color.Transparent

        Illges_label.Parent = Map_PictureBox
        Illges_label.BackColor = Color.Transparent

        Arnold_label.Parent = Map_PictureBox
        Arnold_label.BackColor = Color.Transparent

        Howard_label.Parent = Map_PictureBox
        Howard_label.BackColor = Color.Transparent

        Close_Info_button.Visible = False

        Days_ComboBox.SelectedIndex = 0
        Building_comboBox.SelectedIndex = 0

        DeselectAll()
        Query_panel.Visible = True
        AM_PM_comboBox.SelectedIndex = 0

    End Sub


    Private Sub All_Labels_Off()
        CCT_label.ForeColor = Color.Transparent
        CCT_label.Text = " "

        Illges_label.ForeColor = Color.Transparent
        Illges_label.Text = " "

        Arnold_label.ForeColor = Color.Transparent
        Arnold_label.Text = " "

        Howard_label.ForeColor = Color.Transparent
        Howard_label.Text = " "
    End Sub

    Private Sub All_Labels_Invisible()
        CCT_label.Visible = False
        Illges_label.Visible = False
        Arnold_label.Visible = False
        Howard_label.Visible = False
    End Sub

    Private Sub All_Labels_Visible()
        CCT_label.Visible = True
        Illges_label.Visible = True
        Arnold_label.Visible = True
        Howard_label.Visible = True
    End Sub

    Private Sub All_Courses_Display()
        Dim courseInfo As String
        Dim count As Integer
        Dim current As Integer
        Dim daysString As String = ""

        count = courses.courseL.Count 'number of courses found
        If count < 1 Then
            courseInfo = "No matching courses found"
            Return
        End If

        current = CourseList_UpDown.Value
        CourseList_UpDown.Maximum = count
        CourseList_UpDown.Minimum = 1
        CourseList_UpDown.Visible = True

        For i As Integer = 0 To 6
            If courses.courseL.Item(current).days(i) And i = 0 Then
                daysString = daysString & "S"
            ElseIf courses.courseL.Item(current).days(i) And i = 1 Then
                daysString = daysString & "M"
            ElseIf courses.courseL.Item(current).days(i) And i = 2 Then
                daysString = daysString & "T"
            ElseIf courses.courseL.Item(current).days(i) And i = 3 Then
                daysString = daysString & "W"
            ElseIf courses.courseL.Item(current).days(i) And i = 4 Then
                daysString = daysString & "R"
            ElseIf courses.courseL.Item(current).days(i) And i = 5 Then
                daysString = daysString & "F"
            ElseIf courses.courseL.Item(current).days(i) And i = 6 Then
                daysString = daysString & "S"
            End If
        Next i

        'Dim dateTimeInfo As DateTime = DateTime.Now
        'dateTimeInfo.ToString("t")
        'courses.courseL.Item(current).startTime.GetType()

        courseInfo = "Found " & count & " courses" & Environment.NewLine & Environment.NewLine & _
                     "COURSE    " & courses.courseL.Item(current).code() & Environment.NewLine & _
                     "CRN            " & courses.courseL.Item(current).CRN.ToString & Environment.NewLine & _
                     "SECTION    " & courses.courseL.Item(current).section.ToString & Environment.NewLine & _
                     "TITLE          " & courses.courseL.Item(current).title & Environment.NewLine & _
                     "CRED HR   " & courses.courseL.Item(current).hours & Environment.NewLine & _
                     "TERM         " & courses.courseL.Item(current).term & Environment.NewLine & Environment.NewLine & _
                     "START DATE   " & courses.courseL.Item(current).startDate & Environment.NewLine & _
                     "END DATE       " & courses.courseL.Item(current).endDate & Environment.NewLine & _
                     "MEETS ON       " & daysString & Environment.NewLine & _
                     "START TIME    " & courses.courseL.Item(current).startTime & Environment.NewLine & _
                     "END TIME        " & courses.courseL.Item(current).endTime & Environment.NewLine & _
                     "INSTRUCTOR                         " & courses.courseL.Item(current).instructor & Environment.NewLine & _
                     "BUILDING-ROOM NUMBER   " & courses.courseL.Item(current).building & "-" & courses.courseL.Item(current).roomNumber

        Course_Info_label.Text = courseInfo
    End Sub


    Private Sub Build_In_Building_List(building As String)
        Dim found As Boolean
        Dim timeRead As Date

        coursesInBuilding.courseL.Clear()

        For Each item In courses.courseL
            found = False
            If String.Compare(UCase(item.building), UCase(building)) = 0 Then

                If searchDays(1) = True And item.days(1) = True Then
                    found = True  'Unless we use a filter to turn off
                    If Days_ComboBox.SelectedIndex <> 0 And HR_NumericUpDown.Value <> 0 Then
                        timeRead = GetTime12()
                        'DEBUG AM-PM ERROR
                        ' timeRead = #6:00:00 PM#
                        'MessageBox.Show(item.startTime.ToString) 'TimeOfDay()
                        'MessageBox.Show(timeRead.ToString)
                        If item.startTime <= timeRead And timeRead <= item.endTime Then
                            found = True
                        Else
                            found = False
                        End If
                    End If
                End If
                If searchDays(2) = True And item.days(2) = True Then
                    found = True  'Unless we use a filter to turn off
                    If Days_ComboBox.SelectedIndex <> 0 And HR_NumericUpDown.Value <> 0 Then
                        timeRead = GetTime12()
                        If item.startTime <= timeRead And timeRead <= item.endTime Then
                            found = True
                        Else
                            found = False
                        End If
                    End If
                End If
                If searchDays(3) = True And item.days(3) = True Then
                    found = True  'Unless we use a filter to turn off
                    If Days_ComboBox.SelectedIndex <> 0 And HR_NumericUpDown.Value <> 0 Then
                        timeRead = GetTime12()
                        If item.startTime <= timeRead And timeRead <= item.endTime Then
                            found = True
                        Else
                            found = False
                        End If
                    End If
                End If
                If searchDays(4) = True And item.days(4) = True Then
                    found = True  'Unless we use a filter to turn off
                    If Days_ComboBox.SelectedIndex <> 0 And HR_NumericUpDown.Value <> 0 Then
                        timeRead = GetTime12()
                        If item.startTime <= timeRead And timeRead <= item.endTime Then
                            found = True
                        Else
                            found = False
                        End If
                    End If
                    found = True
                End If

                If searchDays(5) = True And item.days(5) = True Then
                    found = True  'Unless we use a filter to turn off
                    If Days_ComboBox.SelectedIndex <> 0 And HR_NumericUpDown.Value <> 0 Then
                        timeRead = GetTime12()
                        If item.startTime <= timeRead And timeRead <= item.endTime Then
                            found = True
                        Else
                            found = False
                        End If
                    End If
                End If

            End If
            If found Then
                coursesInBuilding.courseL.Add(item)
            End If

        Next
    End Sub
    Private Function GetTime12()
        Dim am_pm As String
        Dim hour As String = HR_NumericUpDown.Value.ToString
        Dim min As String = MIN_NumericUpDown.Value.ToString

        If min = "0" Then
            min = "00"
        ElseIf min = "1" Then
            min = "01"
        ElseIf min = "02" Then
            min = "02"
        ElseIf min = "3" Then
            min = "03"
        ElseIf min = "4" Then
            min = "04"
        ElseIf min = "5" Then
            min = "05"
        ElseIf min = "6" Then
            min = "06"
        ElseIf min = "7" Then
            min = "07"
        ElseIf min = "8" Then
            min = "08"
        ElseIf min = "9" Then
            min = "09"
        End If

        If AM_PM_comboBox.SelectedIndex = 0 Then
            am_pm = "AM"
        Else
            am_pm = "PM"
        End If

        ' If hour = "1" Then
        'hour = "01"
        ' ElseIf hour = "2" Then
        'hour = "02"
        'ElseIf hour = "3" Then
        'hour = "03"
        'ElseIf hour = "4" Then
        ' hour = "04"
        ' ElseIf hour = "5" Then
        ' hour = "05"
        ' ElseIf hour = "6" Then
        ' hour = "06"
        ' ElseIf hour = "7" Then
        ' hour = "07"
        ' ElseIf hour = "8" Then
        ' hour = "08"
        ' ElseIf hour = "9" Then
        ' hour = "09"
        ' End If

        Return "#" & hour & ":" & min & ":00" & " " & am_pm & "#"

    End Function


    Private Sub Build_By_Code_List(cCode As String, cSec As String)

        coursesByCode.courseL.Clear()

        For Each item In courses.courseL
            If String.Compare(UCase(item.code), UCase(cCode)) = 0 Then
                If String.Compare(UCase(item.section), UCase(cSec)) = 0 Then
                    coursesByCode.courseL.Add(item)
                End If
            End If
        Next
    End Sub


    Private Sub All_Courses_In_Building_Display()
        Dim courseInfo As String
        Dim count As Integer
        Dim current As Integer
        Dim daysString As String = ""

        count = coursesInBuilding.courseL.Count 'number of courses found in building

        ' don't assign count < 1 to updown
        If count < 1 Then
            courseInfo = "No matching courses found"
            Course_Info_label.Text = courseInfo
            Return
        End If

        current = CourseList_UpDown.Value
        CourseList_UpDown.Visible = True
        CourseList_UpDown.Maximum = count
        CourseList_UpDown.Minimum = 1

       
        For i As Integer = 1 To 5
            If coursesInBuilding.courseL.Item(current).days(i) And i = 1 Then
                daysString = daysString & "M"
            ElseIf coursesInBuilding.courseL.Item(current).days(i) And i = 2 Then
                daysString = daysString & "T"
            ElseIf coursesInBuilding.courseL.Item(current).days(i) And i = 3 Then
                daysString = daysString & "W"
            ElseIf coursesInBuilding.courseL.Item(current).days(i) And i = 4 Then
                daysString = daysString & "R"
            ElseIf coursesInBuilding.courseL.Item(current).days(i) And i = 5 Then
                daysString = daysString & "F"
            End If
        Next i

        'Dim dateTimeInfo As DateTime = DateTime.Now
        'dateTimeInfo.ToString("t")
        'courses.courseL.Item(current).startTime.GetType()

        courseInfo = "Found " & count & " courses" & Environment.NewLine & Environment.NewLine & _
                     "COURSE    " & coursesInBuilding.courseL.Item(current).code() & Environment.NewLine & _
                     "CRN            " & coursesInBuilding.courseL.Item(current).CRN.ToString & Environment.NewLine & _
                     "SECTION    " & coursesInBuilding.courseL.Item(current).section & Environment.NewLine & _
                     "TITLE          " & coursesInBuilding.courseL.Item(current).title & Environment.NewLine & _
                     "CRED HR   " & coursesInBuilding.courseL.Item(current).hours & Environment.NewLine & _
                     "TERM         " & coursesInBuilding.courseL.Item(current).term & Environment.NewLine & Environment.NewLine & _
                     "START DATE   " & coursesInBuilding.courseL.Item(current).startDate & Environment.NewLine & _
                     "END DATE       " & coursesInBuilding.courseL.Item(current).endDate & Environment.NewLine & _
                     "MEETS ON       " & daysString & Environment.NewLine & _
                     "START TIME    " & coursesInBuilding.courseL.Item(current).startTime & Environment.NewLine & _
                     "END TIME        " & coursesInBuilding.courseL.Item(current).endTime & Environment.NewLine & _
                     "INSTRUCTOR                         " & coursesInBuilding.courseL.Item(current).instructor & Environment.NewLine & _
                     "BUILDING-ROOM NUMBER   " & coursesInBuilding.courseL.Item(current).building & "-" & coursesInBuilding.courseL.Item(current).roomNumber

        Course_Info_label.Visible = True
        Course_Info_label.Text = courseInfo
    End Sub

    Private Sub All_Courses_By_Code_Display(sender As System.Object, e As System.EventArgs)
        Dim courseInfo As String
        Dim count As Integer
        Dim current As Integer
        Dim daysString As String = ""

        count = coursesByCode.courseL.Count 'number of courses found in building

        ' don't assign count < 1 to updown
        If count < 1 Then
            courseInfo = "No matching courses found"
            Course_Info_label.Text = courseInfo
            Return
        End If

        'current = CourseList_UpDown.Value
        current = 1
        CourseList_UpDown.Visible = False
        CourseList_UpDown.Maximum = 1
        'CourseList_UpDown.Minimum = 1

        If coursesByCode.courseL.Item(current).building = "CCT" Then
            'CCT_label_Click(sender, e)
            LoadCCT()
        ElseIf coursesByCode.courseL.Item(current).building = "Illges Hall" Then
            'Illges_label_Click(sender, e)
            LoadIllges()
        ElseIf coursesByCode.courseL.Item(current).building = "Arnold Hall" Then
            ' Arnold_label_Click(sender, e)
            LoadArnold()
        ElseIf coursesByCode.courseL.Item(current).building = "Howard" Then
            'Howard_label_Click(sender, e)
            LoadHoward()
        End If

        For i As Integer = 1 To 5
            If coursesByCode.courseL.Item(current).days(i) And i = 1 Then
                daysString = daysString & "M"
            ElseIf coursesByCode.courseL.Item(current).days(i) And i = 2 Then
                daysString = daysString & "T"
            ElseIf coursesByCode.courseL.Item(current).days(i) And i = 3 Then
                daysString = daysString & "W"
            ElseIf coursesByCode.courseL.Item(current).days(i) And i = 4 Then
                daysString = daysString & "R"
            ElseIf coursesByCode.courseL.Item(current).days(i) And i = 5 Then
                daysString = daysString & "F"
            End If
        Next i

        'Dim dateTimeInfo As DateTime = DateTime.Now
        'dateTimeInfo.ToString("t")
        'courses.courseL.Item(current).startTime.GetType()

        courseInfo = "Found " & count & " courses" & Environment.NewLine & Environment.NewLine & _
                     "COURSE    " & coursesByCode.courseL.Item(current).code() & Environment.NewLine & _
                     "CRN            " & coursesByCode.courseL.Item(current).CRN.ToString & Environment.NewLine & _
                     "SECTION    " & coursesByCode.courseL.Item(current).section & Environment.NewLine & _
                     "TITLE          " & coursesByCode.courseL.Item(current).title & Environment.NewLine & _
                     "CRED HR   " & coursesByCode.courseL.Item(current).hours & Environment.NewLine & _
                     "TERM         " & coursesByCode.courseL.Item(current).term & Environment.NewLine & Environment.NewLine & _
                     "START DATE   " & coursesByCode.courseL.Item(current).startDate & Environment.NewLine & _
                     "END DATE       " & coursesByCode.courseL.Item(current).endDate & Environment.NewLine & _
                     "MEETS ON       " & daysString & Environment.NewLine & _
                     "START TIME    " & coursesByCode.courseL.Item(current).startTime & Environment.NewLine & _
                     "END TIME        " & coursesByCode.courseL.Item(current).endTime & Environment.NewLine & _
                     "INSTRUCTOR                         " & coursesByCode.courseL.Item(current).instructor & Environment.NewLine & _
                     "BUILDING-ROOM NUMBER   " & coursesByCode.courseL.Item(current).building & "-" & coursesByCode.courseL.Item(current).roomNumber


        Course_Info_label.Text = courseInfo

    End Sub
    Private Sub DeselectAll()
        

        Panel1.Visible = False
        'All_Labels_Invisible()
        currentBuilding = ""

        CCT_label.ForeColor = Color.Transparent
        CCT_label.Text = " "
        Illges_label.ForeColor = Color.Transparent
        Illges_label.Text = " "
        Arnold_label.ForeColor = Color.Transparent
        Arnold_label.Text = " "
        Howard_label.ForeColor = Color.Transparent
        Howard_label.Text = " "

        Building_Name_label.Text = ""
        Building_Info_label.Text = ""
        Closeup_PictureBox.Visible = False
        Course_Info_label.Visible = False
    End Sub



    Private Sub CCT_label_Click(sender As System.Object, e As System.EventArgs) Handles CCT_label.Click
        All_Labels_Off()

        If CCT_label.Text = " " Then

            isByBuilding = True
            LoadCCT()
            Build_In_Building_List("CCT")
            All_Courses_In_Building_Display()
            currentBuilding = "CCT"

        Else ' CCT_label = 'X'  (is preselected)
            CCT_label.ForeColor = Color.Transparent
            CCT_label.Text = " "

            Panel1.Visible = False
            All_Labels_Invisible()
            currentBuilding = ""
            Building_Name_label.Text = ""
            Building_Info_label.Text = ""
            Closeup_PictureBox.Visible = False
            Course_Info_label.Visible = False

        End If
    End Sub

    Private Sub LoadCCT()
        Query_panel.Visible = False
        'keep drop down in sync
        Building_comboBox.SelectedIndex = 1
        'Days_ComboBox.SelectedIndex = 0
        CourseList_UpDown.Value = 1

        CCT_label.ForeColor = Color.Red
        CCT_label.Text = "X"
        Panel1.Visible = True
        All_Labels_Visible()
        'Course_Info_label.Visible = True

        Building_Name_label.Text = "Center For Commerce and Technology"
        Building_Info_label.Text = "Home to the Turner College of Business" & vbCrLf & "and TSYS Department of Computer Science"

        'Closeup_PictureBox.Image = CType(resources.GetObject("CCTech.png"), System.Drawing.Image)
        Me.Closeup_PictureBox.Image = Global.ClassroomLocator.My.Resources.Resources.CCTech

        Building_Name_label.Visible = True
        Building_Info_label.Visible = True
        Closeup_PictureBox.Visible = True
        'Course_Info_label.Visible = True
        Close_Info_button.Visible = True

    End Sub



    Private Sub Illges_label_Click(sender As System.Object, e As System.EventArgs) Handles Illges_label.Click
        All_Labels_Off()

        If Illges_label.Text = " " Then
            
            isByBuilding = True
            LoadIllges()
            Build_In_Building_List("Illges Hall")
            All_Courses_In_Building_Display()

            currentBuilding = "Illges Hall"

        Else ' .Text = "X"

            Illges_label.ForeColor = Color.Transparent
            Illges_label.Text = " "

            Panel1.Visible = False
            All_Labels_Invisible()
            currentBuilding = ""

            Building_Name_label.Text = ""
            Building_Info_label.Text = ""
            Closeup_PictureBox.Visible = False
            Course_Info_label.Visible = False

        End If
    End Sub
    Private Sub LoadIllges()
        Query_panel.Visible = False
        'keep drop down in sync
        Building_comboBox.SelectedIndex = 2
        ' Days_ComboBox.SelectedIndex = 0
        CourseList_UpDown.Value = 1

        Panel1.Visible = True
        All_Labels_Visible()
        ' Course_Info_label.Visible = True

        Building_Name_label.Text = "Illges Hall"
        Building_Info_label.Text = "Home to the Nursing School"
        'Closeup_PictureBox.Image = CType(Resources.GetObject("Illges"), System.Drawing.Image)
        Me.Closeup_PictureBox.Image = Global.ClassroomLocator.My.Resources.Resources.Illges

        Building_Name_label.Visible = True
        Building_Info_label.Visible = True
        Closeup_PictureBox.Visible = True

        Illges_label.Visible = True
        Illges_label.ForeColor = Color.Red
        Illges_label.Text = "X"
        Close_Info_button.Visible = True
        ' Course_Info_label.Visible = False

    End Sub

    Private Sub Arnold_label_Click(sender As System.Object, e As System.EventArgs) Handles Arnold_label.Click
        All_Labels_Off()

        If Arnold_label.Text = " " Then
            isByBuilding = True  
            LoadArnold()
            Build_In_Building_List("Arnold Hall")
            All_Courses_In_Building_Display()
            currentBuilding = "Arnold Hall"

        Else ' .Text = "X"
            Arnold_label.ForeColor = Color.Transparent
            Arnold_label.Text = " "

            Panel1.Visible = False
            All_Labels_Invisible()
            currentBuilding = ""

            Building_Name_label.Text = ""
            Building_Info_label.Text = ""
            Closeup_PictureBox.Visible = False
            Course_Info_label.Visible = False
        End If
    End Sub
    Private Sub LoadArnold()
        Query_panel.Visible = False
        'keep drop down in sync
        Building_comboBox.SelectedIndex = 3
        ' Days_ComboBox.SelectedIndex = 0
        CourseList_UpDown.Value = 1

        Panel1.Visible = True
        All_Labels_Visible()
        ' Course_Info_label.Visible = True

        Building_Name_label.Text = "Arnold Hall"
        Building_Info_label.Text = "CSU's Social Research Center"
        'Closeup_PictureBox.Image = CType(Resources.GetObject("Arnold"), System.Drawing.Image)
        Me.Closeup_PictureBox.Image = Global.ClassroomLocator.My.Resources.Resources.Arnold

        Building_Name_label.Visible = True
        Building_Info_label.Visible = True
        Closeup_PictureBox.Visible = True

        Arnold_label.Visible = True
        Arnold_label.ForeColor = Color.Red
        Arnold_label.Text = "X"

        ' Course_Info_label.Visible = False
        Close_Info_button.Visible = True
    End Sub


    Private Sub Howard_label_Click(sender As System.Object, e As System.EventArgs) Handles Howard_label.Click
        All_Labels_Off()

        If Howard_label.Text = " " Then
           
            isByBuilding = True  
            LoadHoward()
            Build_In_Building_List("Howard Hall")
            All_Courses_In_Building_Display()
            currentBuilding = "Howard Hall"

        Else ' .Text = "X"
            Howard_label.ForeColor = Color.Transparent
            Howard_label.Text = " "

            Panel1.Visible = False
            All_Labels_Invisible()
            currentBuilding = ""

            Building_Name_label.Text = ""
            Building_Info_label.Text = ""
            Closeup_PictureBox.Visible = False
            Course_Info_label.Visible = False
        End If
    End Sub

    Private Sub LoadHoward()
        Query_panel.Visible = False
        'keep drop down in sync
        Building_comboBox.SelectedIndex = 4
        'Days_ComboBox.SelectedIndex = 0
        CourseList_UpDown.Value = 1

        Panel1.Visible = True
        All_Labels_Visible()
        'Course_Info_label.Visible = True

        Building_Name_label.Text = "Howard Hall"
        Building_Info_label.Text = "Houses the Adult Learning Resource Center"
        'Closeup_PictureBox.Image = CType(Resources.GetObject("Howard"), System.Drawing.Image)
        Me.Closeup_PictureBox.Image = Global.ClassroomLocator.My.Resources.Resources.Howard

        Building_Name_label.Visible = True
        Building_Info_label.Visible = True
        Closeup_PictureBox.Visible = True

        Howard_label.Visible = True
        Howard_label.ForeColor = Color.Red
        Howard_label.Text = "X"
        Close_Info_button.Visible = True
        'Course_Info_label.Visible = False

    End Sub


    Private Sub Close_button_Click(sender As System.Object, e As System.EventArgs) Handles Close_button.Click
        Panel1.Visible = False
    End Sub

    Private Sub Building_comboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Building_comboBox.SelectedIndexChanged
        Dim index As Integer = Building_comboBox.SelectedIndex

        Course_Info_label.Visible = False

    End Sub

    Private Sub CourseList_UpDown_ValueChanged(sender As System.Object, e As System.EventArgs) Handles CourseList_UpDown.ValueChanged
        If isByBuilding Then
            All_Courses_In_Building_Display()
        Else
            All_Courses_By_Code_Display(sender, e)
        End If
    End Sub

    Private Sub Building_comboBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Building_comboBox.TextChanged
        ' Course_Info_label.Text = ""
    End Sub

    Private Sub Building_comboBox_TextUpdate(sender As System.Object, e As System.EventArgs) Handles Building_comboBox.TextUpdate
        ' Course_Info_label.Text = ""
    End Sub

    Private Sub Close_Info_button_Click(sender As System.Object, e As System.EventArgs) Handles Close_Info_button.Click
        Query_panel.Visible = True
        Course_Info_label.Visible = False
        CourseList_UpDown.Visible = False
        Close_Info_button.Visible = False
        ResetByCodeText()
        Building_comboBox.SelectedIndex = 0
        Days_ComboBox.SelectedIndex = 0
        HR_NumericUpDown.Value = 0
        MIN_NumericUpDown.Value = 0
        AM_PM_comboBox.SelectedIndex = 0
        DeselectAll()
        ' coursesInBuilding.courseL.Clear()
        ' coursesByCode.courseL.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Days_ComboBox.SelectedIndexChanged
        Dim index As Integer = Days_ComboBox.SelectedIndex

        searchDays = {False, False, False, False, False, False, False}

        If index = 0 Then
            searchDays = {True, True, True, True, True, True, True}
        ElseIf index = 1 Then
            searchDays(1) = True
        ElseIf index = 2 Then
            searchDays(2) = True
        ElseIf index = 3 Then
            searchDays(3) = True
        ElseIf index = 4 Then
            searchDays(4) = True
        ElseIf index = 5 Then
            searchDays(5) = True
        End If
    End Sub


    Private Sub Submit_Query_button_Click(sender As System.Object, e As System.EventArgs) Handles Submit_Query_button.Click
        Dim index As Integer = Building_comboBox.SelectedIndex

        If Building_comboBox.SelectedIndex = 0 Then
            Return
        End If

        Query_panel.Visible = False
        isByBuilding = True
        coursesInBuilding.courseL.Clear()
        CourseList_UpDown.Value = 1

        Panel1.Visible = True
        All_Labels_Visible()

        If index = 1 Then
            Build_In_Building_List("CCT")
            currentBuilding = "CCT"
            '  All_Courses_In_Building_Display()
            Close_Info_button.Visible = True
            CCT_label_Click(sender, e)
            Course_Info_label.Visible = True
        ElseIf index = 2 Then
            Build_In_Building_List("Illges Hall")
            currentBuilding = "Illges Hall"
            ' All_Courses_In_Building_Display()
            Close_Info_button.Visible = True
            Illges_label_Click(sender, e)
            Course_Info_label.Visible = True
        ElseIf index = 3 Then
            Build_In_Building_List("Arnold Hall")
            currentBuilding = "Arnold Hall"
            ' All_Courses_In_Building_Display()
            Close_Info_button.Visible = True
            Arnold_label_Click(sender, e)
            Course_Info_label.Visible = True
        ElseIf index = 4 Then
            Build_In_Building_List("Howard Hall")
            currentBuilding = "Howard Hall"
            ' All_Courses_In_Building_Display()
            Close_Info_button.Visible = True
            ' next 2 items must be in this order
            Howard_label_Click(sender, e)
            Course_Info_label.Visible = True
        End If
    End Sub

    Private Sub HR_NumericUpDown_ValueChanged(sender As System.Object, e As System.EventArgs) Handles HR_NumericUpDown.ValueChanged
        ' UpDown for Hour 0-23
    End Sub

    Private Sub MIN_NumericUpDown_ValueChanged(sender As System.Object, e As System.EventArgs) Handles MIN_NumericUpDown.ValueChanged
        ' UpDown for Minute 0-59
    End Sub

    Private Sub CourseCode_textBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CourseCode_textBox.TextChanged
        ' Search by course code
    End Sub

    Private Sub Section_textBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Section_textBox.TextChanged
        ' Filter by section
    End Sub

    Private Sub Query_By_Code_button_Click(sender As System.Object, e As System.EventArgs) Handles Query_By_Code_button.Click
        ' Submit button for query by course code and section  
        Dim cCode, sec As String

        If CourseCode_textBox.Text = "" Or Section_textBox.Text = "" Then
            Return
        End If


        Query_panel.Visible = False
        isByBuilding = False
        CourseList_UpDown.Value = 1
        coursesByCode.courseL.Clear()
        cCode = CourseCode_textBox.Text
        sec = Section_textBox.Text

        Build_By_Code_List(cCode, sec)
        All_Courses_By_Code_Display(sender, e)

        Course_Info_label.Visible = True
        Close_Info_button.Visible = True


    End Sub

    Private Sub ResetByBuildingDropDown()
    End Sub

    Private Sub ResetByCodeText()
        CourseCode_textBox.Text = ""
        Section_textBox.Text = ""
    End Sub

    
    Private Sub AM_PM_comboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles AM_PM_comboBox.SelectedIndexChanged

    End Sub
End Class
