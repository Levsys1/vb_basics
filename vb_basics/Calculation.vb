Public Class Calculation
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim runnerName As String
        Dim runnerEvent As String
        Dim squadNumber As Integer
        Dim time1 As Single
        Dim time2 As Single
        Dim time3 As Single
        Dim average As Single

        runnerName = InputBox("Enter the runners name")
        runnerEvent = InputBox("Enter the Event")
        squadNumber = InputBox("Enter the squad number")

        time1 = Convert.ToSingle(InputBox("Enter the time taken in race 1"))
        time2 = Convert.ToSingle(InputBox("Enter the time taken in race 2"))
        time3 = Convert.ToSingle(InputBox("Enter the time taken in race 3"))

        average = calculate_Average(time1, time2, time3)

        txtDetails.Text = "Name: " & runnerName & vbCrLf & "Number: " & squadNumber & vbCrLf & "Event: " & runnerEvent
        txtAverage.Text = average
    End Sub

    Private Function calculate_Average(time1 As Single, time2 As Single, time3 As Single) As Single
        Dim average As Single
        average = CInt((time1 + time2 + time3) / 3)
        Return average
    End Function
End Class