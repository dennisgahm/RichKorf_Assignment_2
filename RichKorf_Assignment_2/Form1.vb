Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Test of RichTextBox multiple lines
        'RichTextBox1.Text = "Test" & vbCrLf & "Dennis"

        Dim board As _8Puzzle = New _8Puzzle()

        'Do breadth first search
        Dim boards As New List(Of _8Puzzle)
        For i As Integer = 0 To 29
            'Try move left
            If board.CanMove(_8Puzzle.Move.Left) Then
                Dim newBoard As New _8Puzzle(board)
                newBoard.MoveBlank(_8Puzzle.Move.Left)

            End If
            'Try move up
            'Try move right
            'Try move down
        Next
    End Sub
End Class
