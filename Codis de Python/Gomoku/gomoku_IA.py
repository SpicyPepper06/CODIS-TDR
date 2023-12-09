import math
import pygame
import sys
import numpy as np
import random
import copy
#10x10 grid
COLUMNS = 15
ROWS = 15
WINNING_PIECES = 5

Empty=0

HUMAN=1
IA=2



BROWN=(255,178,102)
BLACK=(0,0,0)
WHITE=(245,254,253)
BLUE=(138,170,229)
GREEN=(0,255,127)
GREY=(75,72,69)
GOLD=(255,215,0)
WINNER_GREEN = (0,250,154)
WINNER_BLUE = (0,191,255)

HUMAN_WIN = 3
IA_WIN = 4


Gamerunning=True

def CreateBoard():
    board = [[0 for _ in range(COLUMNS)] for _ in range(ROWS)]
    return board

board=CreateBoard()

def PrintBoard(board):
    for r in range(COLUMNS):   
        for c in range(ROWS):
            print(board[r][c],end=' ')
        print(' ')

def is_valid_move(board,row,col):
    if board[row][col]==0:
        return True

def PlacePiece(board,row,col,piece):
    board[row][col]=piece

#first move always at the center

CENTER=int((ROWS-1)/2)

def first_move(board):
    if HUMAN not in board and IA not in board:
        DrawPiece(board,CENTER,CENTER, IA)
        pygame.display.update()
        

def CheckWin(board, piece):
    #Horizontal
    for r in range(ROWS):
        for c in range(COLUMNS-4):
            if board[r][c]==piece and board[r][c+1]==piece and board[r][c+2]==piece and board[r][c+3]==piece and board[r][c+4]==piece:
                return True
    #Vertical        
    for r in range(ROWS-4):

        for c in range(COLUMNS):
            if board[r][c]==piece and board[r+1][c]==piece and board[r+2][c]==piece and board[r+3][c]==piece and board[r+4][c]==piece:
                return True     
    #Diagonal positiva
    for r in range(ROWS):

        for c in range(COLUMNS-4):
            if board[r][c]==piece and board[r-1][c+1]==piece and board[r-2][c+2]==piece and board[r-3][c+3]==piece and board[r-4][c+4]==piece:
                return True               
	# Check negatively sloped 
    for r in range(ROWS):

        for c in range(4,COLUMNS):
            if board[r][c]==piece and board[r-1][c-1]==piece and board[r-2][c-2]==piece and board[r-3][c-3]==piece and board[r-4][c-4]==piece:
                return True

#Tonar el guanyador en un 3

