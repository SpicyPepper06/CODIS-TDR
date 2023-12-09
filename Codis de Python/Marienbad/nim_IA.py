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
        space=int((6-c*2)/2)
        print(space*' ',end='')
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

from functools import cache

@cache
def minimax(state, is_maximizing):
    score = evaluate(state, is_maximizing)
    if score is not None:
        return score

    return (max if is_maximizing else min)(
        minimax(new_state, is_maximizing=not is_maximizing)
        for new_state in possible_new_states(state)
    )

def best_move(state):
    return max(
        (minimax(new_state, is_maximizing=False), new_state)
        for new_state in possible_new_states(state)
    )
    

def possible_new_states(state):
    for pile, counters in enumerate(state):
        for remain in range(counters):
            yield state[:pile] + (remain,) + state[pile + 1 :]

def evaluate(state, is_maximizing):
    if all(counters == 0 for counters in state):
        return 1 if is_maximizing else -1

def Create_state(board):
    support_board=[]
    for c in range(len(board)):
        support_board.append(len(board[c]))
    return support_board

def AI_Play(perfect_move):
    global board
    board2=[]
    for r in range(len(board)):
        board2.append(perfect_move[0][r])
    board=[]
    for c in range(len(board2)):
        board.append([])
        for r in range(board2[c]):
            board[c].append('|')
    print('')
    print(f'AI moves{perfect_move}')
    return board


def avoid_index_0(move):
    auxiliar_board=[]
    for r in range(len(move)):
        if r>0:
            auxiliar_board.append(move[r])
    return auxiliar_board

#Interactive game





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
        
        perfect_move=avoid_index_0((best_move(tuple(Create_state(board)))))

        board=AI_Play(perfect_move)
        turn+=1
    
    turn=turn%2
    PrintBoard(board)
    CheckGameState(board)
