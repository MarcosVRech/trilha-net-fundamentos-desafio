# Projeto Estacionamento - Desafio Fundamentos C#

### *Descrição*

Este projeto consiste em uma aplicação console simples para gerenciamento de um estacionamento.
Permite adicionar veículos, remover veículos com cálculo do preço pelo tempo estacionado, e listar os veículos presentes.

Foi desenvolvido como parte do desafio da DIO - WEX - End to End Engineering, focando em manipulação de listas, entrada e saída no console, e conceitos básicos de orientação a objetos.

### *Tecnologias*
C#

.NET 9.0 (foi necessário alterar essa versão, pois a do código disponibilizado era 6.0)


### *Como executar*

1. Ter o Visual Studio Code
2. Certifique-se de ter o .NET SDK instalado.
3. Você pode baixar em: https://dotnet.microsoft.com/download

### *Funcionalidades*

1. *Adicionar Veículo*

Solicita que o usuário digite a placa do veículo, valida e adiciona na lista interna do estacionamento.

2. *Remover Veículo*

Solicita a placa para remoção, verifica se o veículo está estacionado, pergunta o tempo que ficou estacionado, calcula o valor total e remove da lista.

3. *Listar Veículos*

Exibe todos os veículos atualmente estacionados.

### *Explicação das Implementações na Classe Estacionamento*

Este trecho apresenta as principais implementações feitas no código para que funcione corretamente e de forma robusta.

1. *Captura e tratamento da placa do veículo*
   
   Utilizamos Console.ReadLine() para capturar a entrada do usuário.

   Apliquei Trim() e ToUpper() para padronizar a placa e evitar erros na comparação.

2. *Validação e cálculo no método RemoverVeiculo()*
   
   Confirma se o veículo está na lista antes de tentar remover.

   Solicita e valida a entrada do tempo em horas (garantindo que seja um número inteiro positivo).

*Calcula o preço final usando a fórmula:*

precoInicial + precoPorHora * horas

Remove o veículo da lista após o cálculo.

3. *Listagem com laço de repetição*
   
Utilizei um foreach para listar todas as placas cadastradas.

4. *Feedback visual*
   
Usei cores no console para mensagens de entrada, sucesso e erro, facilitando a interação do usuário.


## *Exemplo de uso*

Digite a placa do veículo para estacionar:

ABC1234

Veículo ABC1234 estacionado com sucesso!


Digite a placa do veículo para remover:

ABC1234

Digite a quantidade de horas que o veículo permaneceu estacionado:

3

O veículo ABC1234 foi removido e o preço total foi de: R$ 23,00


Os veículos estacionados são:

(Se não houver veículos, aparece mensagem informando isso)


# *Possíveis melhorias futuras*

1. Validar formato da placa usando expressões regulares.


2. Implementar persistência dos dados (em arquivo ou banco de dados).


3. Criar interface gráfica para facilitar o uso.


4. Adicionar mais opções de gerenciamento, como buscar veículos, atualizar preços, etc.
