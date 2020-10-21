using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (){
    carro Fusca = new carro("Fusca",10);
    carro Ferrari = new carro("Ferrari",4);
    carro Gol = new carro("Gol",15);
    double maiorConsumo=99999.999;
    int maior=0;

    List<carro> carros = new List<carro>();

    carros.Add(Fusca);
    carros.Add(Ferrari);
    carros.Add(Gol);

    for (int i = 0; i < carros.Count;i++) {
      double validador = carros[i].retornaConsumo();

      double resultado = carros[i].milKM();
      Console.WriteLine("O carro {0} gastaria R$: {1};",carros[i].retornaModelo(),resultado);

      if (maiorConsumo > validador) {
        maiorConsumo = validador;
        maior = i;
      }
    }
    Console.WriteLine("---------------------------------");
    Console.WriteLine("O carro com maior consumo: {0};",carros[maior].retornaModelo());
    Console.WriteLine("Seu consumo é de: {0}km/l;",carros[maior].retornaConsumo());
  }
}