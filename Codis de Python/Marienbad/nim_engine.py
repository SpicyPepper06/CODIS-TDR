

GameRunning=True

board=[]
Marienbad=(1,3,5,7)
GameOfPiles=list(Marienbad)

winner=None


def CreateBoard():
    for c in range(len(GameOfPiles)):
        board.append([])
        for r in range(GameOfPiles[c]):
            board[c].append('|')
CreateBoard()

def PrintBoard(board):
    columns=len(board)
    for c in range(columns):
        for i in range(len(board[c])):
            print(board[c][i],end='')
            
        print('')

def is_empty_col(board,col):
    if '|' not in board[col]:
        return True

def get_next_spot(board,col):
    for r in range(len(board[col])):
        if board[col][r]=='|':
            return r
        
def take_stick(board,col,piles):
    for i in range(piles):
        if not is_empty_col(board, col):
            board[col].pop(-1)

    
def CheckGameState(board):
    global GameRunning
    winner=CheckWinner(turn)
    if not any('|' in sublist for sublist in board):
        print(f'{winner} won!')
        GameRunning=False

def count_piles(board, col):
    piles=0
    for r in range(len(board[col])):
        if board[col][r]=='|':
            piles+=1
    return piles

def return_state(board):
    columns=len(board)
    board2=[]
    for c in range(columns):
        piles=0
        for r in range(len(board[c])):
            if board[c][r]=='|':
                piles+=1
        board2.append(piles)
    return board2


def CheckWinner(turn):
    
    if turn==0:
        return 'You'
    else: 
        return 'AI'



PrintBoard(board)
turn=0
#print(return_state(board))
#a=list(possible_new_states(return_state(board)))

#AI engine



def Create_state(board):
    support_board=[]
    for c in range(len(board)):
        support_board.append(len(board[c]))
    return support_board



while GameRunning:
    
    if turn==0:
        choos_col=int(input('A. Choose an available column(1-4)'))-1
        
       
        if choos_col<=len(board):
            if not is_empty_col(board,choos_col):
                piles=int(input(f'Choose Number of piles (1-{count_piles(board,choos_col)})'))
                
                take_stick(board,choos_col,piles)
                print(f'New State{Create_state(board)}')
                turn+=1
        else:
            print('I said an AVAILABLE column!')
            

    elif turn==1:
        
        choos_col=int(input('A. Choose an available column(1-4)'))-1
        
       
        if choos_col<=len(board):
            if not is_empty_col(board,choos_col):
                piles=int(input(f'Choose Number of piles (1-{count_piles(board,choos_col)})'))
                
                take_stick(board,choos_col,piles)
                print(f'New State{Create_state(board)}')
                turn+=1
        else:
            print('I said an AVAILABLE column!')
    
    turn=turn%2
    PrintBoard(board)
    CheckGameState(board)
