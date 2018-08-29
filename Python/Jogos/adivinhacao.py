print("*************************************")
print("* Bem vindo ao jogo de Adivinhação! *")
print("*************************************")

numero_secreto = 42
total_de_tentativas = 3

#while (contador <= total_de_tentativas):
for contador in range(1, total_de_tentativas + 1):
    print("Tentativa  {} de {}".format(contador, total_de_tentativas))
    guess_str = input("Digite o seu numero de 0 a 100: ")
    guess = int(guess_str)
    print("Você digitou :", guess_str)

    acertou = guess == numero_secreto
    maior   = guess >  numero_secreto
    menor   = guess <  numero_secreto

    if (acertou):
        print("Você acertou!")
        print("Fim do jogo!")
        break
    elif(maior):
        print("Você chutou acima!")
    elif(menor):
        print("Você chutou abaixo!")
    #os.system('cls')