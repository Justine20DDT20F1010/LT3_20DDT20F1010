'Name : Justine  Nanggai
'Class : DDT5A
'No Matrik : 20DDT20F1010
'Lab Task : 3
Public Class Dave_Tech
    Private Sub btn_display_Click(sender As Object, e As EventArgs) Handles btn_display.Click
        Dim output As String
        Dim i As Integer

        'declare array
        Dim humidity As Integer()
        Dim phsoil, temperature As String()
        'add value of each element
        humidity = New Integer() {+1%, +2%, +4%, 5%}
        phsoil = New String() {"4.5pH", "5.0pH", "6.5pH", "7.0pH"}
        temperature = New String() {"20celcius", "30celcius", "40celcius", "50celcius"}

        output &= vbTab & "Humidity" & vbTab & "pHSoil" & vbTab & "Temperature" & vbCrLf

        ' display value for 3 array
        For i = 0 To humidity.GetUpperBound(0)
            output &= vbTab & phsoil(i) & vbTab & humidity(i) & vbTab & temperature(i) & vbCrLf

        Next
        display.Text = output

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        SaveFileDialog1.ShowDialog()
    End Sub
End Class