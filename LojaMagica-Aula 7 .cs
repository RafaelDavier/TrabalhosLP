using System;
using System.Collections.Generic;


public class Item
{
    public string Nome;
    public int Id;
    public int Preco;
    public string Desc;
}



public class Jogador
{
    public string nome;
    public int xp;
    public int ouro;
    public List<Item> Itens = new List<Item>();


}

public class lojinhaRPG
{


    static List<Jogador> Jogadores = new List<Jogador>();

    public static void Main(string[] args)
    {     
        bool mostrarMenu = true;
        while (mostrarMenu)
        {
            mostrarMenu = menuPrincipal();
        }

    }

}
    private static bool menuPrincipal()
    {

              Item lamina_zenite = new Item();
                    lamina_zenite.Id = 1;
                    lamina_zenite.Nome = "Lâmina Zênite";
                    lamina_zenite.Preco = 270;
                    lamina_zenite.Desc = "( Retire a Armadura de seus inimigos em 10%/ 20%/ 30% durante 5 segundos,10 segundos de recarga)";

              Item cutelo_negro = new Item();
                    cutelo_negro.Id = 2;
                    cutelo_negro.Nome = "Cutelo Negro";
                    cutelo_negro.Preco = 320 ;
                    cutelo_negro.Desc = "(Marca o inimigo com uma maldição que o fará tomar dano contínuo durante 3 segundos,5 segundos de recarga)";

              Item dente_de_nashor = new Item();
                    dente_de_nashor.Id = 3;
                    dente_de_nashor.Nome = "Dente de Nahor";
                    dente_de_nashor.Preco = 270 ;
                    dente_de_nashor.Desc = "(Toda vez que houver um acerto crítico,ganhe um bônus de velocidade de ataque,5 segundos de recarga)";

              Item dançarina_da_morte = new Item();
                    dançarina_da_morte.Id = 4;
                    dançarina_da_morte.Nome = "Dançarina da Morte";
                    dançarina_da_morte.Preco = 290;
                    dançarina_da_morte.Desc = "(Ao perder 70% da vida invoca um fantasma que deixará o inimigo cego,e diminuirá a velocidade de movimento,65 segundos de recarga)";

              Item pendão_de_ynorascus = new Item();
                    pendão_de_ynorascus.Id = 5;
                    pendão_de_ynorascus.Nome = " pendão_de_ynorascus";
                    pendão_de_ynorascus.Preco = 345;
                    pendão_de_ynorascus.Desc = "(Ao recebr dano fatal cria um escudo que impede sua morte e aumenta sua regeneração de vida em 30% por 3 segundos,80 segundos de recarga)";

              Item furtivinevial = new Item();
                    furtivinevial.Id = 6;
                    furtivinevial.Nome = "Furtivinevial";
                    furtivinevial.Preco = 270;
                    furtivinevial.Desc = "(Ao usar habilidades de movimento,como avanços,torna invisível por 3 segundos,20 segundos de recarga )";

              Item Canallizys = new Item();
                    canallizys.Id = 1;
                    canallizys.Nome = "Canallizys";
                    canallizys.Preco = 400;
                    canallizys.Desc = "('Cannaliza' energia por um tempo curandos aliados em volta consumindo mana á medida que cura)";




                    Console.Clear();
                    Console.WriteLine("1 - Criar persoangem");
                    Console.WriteLine("2 - Persoangens ");
                    Console.WriteLine("3 - Persoangem");
                    Console.WriteLine("4 - Loja");
                    Console.WriteLine("5 - fechar");
      
        switch (Console.ReadLine())
        {

            case "1":

                    Console.Clear();  
                    
                    Console.Write("Insira um Nickname : ");
                    var JogadorNome = Console.ReadLine();
                    JogadorNome = JogadorNome.ToLower();


                    Console.Write("Insira uma quantidade de experiência: ");
                    var JogadorXP = Console.ReadLine();
                  
                    Random GetEXP = new Random();
                    var JogadorCristais = GetEXP.Next(50, 350);


                    Jogadores.Add(new Jogador { nome = JogadorNome, xp = Convert.ToInt32(JogadorXP),ouro = JogadorCristais});
                    Console.Clear();
                    Console.WriteLine("Jogador criado com sucesso");
                    Console.WriteLine( "Você ganhou " + JogadorCristais);
                    Console.WriteLine("Aperte qualquer botão para continuar");
                    Console.Read();
            return true;




            case "2":
                Console.Clear();
                for (int i = 0; i < Jogadores.Count; i++)
                {

                    Console.WriteLine("Jogador:");            
                    Console.WriteLine("Apelido : " + Jogadores[i].nome);
                    Console.WriteLine("XP : " + Jogadores[i].xp);
                    Console.WriteLine("Cristais: " + Jogadores[i].ouro);                 
                }
                Console.Write("Saia com qualquer botão");
                Console.ReadKey();
            return true;
            




            case "3":
                    Console.Clear();
                    Console.WriteLine("Verique seu inventáriocom seu apelido : ");
                    var JogadorName0 = Console.ReadLine();
                    JogadorName0 = JogadorName0.ToLower();
            foreach(Jogador p in Jogadores)
            {
                if(p.nome == JogadorName0)
                {
                    Console.WriteLine("Itens:");

                    for (int i = 0; i < p.Itens.Count; i++)
                    {
                        Console.WriteLine("Item: " + p.Itens[i].Nome);
                    }
                    Console.WriteLine("Pressione qualquer botão para continuar");
                    Console.Read();
                }
                else{
                    Console.Clear();
                    Console.WriteLine("0 Jogadores,voltando ao menu");
                    Console.Read();
                }
            }
            return true;




            case "4":
                    Console.Clear();
                    Console.WriteLine("Digite o nome do jogador que irá acessar a loja: ");
                    JogadorName0 = Console.ReadLine();
                    JogadorName0 = JogadorName0.ToLower();
            foreach(Jogador p in Jogadores)
            {
                if(p.nome == JogadorName0)
                {       
                            Console.WriteLine("Para comprar algo,insira o ID do item");
                            Console.WriteLine("");
                            
                            Console.WriteLine(lamina_zenite.Id + " / " + lamina_zenite.Nome  + "/" + lamina_zenite.Desc);
                            Console.WriteLine("");
                            
                            Console.WriteLine(cutelo_negro.Id + " / " + cutelo_negro.Nome  + "/ " + 
                            cutelo_negro.Desc);
                            Console.WriteLine("");
                            
                            Console.WriteLine( dente_de_nashor.Id + " / " +  dente_de_nashor.Nome  + " / " +  dente_de_nashor.Desc);            
                            Console.WriteLine(dançarina_da_morte.Id + " / " + dançarina_da_morte.Nome  + " / " + dançarina_da_morte.Desc);
                                      
                            Console.WriteLine(pendão_de_ynorascus.Id + " / " + pendão_de_ynorascus.Nome + "/" + pendão_de_ynorascus.Desc);                             
                            Console.WriteLine(furtivinevial.Id + " / " + furtivinevial.Nome + " / " + furtivinevial.Desc);

                            Console.WriteLine(canallizys.Id + " / " + canallizys.Nome + " / " + canallizys.Desc);     

                            var ic = Console.ReadLine();
                 
                 


                    if( ic ==lamina_zenite.Id.ToString() ){

                        Console.WriteLine("Deseja comprar" + lamina_zenite.Nome + " por " + lamina_zenite.Preco + "?");
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.ouro >= lamina_zenite.Preco)
                            {
                                p.ouro = p.ouro - lamina_zenite.Preco;
                                p.Itens.Add(lamina_zenite);
                                Console.Clear();
                                Console.WriteLine("Lâmina Zênite adquirida!");
                               Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                               else
                            {
                                Console.WriteLine("Você não tem cristas para comprar esse item!");
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                        }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                    }

                        if( ic ==cutelo_negro.Id.ToString() ){

                        Console.WriteLine("Deseja comprar" + cutelo_negro.Nome + " por " + cutelo_negro.Preco + "?");
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.ouro >= cutelo_negro.Preco)
                            {
                                p.ouro = p.ouro - cutelo_negro.Preco;
                                p.Itens.Add(cutelo_negro);
                                Console.Clear();
                                Console.WriteLine("Cutelo Negro adquirido!");
                               Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                               else
                            {
                                Console.WriteLine("Você não tem cristas para comprar esse item!");
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                        }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                    }

                    
                      if( ic ==dente_de_nashor.Id.ToString() ){

                        Console.WriteLine("Deseja comprar" + dente_de_nashor.Nome + " por " + dente_de_nashor.Preco + "?");
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.ouro >= dente_de_nashor.Preco)
                            {
                                p.ouro = p.ouro - dente_de_nashor.Preco;
                                p.Itens.Add(dente_de_nashor);
                                Console.Clear();
                                Console.WriteLine("Dente de Nashor adquirido!");
                               Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                               else
                            {
                                Console.WriteLine("Você não tem cristas para comprar esse item!");
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                        }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                    }


                        if( ic ==dançarina_da_morte.Id.ToString() ){

                        Console.WriteLine("Deseja comprar" + dançarina_da_morte.Nome + " por " + dançarina_da_morte.Preco + "?");
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.ouro >= dançarina_da_morte.Preco)
                            {
                                p.ouro = p.ouro - dançarina_da_morte.Preco;
                                p.Itens.Add(dançarina_da_morte);
                                Console.Clear();
                                Console.WriteLine("Dançarina da Morte adquirida!");
                               Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                               else
                            {
                                Console.WriteLine("Você não tem cristas para comprar esse item!");
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                        }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                    }
  
                             if( ic ==pendão_de_ynorascus.Id.ToString() ){

                        Console.WriteLine("Deseja comprar" + dançarina_da_morte.Nome + " por " + pendão_de_ynorascus.Preco + "?");
                        var resp = Console.ReadLine();
                        if(resp == "sim")
                        {
                            if(p.ouro >= pendão_de_ynorascus.Preco)
                            {
                                p.ouro = p.ouro - pendão_de_ynorascus.Preco;
                                p.Itens.Add(pendão_de_ynorascus);
                                Console.Clear();
                                Console.WriteLine("Pendão de Ynorascus adquiridao!");
                               Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                               else
                            {
                                Console.WriteLine("Você não tem cristais para comprar esse item!");
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                        }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
   
                    }
                  

                             if( ic ==furtivinevial.Id.ToString() ){

                        Console.WriteLine("Deseja comprar" + furtivinevial.Nome + " por " + furtivinevial.Preco + "?");
                        var resp = Console.ReadLine();
                        if(resp == "sim")
                        {
                            if(p.ouro >= furtivinevial.Preco)
                            {
                                p.ouro = p.ouro - furtivinevial.Preco;
                                p.Itens.Add(dente_de_nashor);
                                Console.Clear();
                                Console.WriteLine("Furtivinevial adquirido!");
                               Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                               else
                            {
                                Console.WriteLine("Você não tem cristas para comprar esse item!");
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                        }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                    }


                     if( ic == canallizys.Id.ToString() ){

                        Console.WriteLine("Deseja comprar" + canallizys.Nome + " por " + canallizys.Preco + "?");
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.ouro >= canallizys.Preco)
                            {
                                p.ouro = p.ouro - canallizys.Preco;
                                p.Itens.Add(canallizys);
                                Console.Clear();
                                Console.WriteLine("Canallizys adquirido!");
                               Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                               else
                            {
                                Console.WriteLine("Você não tem cristas para comprar esse item!");
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                        }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Continue em qualquer botão");            
                                Console.Read();
                            }
                    }

                    

                   
                 }
            }
             return true;
         
                    case "5":
                        return false;



                    
                    default:
                        return true;


        }
    
    }


}