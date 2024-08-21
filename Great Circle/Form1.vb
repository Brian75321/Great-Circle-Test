Imports Microsoft.VisualBasic.FileIO

Imports System.Drawing.Text
Imports System.IO
Imports System.Text
Imports System.Reflection

Public Class Form1

    Private TempString1 As String
    Private TempString2 As String
    Private TempString3 As String

    Private AppPath As String

    Private File As System.IO.StreamWriter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumPointsBox.Text = NumSegmentsBox.Text - 1
    End Sub

    Private Sub ReadFlightButton_Click(sender As Object, e As EventArgs) Handles ReadFlightButton.Click
        'Dim File As System.IO.StreamWriter
        'AppPath = "C:\Users\m317386\Desktop\VB.NET\Great Circle"
        AppPath = "C:\Users\brian\OneDrive\Desktop\VB.NET\Great Circle"
        Dim tfp As New TextFieldParser(AppPath + "\INPUT Flight Schedule.csv")
        tfp.Delimiters = New String() {","}
        tfp.TextFieldType = FieldType.Delimited

        Dim Fields = tfp.ReadFields() 'skip header

        FltNum = 0
        While tfp.EndOfData = False
            FltNum = FltNum + 1 ' counts number of flights
            Fields = tfp.ReadFields
            FltNo(FltNum) = Fields(0)
            DepArptID(FltNum) = Fields(1)
            ArrArptID(FltNum) = Fields(2)
            DepArptCode(FltNum) = Fields(3)
            ArrArptCode(FltNum) = Fields(4)
            DepLat(FltNum) = Fields(5)
            DepLon(FltNum) = Fields(6)
            ArrLat(FltNum) = Fields(7)
            ArrLon(FltNum) = Fields(8)
            AcftCode(FltNum) = Fields(9)
        End While

        ReadFlightBox.Text = "Done"
    End Sub

    Private Sub WriteFlightButton_Click(sender As Object, e As EventArgs) Handles WriteFlightButton.Click
        File = My.Computer.FileSystem.OpenTextFileWriter(AppPath + "\OUPUT Flight Schedule.csv", True)
        File.WriteLine("FltNo,DepArptID,ArrArptID,DepArptCode,ArrArptCode,DepLat,DepLon,ArrLat,ArrLon,AfctCode")
        For i = 1 To FltNum
            File.WriteLine(Str(FltNo(i)) + "," + Str(DepArptID(i)) + "," + Str(ArrArptID(i)) _
                + "," + DepArptCode(i) + "," + ArrArptCode(i) _
                + "," + Str(DepLat(i)) + "," + Str(DepLon(i)) _
                + "," + Str(ArrLat(i)) + "," + Str(ArrLon(i)) + "," + AcftCode(i))
        Next
        File.Close()

        WriteFlightBox.Text = "Done"
    End Sub

    Private Sub NumSegmentsBox_TextChanged(sender As Object, e As EventArgs) Handles NumSegmentsBox.TextChanged
        NumPointsBox.Text = Val(NumSegmentsBox.Text) - 1
    End Sub
    Private Sub GCDistanceButton_Click(sender As Object, e As EventArgs) Handles GCDistanceButton.Click

        For i = 1 To FltNum

            Lat1 = DepLat(i) * Math.PI / 180
            Lon1 = DepLon(i) * Math.PI / 180
            Lat2 = ArrLat(i) * Math.PI / 180
            Lon2 = ArrLon(i) * Math.PI / 180

            Call CalcDist()
            FltDist(i) = Dist
        Next

        File = My.Computer.FileSystem.OpenTextFileWriter(AppPath + "\OUTPUT Flight Distance.csv", True)
        File.WriteLine("FltNo,Distance (km)")
        For i = 1 To FltNum
            File.WriteLine(Str(FltNo(i)) + "," + Str(FltDist(i)))
        Next
        File.Close()

        CalcDistBox.Text = "Done"

    End Sub

    Private Sub GCInterpolateButton_Click(sender As Object, e As EventArgs) Handles GCInterpolateButton.Click

        For i = 1 To FltNum ' number of flights (e.g., 3)

            Dist = FltDist(i)
            Lat1 = DepLat(i) * Math.PI / 180
            Lon1 = DepLon(i) * Math.PI / 180
            Lat2 = ArrLat(i) * Math.PI / 180
            Lon2 = ArrLon(i) * Math.PI / 180

            InterNum = NumSegmentsBox.Text ' number of segments between origin and destination airport

            Call Interpolate()

            For j = 0 To InterNum
                Flt_Lat_Int(i, j) = Lat_Int(j)
                Flt_Lon_Int(i, j) = Lon_Int(j)
            Next

        Next

        File = My.Computer.FileSystem.OpenTextFileWriter(AppPath + "\OUTPUT Interpolate.csv", True)
        File.WriteLine("FltNo,Lat,Lon")
        For i = 1 To FltNum
            For j = 0 To InterNum
                File.WriteLine(Str(FltNo(i)) + "," + Str(Flt_Lat_Int(i, j)) + "," + Str(Flt_Lon_Int(i, j)))
            Next
        Next
        File.Close()

        InterBox.Text = "Done"

    End Sub

    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click

        'Lat1 = 38.9530231966979
        'Lon1 = -77.4482682963817
        'Lat2 = 51.4681116754958
        'Lon2 = -0.455072460197157

        Lat1 = 33.9439503818641
        Lon1 = -118.409114332055
        Lat2 = 33.6363550212096
        Lon2 = -84.4293978608999

        'Lat1 = 35.5495764843148
        'Lon1 = 139.77987078334
        'Lat2 = 49.0080074615522
        'Lon2 = 2.55072858201879

        Lat1 = Lat1 * Math.PI / 180
        Lon1 = Lon1 * Math.PI / 180
        Lat2 = Lat2 * Math.PI / 180
        Lon2 = Lon2 * Math.PI / 180

        dLon = Lon2 - Lon1
        dLat = Lat2 - Lat1

        a = Math.Sin(dLat / 2) ^ 2 + Math.Cos(Lat1) * Math.Cos(Lat2) * Math.Sin(dLon / 2) ^ 2
        c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))

        Dist = R * c

        '*******
        f = 1 'Fraction along complete track
        '*******

        Delta = Dist / R
        aa = Math.Sin((1 - f) * Delta) / Math.Sin(Delta)
        bb = Math.Sin(f * Delta) / Math.Sin(Delta)
        x = aa * Math.Cos(Lat1) * Math.Cos(Lon1) + bb * Math.Cos(Lat2) * Math.Cos(Lon2)
        y = aa * Math.Cos(Lat1) * Math.Sin(Lon1) + bb * Math.Cos(Lat2) * Math.Sin(Lon2)
        z = aa * Math.Sin(Lat1) + bb * Math.Sin(Lat2)
        Lat_Interpolate = Math.Atan2(z, Math.Sqrt(x ^ 2 + y ^ 2)) * 180 / Math.PI
        Lon_Interpolate = Math.Atan2(y, x) * 180 / Math.PI

        ResultsLat1.Text = Lat_Interpolate
        ResultsLon1.Text = Lon_Interpolate



    End Sub

End Class
