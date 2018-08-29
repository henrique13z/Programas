import sys, pygame
#inicia a engine pygame
pygame.init()

#define variaveis de cor
WHITE = (255, 255, 255)
BLACK = (0, 0, 0)

#variaveis correspondentes ao display
tamanho = largura, altura = 640, 480
screen = pygame.display.set_mode(tamanho)

#variaveis do game loop
rodando = True
clock = pygame.time.Clock()

#variaveis de posição
cima     = False
baixo    = False
esquerda = False
direita  = False

pos_x = 10
pos_y = 10

#gameloop
while 1:
    #pinta o display de preto
    #screen.fill(BLACK)
    # clock.tick(60)
    # pygame.draw.rect(screen, WHITE, [10, 10, pos_y, pos_x])
    # if cima:
    #     pos_x = pos_x - 1
    # elif baixo:
    #     pos_x = pos_x + 1
    # elif esquerda:
    #     pos_y = pos_y - 1
    # elif direita:
    #     pos_y = pos_y + 1

    #if pygame.key.get_pressed()[pygame.K_ESCAPE]:
    #    rodando = False
    pygame.display.flip()

pygame.quit()