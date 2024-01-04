using System;

class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}

class Program
{
    static void Main()
    {
      
        string[] valores = Console.ReadLine().Split();
        int velocidadeMinima = int.Parse(valores[0]);
        int velocidadeMaxima = int.Parse(valores[1]);
        Robo r = new Robo(velocidadeMinima, velocidadeMaxima);
        string   velocidade = Console.ReadLine();
        char[] velocidadeArray = velocidade.ToCharArray();
        foreach (char letter in velocidadeArray)
        {
          if (letter == 'A')
          {
            r.Acelerar();
          }
          else if (letter == 'D')
          {
            r.Desacelerar();
          }
        }
     Console.WriteLine(r.VelocidadeAtual);
    }
}
