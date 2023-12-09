import pygame
import sys
import math

BackGroundColor=(118, 215, 196 )
white=(255,255,255)

GameRunning=True
currentPlayer='X'
bot='X'
human='O'
board=['?','?','?','?','?','?','?','?','?']

def PrintBoard(board):
    print(board[0],'|',board[1],'|',board[2])
    print('--+---+---')
    print(board[3],'|',board[4],'|',board[5])
    print('--+---+---')
    print(board[6],'|',board[7],'|',board[8])
    print('')

def DrawSign():
    global currentPlayer
    if currentPlayer==human:
        move=int(input('Selecciona una casella (1-9)'))
        if board[move-1]=='?':
            board[move-1]=currentPlayer
            if currentPlayer=='O':
                currentPlayer='X'
            else:
                currentPlayer='O'
        else:
            print('Casella ocupada')
            DrawSign()

def CheckTurn():
    global currentPlayer
    if currentPlayer==human:
        DrawSign()
    else:
        CorMove()


def CheckWinner(board):
    #Horitzontal
    for i in (0,3,6):
        if board[i]==board[i+1] and board[i]==board[i+2] and board[i]!='?':
            return True
        
    #Vertical
    for i in (0,1,2):
        if board[i]==board[i+3] and board[i]==board[i+6] and board[i]!='?':
            return True
        
    #Diagonals
    if board[0]==board[4] and board[0]==board[8] and board[0]!='?':
        return True
    
    if board[2]==board[4] and board[2]==board[6] and board[2]!='?':
        return True

def CheckMark(mark):
    #Horitzontal
    for i in (0,3,6):
        if board[i]==board[i+1] and board[i]==board[i+2] and board[i]==mark:
            return True
        
    #Vertical
    for i in (0,1,2):
        if board[i]==board[i+3] and board[i]==board[i+6] and board[i]==mark:
            return True
        
    #Diagonals
    if board[0]==board[4] and board[0]==board[8] and board[0]==mark:
        return True
    
    if board[2]==board[4] and board[2]==board[6] and board[2]==mark:
        return True

def CheckTie():
    if '?' not in board:
        return True

def CheckGameState(board):
    global currentPlayer
    global GameRunning
    if CheckWinner(board):
        PrintBoard(board)
        GameRunning=False
        print('El joc ha acabat')
        if currentPlayer=='O':
            currentPlayer='X'
        else:
            currentPlayer='O'
        print(f'El guanyador és {currentPlayer}')
    elif CheckTie():
        PrintBoard(board)
        GameRunning=False
        print('És un empat!')
#randomMove AI
#def DumbAI(board):
    #global currentPlayer
    #randomMove=random.randint(0,8)
    #if currentPlayer=='O':
        #if board[randomMove]=='?':
            #board[randomMove]=currentPlayer
            #currentPlayer='X'
        #else:
            #randomMove=random.randint(0,8)

#Invincible AI
def CorMove():
    global currentPlayer
    bestScore=-1000
    bestMove=0
    for i in range(9):
        if board[i]=='?':
            board[i]=bot
            score=minimax(board,0,False)
            board[i]='?'
            if score>bestScore:
                bestScore=score
                bestMove=i
    board[bestMove]=bot
    draw_x_AI(bestMove)
    currentPlayer=human

def minimax(board,depth,isMaximizing):
    if CheckMark(bot):
        return 1000
    elif CheckMark(human):
        return -1000
    elif CheckTie():
        return 0  
    if isMaximizing:
        bestScore=-1000
        for i in range(9):
            if board[i]=='?':
                board[i]=bot
                score=minimax(board,0,False)
                board[i]='?'
                if score>bestScore:
                    bestScore=score

        return bestScore
    
    else:
        bestScore=1000
        for i in range(9):
            if board[i]=='?':
                board[i]=human
                score=minimax(board,depth+1,True)
                board[i]='?'
                if score<bestScore:
                    bestScore=score
                    
        return bestScore

def is_valid_move(position):
    if board[position]=='?':
        return True


def draw_board(board):
    pygame.draw.rect(screen, white,(0,0, height, width))
    for c in range(3):
        for r in range(3):
            pygame.draw.rect(screen, BackGroundColor,(10+c*SQUARE,10+r*SQUARE, SQUARE-LINE, SQUARE-LINE))
            pygame.display.update()

def transformxy(x,y):
    if x+y==0:
        return 0
    elif x+y==1:
        if x==1:
            return 1
        else:
            return 3
    elif x+y==2:
        if x==2:
            return 2
        elif y==2:
            return 6
        else:
            return 4
    elif x+y==3:
        if x==1:
            return 7
        else:
            return 5
    elif x+y==4: 
        return 8

def transformx(x):
    if x==0 or x==3 or x==6:
        return 0
    elif x==1 or x==4 or x==7:
        return 1
    elif x==2 or x==5 or x==8:
        return 2

def transformy(y):
    if y==0 or y==1 or y==2:
        return 0
    elif y==3 or y==4 or y==5:
        return 1
    elif y==6 or y==7 or y==8:
        return 2

def draw_x(position):
    for x in range(3):
        for y in range(3):
            if is_valid_move(position):
                board[position]='X'
                pygame.draw.line(screen,white,(posx*SQUARE+20,posy*SQUARE+20),(posx*SQUARE+170,posy*SQUARE+170),30)
                pygame.draw.line(screen,white,(posx*SQUARE+170,posy*SQUARE+20),(posx*SQUARE+20,posy*SQUARE+170),30)

def draw_x_AI(position):
    x=transformx(position)
    y=transformy(position)
    board[position]='X'
    pygame.draw.line(screen,white,(x*SQUARE+30,y*SQUARE+30),(x*SQUARE+160,y*SQUARE+160),30)
    pygame.draw.line(screen,white,(x*SQUARE+160,y*SQUARE+30),(x*SQUARE+30,y*SQUARE+160),30)

def draw_o(position):

    for x in range(3):
        for y in range(3):
            if is_valid_move(position):
                board[position]='O'
                pygame.draw.circle(screen,white,(signx_pos,signy_pos),80)
                pygame.draw.circle(screen,BackGroundColor,(signx_pos,signy_pos),60)
            

pygame.init()

SQUARE=200
LINE=20

width=SQUARE*3
height=SQUARE*3

size=(width,height)
turn=0
screen=pygame.display.set_mode(size)
draw_board(board)
pygame.display.update()
while GameRunning:
       
    pygame.event.pump()
    for event in pygame.event.get():
        if event.type==pygame.QUIT:
            sys.exit()
        if event.type==pygame.MOUSEBUTTONDOWN:
            
            posx=math.trunc(event.pos[0]/200)
            posy=math.trunc(event.pos[1]/200)
            signx_pos=posx*SQUARE+SQUARE/2 
            signy_pos=posy*SQUARE+SQUARE/2
            position=transformxy(int(posx),int(posy))
            print(position)
            if turn==0:
                CorMove()
            elif turn==1:
                draw_o(position)
            turn+=1
            turn=turn%2
            pygame.display.update()
            PrintBoard(board)
    # PrintBoard(board)
    
    # CheckTurn()
    CheckGameState(board)