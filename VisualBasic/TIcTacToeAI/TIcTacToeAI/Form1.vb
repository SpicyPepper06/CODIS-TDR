Public Class Form1
    Dim currentPlayer As Integer = 1 ' 1 for Player X, -1 for Player O
    Dim board(2, 2) As Integer ' 3x3 game board
    Dim panel1 As New Panel() ' Panel to hold the game board buttons
    Dim panel2 As New Panel() ' Panel to hold the reset button and player turn label
    Dim playerTurnLabel As New Label() ' Label to indicate player's turn

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeGame()
    End Sub

    Private Sub InitializeGame()
        currentPlayer = 1

        ' Clear the text and reset font color of the buttons in panel1
        For Each button As Button In panel1.Controls.OfType(Of Button)()
            button.Text = ""
            button.ForeColor = Color.Black ' Reset font color to default
        Next

        ' Create panel1 to hold the game board buttons
        panel1.Size = New Size(450, 450)
        panel1.Location = New Point(50, 50)
        Me.Controls.Add(panel1)

        ' Create buttons and add them to panel1
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                board(i, j) = 0
                Dim button As New Button()
                button.Size = New Size(150, 150)
                button.Location = New Point(j * 150, i * 150)
                button.Tag = New Point(i, j)
                button.Font = New Font(button.Font.FontFamily, 18)
                AddHandler button.Click, AddressOf Button_Click
                panel1.Controls.Add(button)
            Next
        Next

        ' Create panel2 to hold reset button and player turn label
        panel2.Size = New Size(200, 450)
        panel2.Location = New Point(550, 50)
        Me.Controls.Add(panel2)

        ' Create reset button and add it to panel2
        Dim resetButton As New Button()
        resetButton.Text = "Reset"
        resetButton.Size = New Size(150, 50)
        resetButton.Location = New Point(25, 50)
        AddHandler resetButton.Click, AddressOf ResetButton_Click
        panel2.Controls.Add(resetButton)

        ' Create player turn label and add it to panel2
        playerTurnLabel.Text = "Player's Turn: X"
        playerTurnLabel.AutoSize = True
        playerTurnLabel.Location = New Point(25, 150)
        panel2.Controls.Add(playerTurnLabel)
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim indices As Point = DirectCast(button.Tag, Point)
        Dim row As Integer = indices.X
        Dim col As Integer = indices.Y

        If board(row, col) = 0 AndAlso Not CheckForWin(1) AndAlso Not CheckForWin(-1) AndAlso Not CheckForDraw() Then
            ' Human player's turn
            board(row, col) = currentPlayer
            button.Text = If(currentPlayer = 1, "X", "O")

            If CheckForWin(1) Or CheckForWin(-1) Then
                ApplyWinningColor()
                MessageBox.Show($"Player {(If(currentPlayer = 1, "X", "O"))} wins!")
                InitializeGame()
            ElseIf CheckForDraw() Then
                MessageBox.Show("It's a draw!")
                InitializeGame()
            Else
                currentPlayer *= -1 ' Switch player

                If currentPlayer = -1 Then
                    ' Computer player's turn (AI)
                    Dim bestMove As Tuple(Of Integer, Integer) = GetBestMove()
                    If bestMove IsNot Nothing Then
                        board(bestMove.Item1, bestMove.Item2) = currentPlayer
                        Dim computerButton As Button = GetButton(bestMove.Item1, bestMove.Item2)
                        computerButton.Text = "O"

                        If CheckForWin(1) Or CheckForWin(-1) Then
                            ApplyWinningColor()
                            MessageBox.Show($"Player O wins!")
                            InitializeGame()
                        ElseIf CheckForDraw() Then
                            MessageBox.Show("It's a draw!")
                            InitializeGame()
                        Else
                            currentPlayer *= -1 ' Switch player
                        End If
                    End If
                End If
            End If
        Else
            ' Invalid move (cell already occupied)
            MessageBox.Show("Invalid move. Cell already occupied.")
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs)
        ' Handle reset button click event
        InitializeGame()
    End Sub

    Private Sub ApplyWinningColor()
        ' Change the font color of the winning row, column, or diagonal
        For i As Integer = 0 To 2
            If CheckRow(i) Then
                SetButtonColor(i, 0, Color.Red)
                SetButtonColor(i, 1, Color.Red)
                SetButtonColor(i, 2, Color.Red)
            End If

            If CheckColumn(i) Then
                SetButtonColor(0, i, Color.Red)
                SetButtonColor(1, i, Color.Red)
                SetButtonColor(2, i, Color.Red)
            End If
        Next

        If CheckDiagonal(0, 0, 1, 1, 2, 2) Then
            SetButtonColor(0, 0, Color.Red)
            SetButtonColor(1, 1, Color.Red)
            SetButtonColor(2, 2, Color.Red)
        End If

        If CheckDiagonal(0, 2, 1, 1, 2, 0) Then
            SetButtonColor(0, 2, Color.Red)
            SetButtonColor(1, 1, Color.Red)
            SetButtonColor(2, 0, Color.Red)
        End If
    End Sub

    Private Function CheckRow(row As Integer) As Boolean
        Return board(row, 0) = currentPlayer AndAlso board(row, 1) = currentPlayer AndAlso board(row, 2) = currentPlayer
    End Function

    Private Function CheckColumn(col As Integer) As Boolean
        Return board(0, col) = currentPlayer AndAlso board(1, col) = currentPlayer AndAlso board(2, col) = currentPlayer
    End Function

    Private Function CheckDiagonal(row1 As Integer, col1 As Integer, row2 As Integer, col2 As Integer, row3 As Integer, col3 As Integer) As Boolean
        Return board(row1, col1) = currentPlayer AndAlso board(row2, col2) = currentPlayer AndAlso board(row3, col3) = currentPlayer
    End Function

    Private Sub SetButtonColor(row As Integer, col As Integer, color As Color)
        ' Helper method to set the font color of a button at a specific row and column
        For Each control As Control In panel1.Controls
            If TypeOf control Is Button Then
                Dim button As Button = DirectCast(control, Button)
                Dim indices As Point = DirectCast(button.Tag, Point)
                If indices.X = row AndAlso indices.Y = col Then
                    button.ForeColor = color
                    Exit For
                End If
            End If
        Next
    End Sub

    Private Function CheckForWin(Player As Integer) As Boolean
        ' Check for a win in the current row, column, and diagonals
        For i As Integer = 0 To 2
            If (board(i, 0) = Player AndAlso board(i, 1) = Player AndAlso board(i, 2) = Player) OrElse
               (board(0, i) = Player AndAlso board(1, i) = Player AndAlso board(2, i) = Player) Then
                Return True
            End If
        Next

        Return (board(0, 0) = Player AndAlso board(1, 1) = Player AndAlso board(2, 2) = Player) OrElse
               (board(0, 2) = Player AndAlso board(1, 1) = Player AndAlso board(2, 0) = Player)
    End Function

    Private Function CheckForDraw() As Boolean
        ' Check for a draw (no empty cells left)
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                If board(i, j) = 0 Then
                    Return False ' Found an empty cell, game is not a draw
                End If
            Next
        Next
        Return True ' All cells are filled, game is a draw
    End Function

    Private Function GetButton(row As Integer, col As Integer) As Button
        ' Helper method to get the button at a specific row and column
        For Each control As Control In panel1.Controls
            If TypeOf control Is Button Then
                Dim button As Button = DirectCast(control, Button)
                Dim indices As Point = DirectCast(button.Tag, Point)
                If indices.X = row AndAlso indices.Y = col Then
                    Return button
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Function GetBestMove() As Tuple(Of Integer, Integer)
        Dim bestScore As Integer = -1
        Dim bestMove As Tuple(Of Integer, Integer) = Nothing

        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                If board(i, j) = 0 Then
                    ' Empty cell, try the move
                    board(i, j) = -1
                    Dim score As Integer = Minimax(board, 0, False)
                    board(i, j) = 0 ' Undo the move

                    If score > bestScore Then
                        bestScore = score
                        bestMove = New Tuple(Of Integer, Integer)(i, j)
                    End If
                End If
            Next
        Next

        Return bestMove
    End Function

    Private Function Minimax(board As Integer(,), depth As Integer, isMaximizing As Boolean) As Integer
        If CheckForWin(-1) Then
            Return 1
        ElseIf CheckForWin(1) Then
            Return -1

        ElseIf CheckForDraw() Then
            Return 0
        End If

        If isMaximizing Then
            Dim bestScore As Integer = -1
            For i As Integer = 0 To 2
                For j As Integer = 0 To 2
                    If board(i, j) = 0 Then
                        ' Empty cell, try the move
                        board(i, j) = -1
                        bestScore = Math.Max(bestScore, Minimax(board, depth + 1, False))
                        board(i, j) = 0 ' Undo the move
                    End If
                Next
            Next
            Return bestScore
        Else
            Dim bestScore As Integer = 1
            For i As Integer = 0 To 2
                For j As Integer = 0 To 2
                    If board(i, j) = 0 Then
                        ' Empty cell, try the move
                        board(i, j) = 1
                        bestScore = Math.Min(bestScore, Minimax(board, depth + 1, True))
                        board(i, j) = 0 ' Undo the move
                    End If
                Next
            Next
            Return bestScore
        End If
    End Function


End Class