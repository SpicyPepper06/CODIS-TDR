#Boolean que representa l'estat del joc
GameRunning=True

#Creació d'una matriu amb les nou caselles del tres en ratlla (a)
board=['?','?','?','?','?','?','?','?','?']
#Declaració de les variables que seran les fitxes dels dos jugadors
player1='X'
player2='O'
#El tres en ratlla sempre comença amb la fitxa X
turn = 0

#Funció per dibuixar una taula a la terminal per poder visualitzar l'estat del joc (b)
def PrintBoard(board):
    print(board[0],'|',board[1],'|',board[2])
    print('--+---+---')
    print(board[3],'|',board[4],'|',board[5])
    print('--+---+---')
    print(board[6],'|',board[7],'|',board[8])
    print('')
#Funció que demana la casella en la que es vol posar una fitxa (c)
def DrawSign(piece):
    box = int(input(f'Choose an empty box(1-9). Player {piece}'))
    if IsValidMove(board, box):
        board[box - 1] = piece
    else:
        DrawSign(piece)
#Funció que revisa la validesa d'una casella triada
def IsValidMove(board, box):
    if board[box - 1] == '?' and box <= 10 and box >= 1:
        return True

#Funció per revisar si algú guanya (d)
def CheckWin(piece):
    #Horitzontals
    for i in (0, 3, 6):
        if board[i] == piece and board[i + 1] == piece and board[i + 2] == piece:
            return True
    #Verticals    
    for i in range(3):
        if board[i] == piece and board[i + 3] == piece and board[i + 6] == piece:
            return True 
    #Diagonals     
    if board[0] == piece and board[4] == piece and board[8] == piece: 
        return True
    if board[2] == piece and board[4] == piece and board[6] == piece:
        return True   

#Funció per revisar un cas d'empat (e)
def CheckTie():
    if '?' not in board:
        return True

#Joc en acció
PrintBoard(board)
#Mentre el joc estigui en acció (f)
while GameRunning:
    #Es va canviant de torn a través d'una variable turn que es va sumant i modulant per dos
    if turn == 0:
        DrawSign('X')
    elif turn == 1:
        DrawSign('O')

    PrintBoard(board)
    #Reviso tots els casos possibles en els que pot acabar el joc
    if CheckWin('X') or CheckWin('O') or CheckTie():
        GameRunning = False

    turn += 1
    turn = turn % 2

         