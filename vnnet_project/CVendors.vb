<Serializable()> Public Class CVenders
    Inherits CollectionBase

    Public Event Dirty(ByVal DataDirty As Boolean)

    Public Function Add(ByVal lobjVen As CVender) As Integer
        Return MyBase.List.Add(lobjVen)
    End Function

    ''' <summary>
    ''' Item property that takes an integer as a key, 
    ''' </summary>
    ''' <param name="Key">Zero based</param>
    Default Public Overridable Property Item(ByVal Key As Integer) As Object
        Get
            Return DirectCast(MyBase.List.Item(Key), Object)
        End Get
        Set(ByVal value As Object)
            MyBase.List.Item(Key) = value
        End Set
    End Property

    Public Sub Remove(ByVal pnID As Integer)
        If MyBase.List.Contains(Item(pnID)) Then
            Dim lobjAxis As CVender = Item(pnID)

            MyBase.List.Remove(lobjAxis)
        End If
    End Sub

    Public Sub GetVendors()
        Add(New CVender("Ackme", "256 S. May", "Oklahoma City", 5675, 9004545, EStates.AZ))
        Add(New CVender("BrickStone", "346 N. Broadway", "Oklahoma City", 344, 3434, EStates.AZ))
        Add(New CVender("FooBar", "3465 E. Dumbar", "Oklahoma City", 3434, 565656, EStates.CO))
        Add(New CVender("MeterCo", "Windcrest Ln.", "Fort Worth", 54545, 54545, EStates.DE))
        Add(New CVender("GramInc", "Creighton Rd.", "Pensacola", 545, 75656, EStates.GA))
        Add(New CVender("LiterLlc", "Montreal Dr.", "Hurst", 4343, 3243434, EStates.ID))
    End Sub

    'Handler of the sub items and class dirty property
    Private Sub HandleDirty(ByVal DataDirty As Boolean)
        RaiseEvent Dirty(DataDirty)
    End Sub
End Class