def GetWinner(board, piece):
    #Horizontal
    for r in range(ROWS):
        for c in range(COLUMNS-4):
            if board[r][c]==piece and board[r][c+1]==piece and board[r][c+2]==piece and board[r][c+3]==piece and board[r][c+4]==piece:
                if piece == IA:
                    board[r][c] = IA_WIN
                    board[r][c + 1] = IA_WIN
                    board[r][c + 2] = IA_WIN
                    board[r][c + 3] = IA_WIN
                    board[r][c + 4] = IA_WIN
                elif piece == HUMAN:
                    board[r][c] = HUMAN_WIN
                    board[r][c + 1] = HUMAN_WIN
                    board[r][c + 2] = HUMAN_WIN
                    board[r][c + 3] = HUMAN_WIN
                    board[r][c + 4] = HUMAN_WIN
    #Vertical       
    for r in range(ROWS-4):

        for c in range(COLUMNS):
            if board[r][c]==piece and board[r+1][c]==piece and board[r+2][c]==piece and board[r+3][c]==piece and board[r+4][c]==piece:
                if piece == IA:
                    board[r][c] = IA_WIN
                    board[r + 1][c] = IA_WIN
                    board[r + 2][c] = IA_WIN
                    board[r + 3][c] = IA_WIN
                    board[r + 4][c] = IA_WIN   
                else:
                    board[r][c] = HUMAN_WIN
                    board[r + 1][c] = HUMAN_WIN
                    board[r + 2][c] = HUMAN_WIN
                    board[r + 3][c] = HUMAN_WIN
                    board[r + 4][c] = HUMAN_WIN   
    #Diagonal positiva
    for r in range(ROWS):

        for c in range(COLUMNS-4):
            if board[r][c]==piece and board[r-1][c+1]==piece and board[r-2][c+2]==piece and board[r-3][c+3]==piece and board[r-4][c+4]==piece:
                if piece == IA:
                    board[r][c] = IA_WIN
                    board[r - 1][c + 1] = IA_WIN
                    board[r - 2][c + 2] = IA_WIN
                    board[r - 3][c + 3] = IA_WIN
                    board[r - 4][c + 4] = IA_WIN  
                else:
                    board[r][c] = HUMAN_WIN
                    board[r - 1][c + 1] = HUMAN_WIN
                    board[r - 2][c + 2] = HUMAN_WIN
                    board[r - 3][c + 3] = HUMAN_WIN
                    board[r - 4][c + 4] = HUMAN_WIN              
	# Check negatively sloped 
    for r in range(ROWS):

        for c in range(4,COLUMNS):
            if board[r][c]==piece and board[r-1][c-1]==piece and board[r-2][c-2]==piece and board[r-3][c-3]==piece and board[r-4][c-4]==piece:
                if piece == IA:
                    board[r][c] = IA_WIN
                    board[r - 1][c - 1] = IA_WIN
                    board[r - 2][c - 2] = IA_WIN
                    board[r - 3][c - 3] = IA_WIN
                    board[r - 4][c - 4] = IA_WIN  
                else:
                    board[r][c] = HUMAN_WIN
                    board[r - 1][c - 1] = HUMAN_WIN
                    board[r - 2][c - 2] = HUMAN_WIN
                    board[r - 3][c - 3] = HUMAN_WIN
                    board[r - 4][c - 4] = HUMAN_WIN  

def DrawBoard():
    pygame.draw.rect(screen, GREY,(0,0, width, height))
    
    for r in range(ROWS+1):
        for c in range(COLUMNS+1):
            pygame.draw.rect(screen, WHITE,(LINE/2+c*SQUARE,LINE/2+r*SQUARE, SQUARE-LINE, SQUARE-LINE))
            pygame.display.update()
    pygame.draw.circle(screen,GREY,(width/2,height/2),RADIUS/2)
    pygame.display.update()


def DrawPiece(board,x,y,piece):
    while is_valid_move(board, y, x):
        
        if piece == HUMAN:
            
            pygame.draw.circle(screen,GREEN,(x*SQUARE + SQUARE,y*SQUARE+SQUARE),RADIUS)
            pygame.draw.rect(screen, GREY, (x*SQUARE + SQUARE/2 +RADIUS/2,y*SQUARE + SQUARE/2 + RADIUS/2, SQUARE/2 + RADIUS/4, SQUARE/2 + RADIUS/4))
            pygame.draw.rect(screen, GREEN, (x*SQUARE + SQUARE/2 + RADIUS/2 + RADIUS/4 , y*SQUARE + SQUARE/2 + RADIUS/2 + RADIUS/4, SQUARE/2.7, SQUARE/2.7))
            PlacePiece(board,y,x,1)
            pygame.display.update()
            return True

        else:
            pygame.draw.circle(screen,BLUE,(x*SQUARE+SQUARE,y*SQUARE+SQUARE),RADIUS)
            pygame.draw.circle(screen, GREY,(x*SQUARE+SQUARE,y*SQUARE+SQUARE),RADIUS/1.5)
            pygame.draw.circle(screen,BLUE,(x*SQUARE+SQUARE,y*SQUARE+SQUARE),RADIUS/2.5)
            PlacePiece(board,y,x,2)
            pygame.display.update()
            return True
    
#Guanyador en vermell

