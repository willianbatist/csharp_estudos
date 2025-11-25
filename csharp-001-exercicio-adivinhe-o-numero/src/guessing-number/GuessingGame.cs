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

    public int maxAttempts = 5;
    public int currentAttempts = 0;

    public int difficultyLevel = 1;

    public bool gameOver = false;

    //1 - Imprima uma mensagem de saudação
    public string Greet()
    {
        return "---Bem-vindo ao Guessing Game--- /n Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!";
    }

    //2 - Receba a entrada da pessoa usuária e converta para Int
    //5 - Adicione um limite de tentativas
    public string ChooseNumber(string userEntry)
    {
        currentAttempts++;

        bool canConvert = Int32.TryParse(userEntry, out int valueConverted);
        if (currentAttempts > maxAttempts)
        {
            return "Você excedeu o número máximo de tentativas! Tente novamente.";
        }

        if (!canConvert)
        {
            return "Entrada inválida! Não é um número.";
        }
        else if (valueConverted < -100 || valueConverted > 100)
        {
            return "Entrada inválida! Valor não está no range.";
        }
        else
        {
            userValue = valueConverted;
            return "Número escolhido!";
        }
    }

    //3 - Gere um número aleatório
    public string RandomNumber()
    {

        randomValue = random.GetInt(-100, 100);

        return "A máquina escolheu um número de -100 à 100!";
    }

    //6 - Adicione níveis de dificuldade
    public string RandomNumberWithDifficult()
    {
        string message = "";
        switch (difficultyLevel)
        {
            case 1:
                message = "A máquina escolheu um número de -100 à 100!";
                break;

            case 2:
                message = "A máquina escolheu um número de -500 à 500!";
                break;

            case 3:
                message = "A máquina escolheu um número de -1000 à 1000!";
                break;
        }
        return message;
    }

    //4 - Verifique a resposta da jogada
    public string AnalyzePlay()
    {

        if (gameOver == true) return "O jogo terminou. Deseja jogar novamente?";

        if (userValue < randomValue)
        {
            return "Tente um número MAIOR";
        }
        else if (userValue > randomValue)
        {
            return "Tente um número MENOR";
        }
        else
        {
            gameOver = true;
            return "ACERTOU!";
        }

    }

    //7 - Adicione uma opção para reiniciar o jogo
    public void RestartGame()
    {
        maxAttempts = 5;
        gameOver = false;
        currentAttempts = 0;
        difficultyLevel = 1;
        userValue = 0;
        randomValue = 0;
        return;
    }
}