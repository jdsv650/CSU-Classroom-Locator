Public Class CourseDetails

    Public Property code As String
    Public Property CRN As Integer
    Public Property section As String
    Public Property title As String
    Public Property hours As Integer
    Public Property term As String
    Public Property startDate As Date
    Public Property endDate As Date
    Public days(7) As Boolean
    Public Property startTime As Date
    Public Property endTime As Date
    Public Property instructor As String
    Public Property building As String
    Public Property roomNumber As Integer

    Public Sub New(c As String, CRN As Integer, sect As String, title As String, hours As Integer,
                   term As String, sDate As Date, eDate As Date, days() As Boolean, sTime As Date,
                   eTime As Date, inst As String, build As String, roomNo As Integer)

        code = c
        Me.CRN = CRN
        section = sect
        Me.title = title
        Me.hours = hours
        Me.term = term
        startDate = sDate
        endDate = eDate
        Me.days(0) = days(0)
        Me.days(1) = days(1)
        Me.days(2) = days(2)
        Me.days(3) = days(3)
        Me.days(4) = days(4)
        Me.days(5) = days(5)
        Me.days(6) = days(6)
        startTime = sTime
        endTime = eTime
        instructor = inst
        building = build
        roomNumber = roomNo

    End Sub

End Class
