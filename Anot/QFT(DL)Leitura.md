QFT(DL)Leitura
 ### Processadores
A CPU é com posta por 3 sistemas;
### UC
que é responsavel por processar os dados e informações do processo e direcionalos para registradores ou ULA e encaminhalos para o barramento correto.
### ULA
Responsavel pele calculo logico ou aritimetico. Ela recebe doi valores e da a resposta baseada na instrução da UC, a resposta é enviada para um barramento através de um registrador designado pela UC.
### Registradores 
São um tipo de memoria de baixo armazenamento e muito veloz (meoria mais rapida) é composto por dois tipos, específicos e não especificos.
Os específicos sao compostos por PC(Contador de programas), IR(Registrador de instruções), MAR(Registrador de memoria de endereços), MBR(Registra os dados da processo, ou o ultimo dado lido) PSW(Informa o estado do processo atual e resultados das ultimas operação  feitas pela ULA). 
 ### Funcionamente de uma UC
A UC é responsável por controlar os as intruçoes de um processo, que para ser processado passa pelos processos de busca,indireto,execução e interrupção. Mas esses processos podem ser divididos em micro operações que detalha ainda mais o funcionamento da UC,
que se baseia em pequenas operações para realizar determinado processo (busca,indireto,execução e interrupção).
 ### Ciclo de busca
O ciclo de busca pode ser resumido em uma instrução de leitura. Onde o processo a ser processado esta salvo na PC que trabalha como
uma pilha, a memoria do pc é passada para o registrador MAR pois é ele que tem acesso ao barramento de memoria do processador. O processador busca o endereço e salva o resultado no registrador MBR, para liberar o MBR, os dados são passador para o registrador IR. E o PC é incrementado para a proxima instrução.
Esses ciclos são realizados por clock, e se não gerar conflito na operação pode ser realizado mais de um, por exemplo,
MBR -> IR
PC > PC +
São executados no memsmo clock.
 ### Ciclo indireto 
Ociclo indireto precede o de execução quando não possui endereçamento direto. nesse caso o IR(endereço indireto) é passado para MAR
que busca o endereço na memória e passa para MBR(endereço direto) que então passa para IR novamente. E assim a execução segue com o
endereçamento especificado para execução.
### Ciclo de interrupção 
 o PC é salvo no MBR para armazenar a posiçao da proxima instrução, o MAR recebe o endereço de onde deve ser salvo e o IR executa a interrupção. No proximo clock o PC recebe o MBR para realizar a proxima execução. Esse processo se inicia se a interrupção estiver habilitada para ele.
 ### Ciclo de execução
 o ciclo de execução é mais complexo que os outros. Pois não segue o mesmo padrão  sempre. A UC pode decodificar diversas instruções gerando diferentes padrões. Mais o ciclo de execução é realizado em micro operações como os demais.
