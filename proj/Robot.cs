
    
class Robot : element
{
    private int n_joias;
    private int pontos;
    public Robot(int[] posIni){
        this.Representacao = "R2 ";
        Posicao = posIni;
        n_joias = 0;
        pontos = 0;
    }

    public void down_desl(Map my_map){
        try
        {
            if (my_map.Mapa[Posicao[1]+1, Posicao[0]].Representacao == "-- ")
            Posicao[1]++;
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
            
    }
    public void up_desl(Map my_map){
        try       
        {
            if (my_map.Mapa[Posicao[1]-1, Posicao[0]].Representacao == "-- ")
                Posicao[1]--;
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
            
    }
    public void left_desl(Map my_map){
        try
        {
            if (my_map.Mapa[Posicao[1], Posicao[0]-1].Representacao == "-- ")
                Posicao[0]--;
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
            
    }
    public void right_desl(Map my_map){
        try
        {
            if (my_map.Mapa[Posicao[1], Posicao[0]+1].Representacao == "-- ")
                Posicao[0]++;
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
    }

    public void grab(Map my_map){   
        Espaco_vazio ept = new Espaco_vazio("-- ");
        try{
            //Arrumar o bug, onde não é possível pegar gemas se voce estiver na borda do mapa
            if (my_map.Mapa[this.Posicao[1], this.Posicao[0]+1].Representacao.Substring(0,1) == "J")
            {
                Jewel j = (Jewel)my_map.Mapa[Posicao[1], Posicao[0]+1];
                my_map.Mapa[this.Posicao[1], this.Posicao[0]+1] = ept;
                Console.WriteLine($"*Gema Adquirida: {j.Color}*");
            } 
            if (my_map.Mapa[this.Posicao[1], this.Posicao[0]-1].Representacao.Substring(0,1) == "J")
            {
                Jewel j = (Jewel)my_map.Mapa[Posicao[1], Posicao[0]-1];
                my_map.Mapa[this.Posicao[1], this.Posicao[0]-1] = ept;
                Console.WriteLine($"*Gema Adquirida: {j.Color}*");
            } 
            if (my_map.Mapa[this.Posicao[1]+1, this.Posicao[0]].Representacao.Substring(0,1) == "J")
            {
                Jewel j = (Jewel)my_map.Mapa[Posicao[1]+1, Posicao[0]];
                my_map.Mapa[this.Posicao[1]+1, this.Posicao[0]] = ept;
                Console.WriteLine($"*Gema Adquirida: {j.Color}*");
            } 
            if (my_map.Mapa[this.Posicao[1]-1, this.Posicao[0]].Representacao.Substring(0,1) == "J")
            {
                Jewel j = (Jewel)my_map.Mapa[Posicao[1]-1, Posicao[0]];
                my_map.Mapa[this.Posicao[1]-1, this.Posicao[0]] = ept;
                Console.WriteLine($"*Gema Adquirida: {j.Color}*");
            } 
        }
        catch{
            Console.WriteLine("Você está no limite do mapa, não há nada auqi");
        }
    }
}