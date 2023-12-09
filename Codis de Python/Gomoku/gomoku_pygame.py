import math
import pygame
import sys
import numpy as np

COLUMNS=15
ROWS=15

BROWN=(255,178,102)
BLACK=(0,0,0)
WHITE=(255,255,255)

Gamerunning=True

board=[]

def CreateBoard(board):
    for c in range(COLUMNS):
        board.append([])
        for r in range(ROWS):
            board[c].append(0)

def PrintBoard(board):
    for c in range(COLUMNS):
        
        for r in range(ROWS):
            print(board[c][r],end=' ')
        print(' ')

def PlacePiece(col,row,piece):
    if board[col][row]==0:
        board[col][row]=piece

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




def DrawBoard():
    
    for c in range(15):
        for r in range(15):
            pygame.draw.rect(screen, BROWN,(LINE/2+c*SQUARE,LINE/2+r*SQUARE, SQUARE-LINE, SQUARE-LINE))
            pygame.display.update()

def DrawPiece(x,y,turn):
    arr=np.array(board)
    num=str(np.count_nonzero(arr))
    print(x,y)
    if turn==0:
        pygame.draw.circle(screen,BLACK,((x+1)*50-25,(y+1)*50-25),23)
        pygame.draw.circle(screen,WHITE,((x+1)*50-25,(y+1)*50-25),21)
        PlacePiece(y,x,1)
        text=text_font.render(num,True,BLACK)
    
        screen.blit(text,((x+1)*50-30,(y+1)*50-37))
    
        pygame.display.update()

    else:
        
        pygame.draw.circle(screen,BLACK,((x+1)*50-25,(y+1)*50-25),23)
        PlacePiece(y,x,2)
        text=text_font.render(num,True,WHITE)
        
        screen.blit(text,((x+1)*50-30,(y+1)*50-37))
        
        pygame.display.update()

CreateBoard(board)

PrintBoard(board)

turn=0
pygame.init()
text_font=pygame.font.SysFont('impact',20)

SQUARE=50

LINE=2

height=750
width=750

size=(width,height)

screen=pygame.display.set_mode(size)
DrawBoard()
while Gamerunning:
    pygame.event.pump()
    for event in pygame.event.get():
        if event.type==pygame.QUIT:
            sys.exit()

        if event.type==pygame.MOUSEBUTTONDOWN:
            posx=math.trunc(event.pos[0]/50)
            posy=math.trunc(event.pos[1]/50)
            print(posx,posy)
            if turn==0:
                DrawPiece(posx,posy,turn)
                
            else:
                DrawPiece(posx,posy,turn)
            pygame.display.update()
            
                
            PrintBoard(board)
            if CheckWin(board,turn+1):
                Gamerunning=False
            turn+=1
            turn=turn%2