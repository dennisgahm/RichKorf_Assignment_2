Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Test of RichTextBox multiple lines
        'RichTextBox1.Text = "Test" & vbCrLf & "Dennis"

        Dim board As New _8Puzzle()

        'Do breadth first search
        Dim boardsParents As New List(Of _8Puzzle) 'The boards for this depth - 1 (parents)
        boardsParents.Add(board)
        Dim boards As New List(Of _8Puzzle) 'The boards for this depth
        For i As Integer = 0 To 9
            boards.Clear()

            For i3 As Integer = 0 To boardsParents.Count - 1
                'Try move left
                If boardsParents.Item(i3).CanMove(_8Puzzle.Move.Left) Then
                    Dim newBoard As New _8Puzzle(boardsParents.Item(i3))
                    newBoard.MoveBlank(_8Puzzle.Move.Left)
                    boards.Add(newBoard)
                End If
                'Try move up
                If boardsParents.Item(i3).CanMove(_8Puzzle.Move.Up) Then
                    Dim newBoard As New _8Puzzle(boardsParents.Item(i3))
                    newBoard.MoveBlank(_8Puzzle.Move.Up)
                    boards.Add(newBoard)
                End If
                'Try move right
                If boardsParents.Item(i3).CanMove(_8Puzzle.Move.Right) Then
                    Dim newBoard As New _8Puzzle(boardsParents.Item(i3))
                    newBoard.MoveBlank(_8Puzzle.Move.Right)
                    boards.Add(newBoard)
                End If
                'Try move down
                If boardsParents.Item(i3).CanMove(_8Puzzle.Move.Down) Then
                    Dim newBoard As New _8Puzzle(boardsParents.Item(i3))
                    newBoard.MoveBlank(_8Puzzle.Move.Down)
                    boards.Add(newBoard)
                End If
            Next

            Dim depth As Integer = i + 1
            RichTextBox1.Text = RichTextBox1.Text & vbCrLf & "Depth " & depth & ": " & boards.Count

            'put all generated children into parent boards list for next depth
            boardsParents.Clear()
            For i2 As Integer = 0 To boards.Count - 1
                boardsParents.Add(boards.Item(i2))
            Next
        Next
    End Sub
End Class
