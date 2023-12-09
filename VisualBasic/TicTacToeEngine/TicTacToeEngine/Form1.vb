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

        If board(row, col) = 0 Then
            ' Valid move
            board(row, col) = currentPlayer
            button.Text = If(currentPlayer = 1, "X", "O")

            If CheckForWin(row, col) Then

                MessageBox.Show($"Player {(If(currentPlayer = 1, "X", "O"))} wins!")
                InitializeGame()
            ElseIf CheckForDraw() Then
                MessageBox.Show("It's a draw!")
                InitializeGame()
            Else
                currentPlayer *= -1 ' Switch player
                UpdatePlayerTurnLabel()
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

    Private Function CheckForWin(row As Integer, col As Integer) As Boolean
        Dim isWin As Boolean = False

        ' Check for a win in the current row
        If board(row, 0) = currentPlayer AndAlso board(row, 1) = currentPlayer AndAlso board(row, 2) = currentPlayer Then
            ChangeButtonColors(row, 0, row, 1, row, 2)
            isWin = True
        End If

        ' Check for a win in the current column
        If board(0, col) = currentPlayer AndAlso board(1, col) = currentPlayer AndAlso board(2, col) = currentPlayer Then
            ChangeButtonColors(0, col, 1, col, 2, col)
            isWin = True
        End If

        ' Check for a win in the main diagonal
        If row = col AndAlso board(0, 0) = currentPlayer AndAlso board(1, 1) = currentPlayer AndAlso board(2, 2) = currentPlayer Then
            ChangeButtonColors(0, 0, 1, 1, 2, 2)
            isWin = True
        End If

        ' Check for a win in the other diagonal
        If row + col = 2 AndAlso board(0, 2) = currentPlayer AndAlso board(1, 1) = currentPlayer AndAlso board(2, 0) = currentPlayer Then
            ChangeButtonColors(0, 2, 1, 1, 2, 0)
            isWin = True
        End If

        Return isWin
    End Function

    Private Sub ChangeButtonColors(row1 As Integer, col1 As Integer, row2 As Integer, col2 As Integer, row3 As Integer, col3 As Integer)
        ' Change the font color of the winning buttons
        SetButtonColor(row1, col1, Color.Red)
        SetButtonColor(row2, col2, Color.Red)
        SetButtonColor(row3, col3, Color.Red)
    End Sub

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

    Private Sub UpdatePlayerTurnLabel()
        ' Update player turn label
        playerTurnLabel.Text = $"Player's Turn: {(If(currentPlayer = 1, "X", "O"))}"
    End Sub
End Class

