Public Class Form1
    Const WeeklyBasePay As Double = 2500
    Const Quota As Double = 1000
    Const CommissionRate As Double = 0.15

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ListBox1.Items.Clear() ' Clear previous results

        For i As Integer = 1 To 10 ' Loop for ten salespersons
            ' Get input values from TextBoxes
            Dim name As String = NameTextBox.Text
            Dim dailySales As Double = CDbl(DailySalesTextBox.Text)

            ' Calculate weekly sales
            Dim weeklySales As Double = dailySales * 7

            ' Calculate commission if weekly sales exceed quota
            Dim commission As Double = If(weeklySales > Quota, weeklySales * CommissionRate, 0)

            ' Calculate weekly salary (base pay + commission)
            Dim weeklySalary As Double = WeeklyBasePay + commission

            ' Display results in ListBox
            ListBox1.Items.Add(name & ": Daily Sales: " & dailySales & ", Weekly Sales: " & weeklySales & ", Weekly Salary: " & weeklySalary)
        Next
    End Sub


End Class