def DrawWinner(board, piece):
    for r in range(ROWS):
        for c in range(COLUMNS):
            if board[r][c] == IA_WIN and piece == IA:
                pygame.draw.circle(screen, WINNER_BLUE, (c*SQUARE+SQUARE, r*SQUARE+SQUARE), RADIUS)
                pygame.draw.circle(screen, GOLD,(c*SQUARE+SQUARE,r*SQUARE+SQUARE),RADIUS/1.5)
                pygame.draw.circle(screen, WINNER_BLUE, (c*SQUARE+SQUARE,r*SQUARE+SQUARE),RADIUS/2.5)
                pygame.display.update()
            elif board[r][c] == HUMAN_WIN and piece == HUMAN:
                pygame.draw.circle(screen, WINNER_GREEN, (c*SQUARE+SQUARE, r*SQUARE+SQUARE), RADIUS)
                pygame.draw.rect(screen, GOLD, (c*SQUARE + SQUARE/2 +RADIUS/2,r*SQUARE + SQUARE/2 + RADIUS/2, SQUARE/2 + RADIUS/4, SQUARE/2 + RADIUS/4))
                pygame.draw.rect(screen, WINNER_GREEN, (c*SQUARE + SQUARE/2 + RADIUS/2 + RADIUS/4 , r*SQUARE + SQUARE/2 + RADIUS/2 + RADIUS/4, SQUARE/2.7, SQUARE/2.7))
                pygame.display.update()
#a convenient way to check vertical positions
def verticalize(board):
    new_board=[]
    for r in range(ROWS):
        new_board.append([])
        
        for c in range(COLUMNS):
            
            new_board[r].append(board[c][r])
    return new_board

#Evaluation system
def Check_Window(window,piece,score):
        
    if window.count(piece)==5:
        score.append(200)
    elif ((window[0] == piece and window[1] == piece and window[2] == piece and window[3] == piece) or (window[4] == piece and window[1] == piece and window[2] == piece and window[3] == piece)) and window.count(Empty)==1:
        score.append(100)
    elif ((window[0] == piece and window[1] == piece and window[2] == piece) or (window[4] == piece and window[3] == piece and window[2] == piece)) and window.count(Empty)==2:
        score.append(50)
    elif ((window[0] == piece and window[1] == piece) or (window[4] == piece and window[3] == piece)) and window.count(Empty)==3:
        score.append(20) 
    elif window.count(piece)==1 and window.count(Empty)==4:
        score.append(10)
    elif window.count(piece)==0 and window.count(Empty)==WINNING_PIECES:
        score.append(1)
    elif window.count(piece)==0 and window.count(Empty)!=WINNING_PIECES:
        score.append(0)
        
    
def score_position_h(board,piece):
    #Horizontal
    score=[]
    for r in range(ROWS):  
        for c in range(COLUMNS-4):
            window=board[r][c:c+WINNING_PIECES]              
            Check_Window(window,piece,score)
    return max(score)

def score_position_vert(board,piece):
    #vertical
    score=[]
    for r in range(ROWS):
        for c in range(COLUMNS-4):
            window=board[r][c:c+WINNING_PIECES]
            Check_Window(window,piece,score)
    
    return max(score)

def score_position_nd(board,piece):
    score=[]
    for r in range(ROWS-4):    
        for c in range(COLUMNS-4):
            window=[0,0,0,0,0]
            for i in range(WINNING_PIECES):
                window[i]=board[r+i][c+i]      
            Check_Window(window,piece,score) 
    return max(score)

def score_position_pd(board,piece):
    score=[]
    for r in range(4,ROWS):    
        for c in range(COLUMNS-4):
            window=[0,0,0,0,0]
            for i in range(WINNING_PIECES):
                window[i]=board[r-i][c+i]        
            Check_Window(window,piece,score)
 
    return max(score)

def get_valid_location(board):
    valid=[]
    for r in range(ROWS):
        valid.append([])
        for c in range(COLUMNS):
            if board[r][c]==0:
                valid[r].append(c)
    return valid

