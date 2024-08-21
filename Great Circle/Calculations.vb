Module Calculations
    Public Sub CalcDist() 'Distance between lat/lon points

        dLon = Lon2 - Lon1
        dLat = Lat2 - Lat1

        a = Math.Sin(dLat / 2) ^ 2 + Math.Cos(Lat1) * Math.Cos(Lat2) * Math.Sin(dLon / 2) ^ 2
        c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))

        Dist = R * c

    End Sub

    Public Sub Interpolate()

        For j = 0 To InterNum
            f = j * (1 / InterNum) 'j * 0.1
            Delta = Dist / R
            aa = Math.Sin((1 - f) * Delta) / Math.Sin(Delta)
            bb = Math.Sin(f * Delta) / Math.Sin(Delta)
            x = aa * Math.Cos(Lat1) * Math.Cos(Lon1) + bb * Math.Cos(Lat2) * Math.Cos(Lon2)
            y = aa * Math.Cos(Lat1) * Math.Sin(Lon1) + bb * Math.Cos(Lat2) * Math.Sin(Lon2)
            z = aa * Math.Sin(Lat1) + bb * Math.Sin(Lat2)
            Lat_Interpolate = Math.Atan2(z, Math.Sqrt(x ^ 2 + y ^ 2))
            Lon_Interpolate = Math.Atan2(y, x)
            Lat_Int(j) = Lat_Interpolate * 180 / Math.PI
            Lon_Int(j) = Lon_Interpolate * 180 / Math.PI
        Next

    End Sub

End Module
