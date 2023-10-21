using System;

namespace guessing_number;

public class GuessNumber
{
    //In this way we are passing the random number generator by dependency injection
    private IRandomGenerator random;
    public GuessNumber() : this(new DefaultRandom()){}
    public GuessNumber(IRandomGenerator obj)
    {
        this.random = obj;

        userValue = 0;
        randomValue = 0;
    }

    //user variables
    public int userValue;
    public int randomValue;

    public int maxAttempts;
    public int currentAttempts;

    public int difficultyLevel;

    public bool gameOver;

    //1 - Imprima uma mensagem de saudação
    public string Greet()
    {
        return "---Bem-vindo ao Guessing Game--- /n Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!";
    }

    //2 - Receba a entrada da pessoa usuária e converta para Int
    //5 - Adicione um limite de tentativas
    public string ChooseNumber(string userEntry)
    {
        throw new NotImplementedException();
    }

    //3 - Gere um número aleatório
    public string RandomNumber()
    {
        throw new NotImplementedException();
    }

    //6 - Adicione níveis de dificuldade
    public string RandomNumberWithDifficult()
    {
        throw new NotImplementedException();
    }

    //4 - Verifique a resposta da jogada
    public string AnalyzePlay()
    {
        throw new NotImplementedException();
    }

    //7 - Adicione uma opção para reiniciar o jogo
    public void RestartGame()
    {
        throw new NotImplementedException();
    }
}