def best_move(board,piece):
    global best_row
    
    valid=get_valid_location(board)
    convent_board=verticalize(board)
    convent_valid=get_valid_location(convent_board)
    best_score=0

    horizontal=score_position_h(board,piece)
    vertical=score_position_vert(convent_board,piece)
    positive_diag=score_position_pd(board,piece)
    negative_diag=score_position_nd(board,piece)

    positions=[horizontal,vertical,positive_diag,negative_diag]
   
    best_col=0
    #horizontal
    if max(positions)==positions[0]:
        for r in range(ROWS):
            for col in valid[r]:
                aux_board=copy.deepcopy(board)
                
                
                aux_board[r][col]=piece
                
                score=score_position_h(aux_board,piece)
                
                if best_score<score:
                    best_score=score
                    best_col=col
                    best_row=r
        
        DrawPiece(board,best_col,best_row,turn)
    #vertical
    elif max(positions)==positions[1]:
        for r in range(ROWS):
            for col in convent_valid[r]:
                aux_board=copy.deepcopy(convent_board)
                
                
                aux_board[r][col]=piece
                
                score=score_position_h(aux_board,piece)
                
                if best_score<score:
                    best_score=score
                    best_col=r
                    best_row=col
        
        
        DrawPiece(board,best_col,best_row,turn)
    #positive_diagonal
    elif max(positions)==positions[2]:
        for r in range(ROWS):
            for col in valid[r]:
                aux_board=copy.deepcopy(board)
                
                
                aux_board[r][col]=piece
                
                score=score_position_pd(aux_board,piece)
                
                if best_score<score:
                    best_score=score
                    best_col=col
                    best_row=r
        
        
        DrawPiece(board,best_col,best_row,turn)
    #negative_diagonal
    elif max(positions)==positions[3]:
        for r in range(ROWS):
            for col in valid[r]:
                aux_board=copy.deepcopy(board)
                
                
                aux_board[r][col]=piece
                
                score=score_position_nd(aux_board,piece)
                
                if best_score<score:
                    best_score=score
                    best_col=col
                    best_row=r
        
        
        DrawPiece(board,best_col,best_row,turn)

def three_threat(board, piece):
    for r in range(ROWS):
        for c in range(COLUMNS):
            # Check horizontally
            if c < COLUMNS - 4 and c > 0:
                if board[r][c] == piece and board[r][c + 1] == piece and board[r][c + 2] == piece and board[r][c + 3] == Empty and board[r][c - 1] == Empty and board[r][c + 4] == Empty:
                    
                    return c + 3, r

            # Check vertically
            if r < ROWS - 4 and r > 0:
                if board[r][c] == piece and board[r + 1][c] == piece and board[r + 2][c] == piece and board[r + 3][c] == Empty and board[r - 1][c] == Empty and board[r + 4][c] == Empty:
                    return c, r + 3

            # Check diagonally (positive slope)
            if c < COLUMNS - 3 and r >= 4:
                if (
                    board[r][c] == piece
                    and board[r - 1][c + 1] == piece
                    and board[r - 2][c + 2] == piece
                    and board[r - 3][c + 3] == Empty
                ):
                    return c + 3, r - 3

            # Check diagonally (negative slope)
            if c < COLUMNS and r >= 3:
                if (
                    board[r][c] == piece
                    and board[r - 1][c - 1] == piece
                    and board[r - 2][c - 2] == piece
                    and board[r - 3][c - 3] == Empty
                ):
                    return c - 3, r - 3

    return None  # No immediate threat found

