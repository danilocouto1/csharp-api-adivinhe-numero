# Guessing Number Game

Este é um programa simples em C# que permite aos usuários jogar o jogo de adivinhação de números. Foi desenvolvido por Danilo Couto.

## Descrição

O programa é um jogo de adivinhação no qual a máquina gera um número aleatório e o jogador tenta adivinhá-lo. O jogador pode escolher um nível de dificuldade e tem um limite de tentativas para acertar o número.

## Autor

- **Danilo Couto**
- E-mail: dansantos45@hotmail.com
- LinkedIn: [Danilo Couto no LinkedIn](https://www.linkedin.com/in/danilocoutopsantos/)

## Funcionalidades

O programa inclui as seguintes funcionalidades:

1. **Saudação Inicial:** Exibe uma mensagem de boas-vindas ao jogador.

2. **Receber Entrada do Jogador:** Permite que o jogador insira um número e converte-o para um valor inteiro. Também verifica se o número está dentro do intervalo de -100 a 100.

3. **Geração de Número Aleatório:** Gera um número aleatório dentro de um intervalo, com base no nível de dificuldade escolhido.

4. **Análise da Jogada:** Compara o número inserido pelo jogador com o número gerado aleatoriamente e fornece pistas, indicando se o número é maior ou menor.

5. **Limite de Tentativas:** Limita o número de tentativas que o jogador pode fazer. Quando o limite é atingido, o jogo termina.

6. **Níveis de Dificuldade:** Permite que o jogador escolha entre diferentes níveis de dificuldade, que determinam o intervalo no qual o número aleatório é gerado.

7. **Reiniciar o Jogo:** Permite ao jogador reiniciar o jogo, restaurando todas as configurações iniciais.

## Como Usar

```csharp
// Exemplo de uso do programa
GuessNumber game = new GuessNumber();

// Exibe a mensagem de saudação
string greetingMessage = game.Greet();

// Recebe a entrada do jogador
string userInput = "50"; // Substitua pelo número inserido pelo jogador
string userMessage = game.ChooseNumber(userInput);

// Gera um número aleatório com base no nível de dificuldade
string randomMessage = game.RandomNumberWithDifficult();

// Analisa a jogada e fornece pistas ao jogador
string playResult = game.AnalyzePlay();

// Reinicia o jogo
game.RestartGame();
```

## Testes

O programa inclui testes unitários que verificam o comportamento de suas funções. Os testes são organizados em categorias que correspondem às diferentes funcionalidades do programa.

Para rodar os testes, você pode usar uma estrutura de teste como o xUnit. Certifique-se de que a biblioteca Moq esteja instalada para lidar com a simulação de dependências.

## Dependências

Este programa não possui dependências externas, além das bibliotecas padrão do C#.

## Licença

Este programa é de código aberto e está disponível sob a licença MIT. Você pode encontrar mais detalhes na [licença](LICENSE) deste projeto.
