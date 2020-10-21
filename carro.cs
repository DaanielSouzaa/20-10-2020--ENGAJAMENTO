using System;

class carro {
  string modelo;
  double consumo;

  public carro(string modeloCarro, double consumoCarro) {
    modelo = modeloCarro;
    consumo = consumoCarro;
  }

  public void exibeCarro() {
    Console.WriteLine(this.modelo);
    Console.WriteLine(this.consumo);
  }

  public double retornaConsumo(){
    return consumo;
  }

  public double milKM() {
    double preco = 4.89;
    double multiplicacao = 1000 / this.consumo;
    double result = preco * multiplicacao;

    return result;
  }

  public string retornaModelo(){
    return modelo;
  }
}