def four_threat(board, piece):
    for r in range(ROWS):
        for c in range(COLUMNS):
            # Check horizontally
            if c < COLUMNS - 4:
                if board[r][c] == Empty and board[r][c + 1] == piece and board[r][c + 2] == piece and board[r][c + 3] == piece and board[r][c + 4] == piece:
                    
                    return c , r
                elif board[r][c] == piece and board[r][c + 1] == piece and board[r][c + 2] == piece and board[r][c + 3] == piece and board[r][c + 4] == Empty:
                    return c + 4, r
            # Check vertically
            if r < ROWS - 4:
                if board[r][c] == Empty and board[r + 1][c] == piece and board[r + 2][c] == piece and board[r + 3][c] == piece and board[r + 4][c] == piece:
                    return c, r
                elif board[r][c] == piece and board[r + 1][c] == piece and board[r + 2][c] == piece and board[r + 3][c] == piece and board[r + 4][c] == Empty:
                    return c, r + 4
            # Check diagonally (positive slope)
            if c < COLUMNS - 4 and r >= 5:
                if (
                    board[r][c] == Empty
                    and board[r - 1][c + 1] == piece
                    and board[r - 2][c + 2] == piece
                    and board[r - 3][c + 3] == piece
                    and board[r - 4][c + 4] == piece
                ):
                    
                    return c , r 
                elif (  
                    board[r][c] == piece
                    and board[r - 1][c + 1] == piece
                    and board[r - 2][c + 2] == piece
                    and board[r - 3][c + 3] == piece
                    and board[r - 4][c + 4] == Empty
                ):
                    return c - 4, r - 4
            # Check diagonally (negative slope)
            if c < COLUMNS and r >= 4:
                if (
                    (board[r][c] == Empty
                    and board[r - 1][c - 1] == piece
                    and board[r - 2][c - 2] == piece
                    and board[r - 3][c - 3] == piece
                    and board[r - 4][c - 4] == piece
                    ) 
                ):
                    return c , r 
                
                elif(
                    (board[r][c] == piece
                    and board[r - 1][c - 1] == piece
                    and board[r - 2][c - 2] == piece
                    and board[r - 3][c - 3] == piece
                    and board[r - 4][c - 4] == Empty
                    )
                ):
                    return c - 4, r - 4 

    return None  # No immediate threat found

def tricky_threat(board, piece):
    for r in range(ROWS):
        for c in range(COLUMNS):
            # Check horizontally
            if c < COLUMNS-3:
                if board[r][c] == piece and board[r][c + 1] == piece and board[r][c + 2] == Empty and board[r][c + 3] == piece:
                    
                    return c + 2, r
                
                elif board[r][c] == piece and board[r][c + 1] == Empty and board[r][c + 2] == piece and board[r][c + 3] == piece:
                    
                    return c + 1, r

            # Check vertically
            if r < ROWS - 3:
                if board[r][c] == piece and board[r + 1][c] == piece and board[r + 2][c] == Empty and board[r + 3][c] == piece:
                    return c, r + 2
                elif board[r][c] == piece and board[r + 1][c] == Empty and board[r + 2][c] == piece and board[r + 3][c] == piece:
                    return c, r + 1
            # Check diagonally (positive slope)
            if c < COLUMNS - 3 and r >= 4:
                if (
                    board[r][c] == piece
                    and board[r - 1][c + 1] == piece
                    and board[r - 2][c + 2] == Empty
                    and board[r - 3][c + 3] == piece
                ):
                    return c + 2, r - 2
                elif (
                    board[r][c] == piece
                    and board[r - 1][c + 1] == Empty
                    and board[r - 2][c + 2] == piece
                    and board[r - 3][c + 3] == piece
                ):
                    return c + 1, r - 1
            # Check diagonally (negative slope)
            if c < COLUMNS and r >= 3:
                if (
                    board[r][c] == piece
                    and board[r - 1][c - 1] == piece
                    and board[r - 2][c - 2] == Empty
                    and board[r - 3][c - 3] == piece
                ):
                    return c - 2, r - 2
                elif (
                    board[r][c] == piece
                    and board[r - 1][c - 1] == Empty
                    and board[r - 2][c - 2] == piece
                    and board[r - 3][c - 3] == piece
                ):
                    return c - 1, r - 1
    return None  # No immediate threat found

