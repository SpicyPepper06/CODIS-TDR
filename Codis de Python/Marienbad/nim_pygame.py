import pygame
import sys
import math

BROWN=(252, 237, 218)
WHITE=(255,255,255)
GREEN=(204, 243, 129)
RED=(238, 78, 52)
BLUE=(72, 49, 212)
PINK=(251, 234, 235)

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
    winner=CheckWinner(player)
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


def CheckWinner(player):
    
    if player==0:
        return 'AI'
    else: 
        return 'YOU'



PrintBoard(board)
turn=0
#print(return_state(board))
#a=list(possible_new_states(return_state(board)))

#AI engine

from functools import cache

@cache
def minimax(state, is_maximizing):
    if (score := evaluate(state, is_maximizing)) is not None:
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

def draw_board(board):
    pygame.draw.rect(screen,GREEN,(0,0,width,650))
    for c in range(len(board)):
        space=((6-c*2)*(50+(PILES_WIDTH+100/7)))/4
        
        for r in range(len(board[c])):
            pygame.draw.rect(screen,RED,((space+50+(PILES_WIDTH+100/7)*r),(PILES_HEIGHT+40)*c+50-MATCH_FIRE,MATCH_FIRE,MATCH_FIRE))
            pygame.draw.rect(screen,BROWN,((space+50+(PILES_WIDTH+100/7)*r),(PILES_HEIGHT+40)*c+50,PILES_WIDTH,PILES_HEIGHT))
 
pygame.init()

text_font=pygame.font.SysFont('impact',50)

def take_stick_draw(posx):
    global turn
    column_px=math.trunc(posx/155)
    print(column_px+1)
    if column_px in (0,1,2,3) and len(board[column_px])>0:
        board[column_px].pop(-1)
    else:
        turn=turn+1

PILES_HEIGHT=110
PILES_WIDTH=30

MATCH_FIRE=30

height=(PILES_HEIGHT+MATCH_FIRE)*len(board)+100+100
width=PILES_WIDTH*len(board[-1])+200

size=(width,height)

screen=pygame.display.set_mode(size)

draw_board(board)
pygame.display.update()

while GameRunning:
    text=text_font.render('AI TURN',True,PINK)
    pygame.draw.rect(screen,BLUE,(0,650,width,200))
    screen.blit(text,(130,650))
    
    pygame.display.update()
    
    
    if turn==0:
        player=0
        pygame.event.pump()
        for event in pygame.event.get():
            if event.type==pygame.QUIT:
                sys.exit()
            if event.type==pygame.MOUSEBUTTONDOWN:
                
                print(board)
                take_stick_draw(event.pos[1])
                print(board)
                pygame.display.update()
       
            

    elif turn==1:
        player=1
        perfect_move=avoid_index_0((best_move(tuple(Create_state(board)))))
        board=AI_Play(perfect_move)
        turn+=1
    
    turn=turn%2
    
    draw_board(board)
    CheckGameState(board)
    pygame.display.update()
