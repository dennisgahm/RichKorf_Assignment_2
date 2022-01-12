Public Class _8Puzzle

    '0-8

    '0 1 2
    '3 4 5
    '6 7 8
    Public blankLocation As Integer
    Dim moveToGetHere As Move = Move.None
    'Dim childrenBoards As New List(Of _8Puzzle)
    Public Enum Move
        Left = 0
        Up = 1
        Right = 2
        Down = 3
        None = -1
    End Enum

    Public Sub New()
        'place blank at center of board
        blankLocation = 4
    End Sub

    'New board with parentBoard as board
    Public Sub New(board As _8Puzzle)
        blankLocation = board.blankLocation
    End Sub

    Public Function MoveBlank(move As Move) As Boolean
        Select Case move
            Case Move.Left
                Dim temp As Integer = blankLocation Mod 3
                If temp <> 0 Then
                    blankLocation -= 1
                    moveToGetHere = Move.Left
                    Return True
                Else
                    Return False
                End If
            Case Move.Up
                If blankLocation >= 3 Then
                    blankLocation -= 3
                    moveToGetHere = Move.Up
                    Return True
                Else
                    Return False
                End If
            Case Move.Right
                Dim temp As Integer = blankLocation Mod 3
                If temp <> 2 Then
                    blankLocation += 1
                    moveToGetHere = Move.Right
                    Return True
                Else
                    Return False
                End If
            Case Move.Down
                If blankLocation < 6 Then
                    blankLocation += 3
                    moveToGetHere = Move.Down
                    Return True
                Else
                    Return False
                End If
        End Select

        Return False 'code should not get here
    End Function

    Public Function CanMove(move As Move) As Boolean
        If moveToGetHere = Move.None Then
            Return True
        End If
        Select Case move
            Case Move.Left
                If moveToGetHere = Move.Right Then
                    Return False
                End If
                Return True
            Case Move.Up
                If moveToGetHere = Move.Down Then
                    Return False
                End If
                Return True
            Case Move.Right
                If moveToGetHere = Move.Left Then
                    Return False
                End If
                Return True
            Case Move.Down
                If moveToGetHere = Move.Up Then
                    Return False
                End If
                Return True
        End Select
        Return False 'Should not get here
    End Function

End Class
