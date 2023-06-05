AM(DL)dispositivosperifericos
 ### Model imediato 
O modelo imediato transfere o valor da operação junto com a instrução, no campo de operando, é viavel em situações de valores consta ntes, mas tem uma desvantagem é pelo consumo da memoria do operando, que vai armazenar o valor. Seu ponto positivo é que o processad or não precisa acessar a memoria para obter o valor da operação.
 ### Modo direto
O modo direto armazena o endereço do dado no campo de operando, ele é mais lento que o modo imediato, mas é muito utilizado nos proc essos. Consiste em armazenar o endereço do dado na MP, que possui a desvantagem de ter o tamanho de endereços reduzidos, em um opera ndo de 32bits, é possivel armazenar endereços de até 2^32 ou 4GB de endereçamento.
 ### Endereçamento indireto 
No modo indireto o endereçamento é feito por duas etapas, na primeira etapa é como se fosse direto, mas nesse modo, existe um bit es pecial que se o valor for '1', é feito uma nova busca pelo primeiro endereço referenciado no operando, assim se cria uma referencia  referenciando outra referencia que contem os dedos da operação. Por esse motivo ele é a mais lenta e não é mais utilizada em arquite tura atuais. 
 ### Referencia por registrador
Nesse modelo, a referência é feita pelo operando mas não referencia uma celula da memoria principal, e sim um registrador, a vantage m desse metodo é o fato de ser necessário menos memoria para o referenciamneto e a velociade de acesso é mais rapida, pelo fato de 
registradores serem mais velozes que MPa.
 ### Referencia indexada
Ese


 ### Indexada 
esse modo de referencia é utilizados em arrays, em que o valor do endereço da array é armazenado na MP e o valor de seus indices é 
armazenado em um registrador de indice, nesse caso o programa pode alterar o valor ce acesso em uma array dinamicamente. Utilizando  o registrador como forma de um ponteiro da array.
 ### Arquitetura de havard
na arquitetura de havard, os dados passaram a ser armazenados separado das instruções. Desse modo, após uma instrução ser decodifica da pela UC, o porcessador sabera o local exato onde deve buscar as informações.
