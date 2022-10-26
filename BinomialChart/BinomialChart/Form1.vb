Public Class Form1

    Public img As Image
    Public g As Graphics
    Public r As New Random
    Private view As New Rectangle

    Private Sub AbsoluteButton_Click(sender As Object, e As EventArgs) Handles AbsoluteButton.Click
        Dim widthHisto = 170
        Dim widthChart = Chart.Width - widthHisto
        Chart.Image = New Bitmap(Chart.Width, Chart.Height)
        Me.img = Chart.Image
        Me.g = Graphics.FromImage(Me.img)

        Dim sequences As Integer = SequenceNumber.Value
        Dim trials As Integer = TrialsNumber.Value
        Dim successProb As Double = ProbabilityNumber.Value

        Dim minX As Double = 0
        Dim maxX As Double = trials
        Dim minY As Double = 0
        Dim maxY As Double = trials

        Dim histoBrush As New SolidBrush(Color.Orange)
        Dim histoPen As New Pen(Color.Gray)
        Dim recWidth As Double = Chart.Height / sequences
        Dim histoTop = 0
        For i As Integer = 1 To sequences
            Dim pen As New Pen(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)))
            Dim path As New List(Of Point)
            Dim y As Double = 0
            For x As Integer = 1 To trials
                Dim failProb As Double = r.NextDouble
                While failProb = successProb
                    failProb = r.NextDouble
                End While

                If failProb < successProb Then
                    y += 1
                End If
                Dim newX As Integer = ConvertX(x, minX, maxX, widthChart)
                Dim newY As Integer = ConvertY(y, minY, maxY, Chart.Height)
                path.Add(New Point(newX, newY))
            Next
            g.DrawLines(pen, path.ToArray)

            Dim recHeight As Integer = ConvertY(y, minY, maxY, widthHisto)
            g.FillRectangle(histoBrush, New Rectangle(widthChart, histoTop, recHeight, recWidth))
            g.DrawRectangle(histoPen, New Rectangle(widthChart, histoTop, recHeight, recWidth))
            histoTop += recWidth
        Next

    End Sub

    Function ConvertX(x As Double, minX As Double, maxX As Double, w As Integer) As Integer
        If (maxX - minX) = 0 Then
            Return 0
        End If

        Return w * (x - minX) / (maxX - minX)

    End Function

    Function ConvertY(y As Double, minY As Double, maxY As Double, h As Integer) As Integer
        If (maxY - minY) = 0 Then
            Return 0
        End If

        Return h - h * (y - minY) / (maxY - minY)

    End Function

    Private Sub RelativeButton_Click(sender As Object, e As EventArgs) Handles RelativeButton.Click
        Dim widthHisto = 170
        Dim widthChart = Chart.Width - widthHisto
        Chart.Image = New Bitmap(Chart.Width, Chart.Height)
        Me.img = Chart.Image
        Me.g = Graphics.FromImage(Me.img)

        Dim sequences As Integer = SequenceNumber.Value
        Dim trials As Integer = TrialsNumber.Value
        Dim successProb As Double = ProbabilityNumber.Value

        Dim histoBrush As New SolidBrush(Color.Orange)
        Dim histoPen As New Pen(Color.Gray)
        Dim recWidth As Double = Chart.Height / sequences
        Dim histoTop = 0
        For i As Integer = 1 To sequences
            Dim pen As New Pen(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)))
            Dim res As List(Of Integer) = simulate(successProb, trials)
            Dim path As List(Of Point) = createPath(res, trials, widthChart).Item1
            Dim mean As Double = createPath(res, trials, widthChart).Item2
            g.DrawLines(pen, path.ToArray)

            Dim recHeight As Integer = ConvertY(mean, 0, 1, widthHisto)
            g.FillRectangle(histoBrush, New Rectangle(widthChart, histoTop, recHeight, recWidth))
            g.DrawRectangle(histoPen, New Rectangle(widthChart, histoTop, recHeight, recWidth))
            histoTop += recWidth
        Next

    End Sub

    Function simulate(prob As Double, trials As Integer) As List(Of Integer)
        Dim results As New List(Of Integer)()
        For x As Integer = 1 To trials
            Dim failProb As Double = r.NextDouble()
            While failProb = prob
                failProb = r.NextDouble()
            End While
            If failProb < prob Then
                results.Add(1)
            Else
                results.Add(0)
            End If
        Next

        Return results
    End Function

    Function createPath(results As List(Of Integer), trials As Integer, widthChart As Integer) As (List(Of Point), Double)
        Dim minX As Double = 0
        Dim maxX As Double = trials
        Dim minY As Double = 0
        Dim maxY As Double = 1

        Dim path As New List(Of Point)
        Dim mean As Double = 0
        For i As Integer = 1 To trials - 1
            If i = 0 Then
                mean = results(0)
            Else
                mean += (results(i) - mean) / (i + 1)
            End If
            Dim newX As Integer = ConvertX(i + 1, minX, maxX, widthChart)
            Dim newY As Integer = ConvertY(mean, minY, maxY, Chart.Height)
            path.Add(New Point(newX, newY))
        Next
        Console.WriteLine(path)
        Return (path, mean)
    End Function

End Class
