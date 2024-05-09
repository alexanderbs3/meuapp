using System;

class Contador {
    private int contador;

    // Construtor
    public Contador() {
        contador = 0;
    }

    // Método para incrementar o contador
    public void Incrementar() {
        contador++;
    }

    // Método para decrementar o contador
    public void Decrementar() {
        contador--;
    }

    // Método para obter o valor atual do contador
    public int ObterValor() {
        return contador;
    }
}

class Program {
    static void Main(string[] args) {
        Contador meuContador = new Contador();

        // Incrementando o contador algumas vezes
        meuContador.Incrementar();
        meuContador.Incrementar();
        meuContador.Incrementar();

        // Decrementando o contador algumas vezes
        meuContador.Decrementar();

        // Exibindo o valor atual do contador
        Console.WriteLine("O valor atual do contador é: " + meuContador.ObterValor());
    }
}
