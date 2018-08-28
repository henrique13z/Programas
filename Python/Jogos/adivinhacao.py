print("*************************************")
print("* Bem vindo ao jogo de Adivinhação! *")
print("*************************************")

numero_secreto = 42
total_de_tentativas = 3

while (total_de_tentativas > 0):
    print("Tentativas: ", total_de_tentativas)
    guess_str = input("Digite o seu numero de 0 a 100: ")
    guess = int(guess_str)
    print("Você digitou :", guess_str)

    acertou = guess == numero_secreto
    maior   = guess >  numero_secreto
    menor   = guess <  numero_secreto

    if (acertou):
        print("Você acertou!")
        total_de_tentativas = 0
        print("Fim do jogo!")
        input()
    elif(maior):
        print("Você chutou acima!")
        total_de_tentativas = total_de_tentativas - 1
        input()
    elif(menor):
        print("Você chutou abaixo!")
        total_de_tentativas = total_de_tentativas - 1
        input()
    #os.system('cls')
print("Fim do jogo!")