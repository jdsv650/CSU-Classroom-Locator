Public Class CourseList

    Public courseL As New Collection()

    'starts with Sunday as first day of week
    Dim days() As Boolean = {False, False, False, False, False, False, False}
    Dim startDate, endDate As Date
    Dim startTime, endTime As Date

    'Dim date1 As Date = #6/1/2008 7:47:00 AM#
    'Console.WriteLine(date1.ToString())

    ' Get date-only portion of date, without its time. 
    'Dim dateOnly As Date = date1.Date
    ' Display date using short date string.
    'Console.WriteLine(dateOnly.ToString("d"))
    ' Display date using 24-hour clock.
    ''Console.WriteLine(dateOnly.ToString("g"))
    'Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"))   
    ' The example displays the following output to the console: 
    '       6/1/2008 7:47:00 AM 
    '       6/1/2008 
    '       6/1/2008 12:00 AM 
    '       06/01/2008 00:00

    Dim cpsc1105 As New CourseDetails("CPSC1105", 82076, "01", "Intro to Information Tech", 3, "Regular", "8/13/2012", "12/04/12",
                                       days, "06:00:00 PM", "07:15:00 PM", "Sadler, D C", "CCT", 201)

    Dim cpsc3131 As New CourseDetails("CPSC3131", 82097, "01", "Database Systems 1", 3, "Regular", "8/13/2012", "12/04/12",
                                       days, "01:30:00 PM", "02:45:00 PM", "Zanev, V S", "CCT", 405)

    Dim cpsc2108 As New CourseDetails("CPSC2108", 85958, "02", "Data Structures", 3, "Regular", "8/13/2012", "12/04/12",
                                            days, "09:30:00 AM", "10:45:00 AM", "Khan, S S", "CCT", 407)

    Dim cpsc2108_2 As New CourseDetails("CPSC2108", 82093, "01", "Data Structures", 3, "Regular", "8/13/2012", "12/04/12",
                                            days, "06:00:00 PM", "07:15:00 PM", "Yang, J", "CCT", 407)

    Dim math0097 As New CourseDetails("MATH0097", 81152, "02", "Developmental Math 1", 4, "LS Reg", "8/13/2012", "12/04/12",
                                    days, "10:20 AM", "11:30 AM", "Casleton, R J", "Arnold Hall", 102)

    Dim math0098 As New CourseDetails("MATH0098", 81166, "05", "Developmental Math 2", 4, "LS Reg", "8/13/2012", "12/04/12",
                                    days, "06:00 PM", "07:45 PM", "Miller, K A", "Howard Hall", 204)

    Dim math0195 As New CourseDetails("MATH0195", 84645, "01", "Prepatory Algebra", 4, "Regular", "8/13/2012", "12/04/12",
                                    days, "08:00 PM", "09:45 PM", "Boling, P M", "Arnold Hall", 103)

    Dim nurs3175 As New CourseDetails("NURS3175", 85574, "02", "Pharmacology in Nursing", 4, "Regular", "8/13/2012", "12/04/12",
                                   days, "08:15 AM", "12:15 PM", "Merriam, M L", "Illges Hall", 318)

    Dim nurs3275 As New CourseDetails("NURS3275", 85571, "02", "Prof Clinical Nursing 1", 8, "Regular", "8/13/2012", "12/04/12",
                                    days, "12:15 PM", "02:15 PM", "Derico, S P", "Illges Hall", 318)

    Dim nurs4111 As New CourseDetails("NURS4111", 81020, "01", "Prof Develop Perspectives 3", 2, "Regular", "8/13/2012", "12/04/12",
                                    days, "12:15 PM", "02:15 PM", "Richter, S L", "Illges Hall", 216)


    Public Sub New()
        BuildList()
    End Sub


    Private Sub BuildList()
        courseL.Add(cpsc1105)
        ' startDate = #8/13/2012#
        ' endDate = #12/4/2012#
        ' cpsc1105.startDate = startDate
        ' cpsc1105.endDate = endDate
        ' startTime = #6:00:00 PM#
        ' endTime = #7:15:00 PM#
        ' cpsc1105.startTime = startTime
        ' cpsc1105.endTime = endTime
        days = {False, True, False, False, False, False, False}
        cpsc1105.days = days

        courseL.Add(cpsc3131)
        days = {False, True, False, True, False, False, False}
        cpsc3131.days = days

        courseL.Add(cpsc2108)
        days = {False, False, True, False, True, False, False}
        cpsc2108.days = days

        courseL.Add(cpsc2108_2)
        days = {False, False, True, False, True, False, False}
        cpsc2108_2.days = days

        courseL.Add(math0097)
        days = {False, True, False, True, False, True, False}
        math0097.days = days

        courseL.Add(math0098)
        days = {False, True, False, True, False, False, False}
        math0098.days = days

        courseL.Add(math0195)
        days = {False, True, False, True, False, False, False}
        math0195.days = days

        courseL.Add(nurs3175)
        days = {False, False, False, False, True, False, False}
        nurs3175.days = days

        courseL.Add(nurs3275)
        days = {False, True, False, False, False, False, False}
        nurs3275.days = days

        courseL.Add(nurs4111)
        days = {False, True, False, False, False, False, False}
        nurs4111.days = days

    End Sub

End Class
