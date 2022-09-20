
    
class Robot : element
{
    private int n_joias;
    private int pontos;
    private int energy;
    public Robot(int[] posIni){
        this.Representacao = "R2 ";
        Posicao = posIni;
        n_joias = 0;
        pontos = 0;
        energy = 50;
    }

    public void down_desl(Map my_map){
        try
        {
            if (my_map.Mapa[Posicao[1]+1, Posicao[0]].Representacao == "-- " && energy > 0)
            Posicao[1]++;
            energy--;
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
            
    }
    public void up_desl(Map my_map){
        try       
        {
            if (my_map.Mapa[Posicao[1]-1, Posicao[0]].Representacao == "-- " && energy > 0)
                Posicao[1]--;
                energy--;
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
            
    }
    public void left_desl(Map my_map){
        try
        {
            if (my_map.Mapa[Posicao[1], Posicao[0]-1].Representacao == "-- " && energy > 0)
                Posicao[0]--;
                energy--;
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
            
    }
    public void right_desl(Map my_map){
        try
        {
            if (my_map.Mapa[Posicao[1], Posicao[0]+1].Representacao == "-- " && energy > 0)
                Posicao[0]++;
                energy--;
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
    }

    public void grab(Map my_map){   
        Espaco_vazio ept = new Espaco_vazio("-- ");
        try{
            string comp = "";
            comp = my_map.Mapa[this.Posicao[1], this.Posicao[0]+1].Representacao.Substring(0,1);
            if (comp == "J" || comp =="$")
            {
                element j = my_map.Mapa[Posicao[1], Posicao[0]+1];
                my_map.Mapa[this.Posicao[1], this.Posicao[0]+1] = ept;
                Colected(j);
            } 
        }
        catch{}
        try{
            string comp = "";
            comp = my_map.Mapa[this.Posicao[1], this.Posicao[0]-1].Representacao.Substring(0,1);
            if (comp == "J" || comp == "$")
            {
                element j = my_map.Mapa[Posicao[1], Posicao[0]-1];
                my_map.Mapa[this.Posicao[1], this.Posicao[0]-1] = ept;
                Colected(j);
            } 
        }catch{}
        try
        {
            string comp = "";
            comp = my_map.Mapa[this.Posicao[1]+1, this.Posicao[0]].Representacao.Substring(0,1);
           if (comp == "J" || comp == "$")
            {
                element j = my_map.Mapa[Posicao[1]+1, Posicao[0]];
                my_map.Mapa[this.Posicao[1]+1, this.Posicao[0]] = ept;
                Colected(j);
            }  
        }catch{}
        try
        {
            string comp = "";
            comp = my_map.Mapa[this.Posicao[1]-1, this.Posicao[0]].Representacao.Substring(0,1);
           if (comp == "J" || comp == "$")
            {
                element j = my_map.Mapa[Posicao[1]-1, Posicao[0]];
                my_map.Mapa[this.Posicao[1]-1, this.Posicao[0]] = ept;
                Colected(j);
            }  
        }catch{}

        void Colected(element e){
            switch (e.Representacao)
            {
                case "Jb ":   
                case "Jg ":
                case "Jr ":
                    if (e.Representacao == "Jb ")
                    {
                        energy += 5;
                        Console.WriteLine("*+5 de energia*");
                    }
                    Jewel je = (Jewel)e;
                    Console.WriteLine($"*Joia Coletada: {je.Color}*");
                    pontos += (int)je.Color;
                    n_joias += 1;
                    break;
                case "$$ ":
                    energy += 3;
                    Console.WriteLine("*+3 de energia*");
                    break;
                default:
                    break;
            }
        }
    }

    public void RobotInfos(){
        Console.WriteLine($"->Energia: {energy}");
        Console.WriteLine($"->Pontos: {pontos}");
        Console.WriteLine($"->Num Joias coletadas: {n_joias}");
    }
    public int Energy{get {return energy;} set{energy = value;}}

}