def L_threat(board, piece):
    for r in range(ROWS):
        for c in range(COLUMNS):
            if r < ROWS - 3 and c < COLUMNS - 3 and r > 0 and c > 0:
                #L tradicional
                if board[r][c] == piece and board[r + 1][c] == piece and board[r + 2][c + 1] == piece and board[r + 2][c + 2] == piece and board[r + 2][c] == Empty and board[r + 3][c] == Empty and board[r - 1][c] == Empty and board[r + 2][c - 1] == Empty and board[r + 2][c + 3] == Empty:
                    return c, r + 2
                #L invertida _|
                elif board[r][c + 2] == piece and board[r + 1][c + 2] == piece and board[r + 2][c] == piece and board[r + 2][c + 1] == piece and board[r + 2][c + 2] == Empty and board[r - 1][c + 2] == Empty and board[r + 3][c + 2] == Empty and board[r + 2][c - 1] == Empty and board[r + 2][c + 3] == Empty:
                    return c + 2, r + 2
                #|¨
                elif board[r][c] == Empty and board[r + 1][c] == piece and board[r + 2][c] == piece and board[r][c + 1] == piece and board[r][c + 2] == piece and board[r - 1][c] == Empty and board[r + 3][c] == Empty and board[r][c - 1] == Empty and board[r][c + 3] == Empty:
                    return c, r
                #¨|
                elif board[r][c] == piece and board[r][c + 1] == piece and board[r][c + 2] == Empty and board[r + 1][c + 2] == piece and board[r + 2][c + 2] == piece and board[r][c - 1] == Empty and board[r][c + 3] == Empty and board[r - 1][c + 2] == Empty and board[r + 3][c + 2] == Empty:
                    return c + 2, r
                #/..
                elif board[r][c + 2] == piece and board[r + 1][c + 1] == piece and board[r + 2][c + 1] == piece and board[r + 2][c + 2] == piece and board[r + 2][c] == Empty and board[r + 2][c - 1] == Empty and board[r + 2][c + 3] == Empty and board[r - 1][c + 3] == Empty and board[r + 3][c - 1] == Empty:
                    return c, r + 2
                #..\
                elif board[r][c] == piece and board[r + 1][c + 1] == piece and board[r + 2][c] == piece and board[r + 2][c + 1] == piece and board[r + 2][c + 2] == Empty and board[r + 2][c + 3] == Empty and board[r + 2][c - 1] == Empty and board[r - 1][c - 1] == Empty and board[r + 3][c + 3] == Empty:
                    return c + 2, r + 2
                #¨/
                elif board[r][c] == piece and board[r][c + 1] == piece and board[r][c + 2] == Empty and board[r + 2][c] == piece and board[r + 1][c + 1] == piece and board[r][c - 1] ==  Empty and board[r][c + 3] == Empty and board[r - 1][c + 3] == Empty and board[r + 3][c - 1] == Empty:
                    return c + 2, r
                #\¨
                elif board[r][c] == Empty and board[r][c + 1] == piece and board[r][c + 2] == piece and board[r + 1][c + 1] == piece and board[r + 2][c + 2] == piece and board[r][c - 1] == Empty and board[r][c + 3] == Empty and board[r - 1][c] == Empty and board[r + 3][c + 3] == Empty:
                    return c, r
    
    return None

def winning_move(board, piece):
    convent_board=verticalize(board)
    horizontal=score_position_h(board,piece)
    vertical=score_position_vert(convent_board,piece)
    positive_diag=score_position_pd(board,piece)
    negative_diag=score_position_nd(board,piece)
    positions=[horizontal, vertical, positive_diag, negative_diag]
    print('horitzontal= ',positions[0])
    print('vertical= ', positions[1])
    print('dp= ', positions[2])
    print('dn= ', positions[3])
    for i in range(len(positions)):
        
        if positions[i] < 50 or (positions[i] == 50 and not block_threat(board, piece)):
            continue
        else:
            
            return True
            


