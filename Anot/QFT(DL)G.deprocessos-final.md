QFT(DL)G.deprocessos-final
### Gerenciamento de processo 
- processo é a execução do programa compilado em binário (quando um executavel é instanciado, um processo é criado).
### Multiprogramação
 - É realizado multiplos processos pela cpu, enquanto um processo esta realizando I/O, outro processo utiliza a cpu, eliminando o tempo ocioso para a cpu
### Hierarqui de processos 
- um processo é criado pelo OP apartir de uma chamada de sistema, o processo é denominado de processo pai e o criado na cpu, denominado processo filho, esse processo pode gerar mais processos gerando assim um sisitema em arvore.
o Processo passa por 5 estagios INICIAL: quando o processo é recem-criado; PRONTO: Enquanto o processo aguarda para ser adicionado ao PC;EXECUTANDO:Depois qu o processo é add ao PC e suas instruções são processadas; ESPERA: Quando a operação requer algum recurso, como por exemplo, dados de um arquivo; FINALIZADO: Após o termino do processo ele aguarda para ser excluido da pilha.
### Escalonamento de processo
é a retirada de um processo e a adição de outro na CPU, muito importante em sistemas de multi programação, que permitem mais de um processo gravado na memoria.
As threads são componentes que sudividem processos, cada thread fica responsável pelos dados de processamantos de uma parte do processo, podendo se comunicar com outras threads e tendo acesso a memsa memoria. Se resumem a processos dentro de outos processo.
### Aplicação concorrente: 
quando realizada em mono thread, existe apenas a possibilidade de concorrência d processos, mas em multithreads, a concorrência é realizada por diferentes processos, retirando a necessidade de escalonamento de processos.
