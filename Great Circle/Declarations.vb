Module Declarations

    Public Const R = 6371

    Public i As Integer
    Public j As Integer

    Public Lat1 As Single
    Public Lat2 As Single
    Public Lon1 As Single
    Public Lon2 As Single
    Public a As Single
    Public c As Single
    Public Dist As Single
    Public dLon As Single
    Public dLat As Single

    Public f As Single
    Public aa As Single
    Public bb As Single
    Public Delta As Single
    Public x As Single
    Public y As Single
    Public z As Single
    Public Lat_Interpolate As Single
    Public Lon_Interpolate As Single

    Public Lat_Int(1000) As Single
    Public Lon_Int(1000) As Single

    Public FltNo(100000) As Integer
    Public DepArptID(100000) As Integer
    Public ArrArptID(100000) As Integer
    Public DepArptCode(100000) As String
    Public ArrArptCode(100000) As String
    Public DepLat(100000) As Single
    Public DepLon(100000) As Single
    Public ArrLat(100000) As Single
    Public ArrLon(100000) As Single
    Public AcftCode(100000) As String
    Public FltNum As Integer

    Public FltDist(100000) As Integer
    Public Flt_Lat_Int(100000, 1000) As Single
    Public Flt_Lon_Int(100000, 1000) As Single

    Public InterNum As Integer

End Module
