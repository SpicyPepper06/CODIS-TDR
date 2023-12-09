#Boolean que representa l'estat del joc
GameRunning=True

#Creació d'una matriu amb les nou caselles del tres en ratlla (a)
board=['?','?','?','?','?','?','?','?','?']
#Declaració de les variables que seran les fitxes dels dos jugadors
player1='X'
ia='O'
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
    if IsValidMove(board, box - 1):
        board[box - 1] = piece
    else:
        DrawSign(piece)
#Funció que revisa la validesa d'una casella triada
def IsValidMove(board, box):
    if board[box] == '?' and box <= 9 and box >= 0:
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

#Creació de l'IA
ia='O' #Declaració de la fitxa de la IA, en aquest cas serà un cercle (segon jugador)
#Es crea una funció que fica la fitxa en el millor lloc possible
def find_best_move():
    bestScore = -1
    bestMove = 0
    #Analitza totes les jugades en un torn i quan s'iguala la puntuació amb minimax, aquest analitza totes les jugades possible derivades de la primera jugada feta
    for i in range(9):
        if IsValidMove(board, i):
            board[i] = ia
            score = minimax(board, False)
            board[i] = '?'
            if score > bestScore:
                bestScore = score
                bestMove = i
    board[bestMove] = ia
    
#L'algoritme minimax en codi, isMaximizing és un boolean que indica si la següent jugada la fa la IA. L'algoritme no acaba fins que arriben a la casella 9
def minimax(board, isMaximizing):
    #S'assignen puntuacions a les victòries de cada fitxa
    if CheckWin(ia):
        return 1
    elif CheckWin(player1):
        return -1
    elif CheckTie():
        return 0
    #Si juga la IA, aquest fa el mateix que en la funció anterior, entrant al minimax un altre vegada
    if isMaximizing:
        bestScore = -1
        for i in range(9):
            if IsValidMove(board, i):
                board[i] = ia
                score = minimax(board, False)
                board[i] = '?'
                if score > bestScore:
                    bestScore = score
        return bestScore
    #SI juga l'humà, passa el mateix que en el cas anterior
    else:
        bestScore = 1
        for i in range(9):
            if IsValidMove(board, i):
                board[i] = player1
                score = minimax(board, True)
                board[i] = '?'
                if score < bestScore:
                    bestScore = score
        return bestScore

#Joc en acció
PrintBoard(board)
#Mentre el joc estigui en acció (f)
while GameRunning:
    #Es va canviant de torn a través d'una variable turn que es va sumant i modulant per dos
    if turn == 0:
        DrawSign('X')
    elif turn == 1:
        find_best_move()

    PrintBoard(board)
    #Reviso tots els casos possibles en els que pot acabar el joc
    if CheckWin('X') or CheckWin('O') or CheckTie():
        GameRunning = False

    turn += 1
    turn = turn % 2