def winning_pattern(board, piece):
    for r in range(ROWS):
        for c in range(COLUMNS):
            #atac obert

            #Horitzontal
            if c < COLUMNS - 4 and c > 0:
                #.!..
                if board[r][c] == piece and board[r][c + 1] == Empty and board[r][c + 2] == piece and board[r][c + 3] == piece and board[r][c - 1] == Empty and board[r][c + 4] == Empty:
                    return c + 1, r 
                #..!.
                if board[r][c] == piece and board[r][c + 2] == Empty and board[r][c + 1] == piece and board[r][c + 3] == piece and board[r][c - 1] == Empty and board[r][c + 4] == Empty:
                    return c + 2, r
            
            #Vertical
            if r < ROWS - 4 and r > 0:
                #.!..
                if board[r][c] == piece and board[r + 1][c] == Empty and board[r + 2][c] == piece and board[r + 3][c] == piece and board[r - 1][c] == Empty and board[r + 4][c] == Empty:
                    return c, r + 1
                #..!.
                elif board[r][c] == piece and board[r + 2][c] == Empty and board[r + 1][c] == piece and board[r + 3][c] == piece and board[r - 1][c] == Empty and board[r + 4][c] == Empty:
                    return c, r + 2
            
            #Diagonal positiva
            if r > 4 and r < ROWS - 1 and c < COLUMNS - 4 and c > 0:
                #.!..
                if board[r][c] == piece and board[r - 1][c + 1] == Empty and board[r - 2][c + 2] == piece and board[r - 3][c + 3] == piece and board[r + 1][c - 1] == Empty:
                    return c + 1, r - 1
                #..!.
                if board[r][c] == piece and board[r - 2][c + 2] == Empty and board[r - 1][c + 1] == piece and board[r - 3][c + 3] == piece and board[r + 1][c - 1] == Empty:
                    return c + 2, r - 2
            #Diagonal negativa
            if r < ROWS - 4 and r > 0 and c < COLUMNS - 4 and c > 0:
                #.!..
                if board[r][c] == piece and board[r + 1][c + 1] == Empty and board[r + 2][c + 2] == piece and board[r + 3][c + 3] == piece and board[r - 1][c - 1] == Empty and board[r + 4][c + 4] == Empty:
                    return c + 1, r + 1
                elif board[r][c] == piece and board[r + 2][c + 2] == Empty and board[r + 1][c + 1] == piece and board[r + 3][c + 3] == piece and board[r - 1][c - 1] == Empty and board[r + 4][c + 4] == Empty:
                    return c + 2, r + 2
    return None    
   
def block_threat(board, piece):
    #Check Four in a row
    first_threat = four_threat(board,piece)
    second_threat=tricky_threat(board, piece)
    third_threat=three_threat(board, piece)
    fourth_threat = L_threat(board, piece)
    if first_threat:
        return first_threat
    elif second_threat:
    #Check Three in a row 
        return second_threat
    elif third_threat:
        return third_threat
    else:
        return fourth_threat

pygame.init()


SQUARE=45
RADIUS=SQUARE/2-2
LINE=1

height=SQUARE*(ROWS+1)
width=SQUARE*(COLUMNS+1)

size=(width,height)

clock = pygame.time.Clock()

screen=pygame.display.set_mode(size)
DrawBoard()

turn=HUMAN
while Gamerunning:
    
    pygame.event.pump()
    first_move(board)
    for event in pygame.event.get():
        if event.type==pygame.QUIT:
            sys.exit()

        if turn==HUMAN:
            if event.type==pygame.MOUSEBUTTONDOWN:
                posx=math.trunc((event.pos[0]-SQUARE/2)/SQUARE)
                posy=math.trunc((event.pos[1]-SQUARE/2)/SQUARE)
                if posx == 15:
                    posx = 14
                if posy == 15:
                    posy =14

                if is_valid_move(board,posy,posx):

                    DrawPiece(board,posx,posy,HUMAN)
                    if CheckWin(board, HUMAN):
                        GetWinner(board, HUMAN)
                        DrawWinner(board, HUMAN)
                        pygame.time.wait(5000)
                        Gamerunning=False
                        PrintBoard(board)
                    turn+=1
                               
        else:
            pygame.time.delay(500)
            blocking_move = block_threat(board, HUMAN)
            winning_patt = winning_pattern(board, IA)
            if blocking_move and not winning_move(board, IA):
                    
                DrawPiece(board, blocking_move[0], blocking_move[1], IA)

            elif winning_patt and not winning_move(board, IA):
                DrawPiece(board, winning_patt[0], winning_patt[1], IA)

            else:
                best_move(board,IA)

            if CheckWin(board, IA):
                GetWinner(board, IA)
                DrawWinner(board, IA)
                pygame.time.wait(5000)
                Gamerunning=False
                # PrintBoard(board)
            turn+=1
                 
        pygame.display.update()
            
        turn=turn%2