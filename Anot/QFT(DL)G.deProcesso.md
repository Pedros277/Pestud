QFT(DL)G.deProcesso
### RISC 
- Processa menos informações,mas com o numero de campos de endereços reduzidos
### CISC
 - suporta mais instruções, mas seu processamento é mais lento.
### RISC E CISC
 - Trabalham em cima de pipeline (execuções divididas em clokcs, realizadas pelos componentes da cpu)
RISC trabalha em operações mais simples, mas com menos periodos no pipeline, podendo realizar instruções mais rapido, mas realizando apenas instruções mais simples. 
CISC - Realiza as operações mais complexa, mas precisa de mais ciclos no pipeline (20 a 30), realizando as operações fora de oredem, pois, realizar operações complexas demanda mais ciclos, gerando assim, tempos ociosos para as unidades do processo. Nessas operaçõe mais complexas, a UC não é capaz de calcular o tempo necessario para execução.
Os processadores RISC foram projetados com uma arquitetura simples, resultando em microprogramação simples em seus chips, ocasionando uma complexidade maior para os compildores que rodavam em cima do processador, podendo acessar a memoria apenas por dois comandos (load/store).
A arquitetura CISC possui micrioprogramação em seus chips, resultando em uma menor complexidade para os compiladores trabalharem com o sistema, mas o contrapont é a complexidade de instruções processadas torna inviável a utilização de pipelines, gerando incapacidade de realizar mais de uma intrução por clock.
