O script do teleporte funciona da seguinte forma:
Ele tem duas formas de funcionamentos que programei. Sequencialmente, e um ponto apenas de teleporte. No modo sequencial, ele recebe um objeto holder com mais de um objeto marcador de posição como child, e teleporta entre eles, passando de um para o outro sequencialmente, e ao chegar no último objeto, volta para o primeiro.
No modo de apenas um ponto, ele simplesmente recebe um objeto holder com apenas um objeto marcador como child, e sempre teleporta para ele.

Nesse script tudo é definido no inspetor do unity. Clicando no objeto que tem esse script anexado, aparece um campo para arrastar o objeto que segura os marcadores.

O script de alteração de texturas é bem parecido. Ao colocar o script em qualquer objeto, nele aparece uma lista, em que é possível adicionar quantos materiais (os materiais já contém todas as texturas, incluindo normal map, diffusion, etc. Por isso é melhor usar os materiais nesse caso do que a textura diretamente) for necessário. Ele funciona de forma semelhante ao script de teleport. Troca entre todos os materiais da lista sequencialmente, voltando ao primeiro elemento ao finalizar.
