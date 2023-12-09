

COLUMNS=15
ROWS=15



Gamerunning=True

board=[]

def CreateBoard(board):
    for c in range(COLUMNS):
        board.append([])
        for r in range(ROWS):
            board[c].append('.')

def PrintBoard(board):
    for c in range(COLUMNS):
        
        for r in range(ROWS):
            print(board[c][r],end=' ')
        print(' ')

def PlacePiece(col,row,piece):
    if board[col-1][row-1]=='.':
        board[col-1][row-1]=piece

def CheckWin(board, piece):
    #Horizontal
    for c in range(COLUMNS):
        for r in range(ROWS-4):
            if board[c][r]==piece and board[c][r+1]==piece and board[c][r+2]==piece and board[c][r+3]==piece and board[c][r+4]==piece:
                return True
    #Vertical        
    for c in range(COLUMNS-4):

        for r in range(ROWS):
            if board[c][r]==piece and board[c+1][r]==piece and board[c+2][r]==piece and board[c+3][r]==piece and board[c+4][r]==piece:
                return True
            
    #Diagonal positiva
    for c in range(COLUMNS):

        for r in range(ROWS-4):
            if board[c][r]==piece and board[c-1][r+1]==piece and board[c-2][r+2]==piece and board[c-3][r+3]==piece and board[c-4][r+4]==piece:
                return True

                

	# Check negatively sloped 
    for c in range(COLUMNS):

        for r in range(4,ROWS):
            if board[c][r]==piece and board[c-1][r-1]==piece and board[c-2][r-2]==piece and board[c-3][r-3]==piece and board[c-4][r-4]==piece:
                return True



CreateBoard(board)

PrintBoard(board)

turn=0

while Gamerunning:
            
        if turn==0:
            col=int(input('Fila'))
            row=int(input('Columna'))
            PlacePiece(col,row,1)    
        else:
            col=int(input('Fila'))
            row=int(input('Columna'))
            PlacePiece(col,row,2)
            
            
                
        PrintBoard(board)
        if CheckWin(board,turn+1):
            Gamerunning=False
        turn+=1
        turn=turn%2