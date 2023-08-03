Public Class LeapYearForm

    ''' <summary>
    ''' Handle the click event and determine Leap Year
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click

        ' variable
        Dim intYear As Integer

        ' Parse the Value of Year textbox
        If Integer.TryParse(txtYear.Text, intYear) Then

            ' Check the value of year, for Leap Year
            If intYear Mod 400 = 0 Or (intYear Mod 4 = 0 And Not intYear Mod 100 = 0) Then
                txtDisplay.Text += intYear.ToString() + vbTab + " Yes" + vbNewLine
            Else
                txtDisplay.Text += intYear.ToString() + vbTab + " No" + vbNewLine
            End If

        Else
            MessageBox.Show("Invalid Year entered")
        End If

    End Sub
End Class
