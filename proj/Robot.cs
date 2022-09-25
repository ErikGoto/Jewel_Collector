class Robot : element
{
    private int n_joias;
    private int pontos;
    private int energy;

    /// <summary>
    /// Construtor da classe Robot
    /// </summary>
    /// <param name="posIni"> Posição inicial do Robô</param>
    public Robot(int[] posIni, int initialEnergy){
        this.Representacao = "ME ";
        Posicao = posIni;
        n_joias = 0;
        pontos = 0;
        energy = initialEnergy;
    }
    /// <summary>
    /// Deslocamento do robô para baixo
    /// </summary>
    /// <param name="my_map">Mapa em que o robô está inserido</param>
    public void down_desl(Map my_map){
        try
        {
            element comp = my_map.Mapa[Posicao[1]+1, Posicao[0]];
            if ((comp is Espaco_vazio || comp.Representacao == "!! ") && energy > 0)
                Posicao[1]++;
                energy--;
                DangerSensor(my_map, comp);
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
    /// <summary>
    /// Deslocamento do robô para cima
    /// </summary>
    /// <param name="my_map">Mapa em que o robô está inserido</param>        
    }
    public void up_desl(Map my_map){
        try       
        {
            element comp = my_map.Mapa[Posicao[1]-1, Posicao[0]];
            if ((comp is Espaco_vazio || comp.Representacao == "!! ") && energy > 0)
                Posicao[1]--;
                energy--;
                DangerSensor(my_map, comp);
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
            
    }
    /// <summary>
    /// Deslocamento do robô para a esquerda
    /// </summary>
    /// <param name="my_map">Mapa em que o robô está inserido</param>
    public void left_desl(Map my_map){
        try
        {
            element comp = my_map.Mapa[Posicao[1], Posicao[0]-1];
            if ((comp is Espaco_vazio || comp.Representacao == "!! ") && energy > 0)
                Posicao[0]--;
                energy--;
                DangerSensor(my_map, comp);
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
            
    }
    /// <summary>
    /// Deslocamento do robô para a direita
    /// </summary>
    /// <param name="my_map">Mapa em que o robô está inserido</param>
    public void right_desl(Map my_map){ 
        try
        {
            element comp = my_map.Mapa[Posicao[1], Posicao[0]+1];
            if ((comp is Espaco_vazio || comp.Representacao == "!! ") && energy > 0)
                Posicao[0]++;
                energy--;
                DangerSensor(my_map, comp);
        }
        catch (System.IndexOutOfRangeException)
        { 
            Console.WriteLine("Limite do mapa atingido");
        }
        
    }
    /// <summary>
    /// Pega um elemento do mapa. 
    /// Pode ser do tipo coletável, neste caso o elemento será guardado na bag. Mas o elemento também pode ser
    /// um tipo rechargeable, neste caso a energia será recarregada.
    /// Obs: Ao coletar um elemento do tipo tree, será recuperada +3 de energia e o obstáculo será substituído por uma old_tree("||")
    /// </summary>
    /// <param name="my_map"></param>
    public void grab(Map my_map){   
        Espaco_vazio ept = new Espaco_vazio("-- ");
        Obstacle oldTree = new Obstacle(ObstacleType.old_tree);
        Obstacle tree = new Obstacle(ObstacleType.nothing);
        try{
            element comp = my_map.Mapa[this.Posicao[1], this.Posicao[0]+1];
            tree.ObsType = ObstacleType.nothing;
            try
            {
                tree = (Obstacle)comp;
            }catch{}
            
            if (comp is Jewel || tree.ObsType == ObstacleType.tree)
            {
                element j = my_map.Mapa[Posicao[1], Posicao[0]+1];
                if (tree.ObsType == ObstacleType.tree)
                    my_map.Mapa[this.Posicao[1], this.Posicao[0]+1] = oldTree;
                    else
                        my_map.Mapa[this.Posicao[1], this.Posicao[0]+1] = ept;
                Colected(j);
                return;
            }
        }
        catch{}

        try{
            element comp = my_map.Mapa[this.Posicao[1], this.Posicao[0]-1];
            tree.ObsType = ObstacleType.nothing;
            try
            {
                tree = (Obstacle)comp;
            }catch{}
            if (comp is Jewel || tree.ObsType == ObstacleType.tree)
            {
                element j = my_map.Mapa[Posicao[1], Posicao[0]-1];
                if (tree.ObsType == ObstacleType.tree)
                    my_map.Mapa[this.Posicao[1], this.Posicao[0]-1] = oldTree;
                    else
                        my_map.Mapa[this.Posicao[1], this.Posicao[0]-1] = ept;
                Colected(j);
                return;
            } 
        }catch{}
        try
        {
            element comp = my_map.Mapa[this.Posicao[1]+1, this.Posicao[0]];
            tree.ObsType = ObstacleType.nothing;
            try
            {
                tree = (Obstacle)comp;
            }catch{}
           if (comp is Jewel || tree.ObsType == ObstacleType.tree)
            {
                element j = my_map.Mapa[Posicao[1]+1, Posicao[0]];
                if (tree.ObsType == ObstacleType.tree)
                    my_map.Mapa[this.Posicao[1]+1, this.Posicao[0]] = oldTree;
                    else
                        my_map.Mapa[this.Posicao[1]+1, this.Posicao[0]] = ept;
                Colected(j);
                return;
            }  
        }catch{}
        try
        {
            element comp = my_map.Mapa[this.Posicao[1]-1, this.Posicao[0]];
            tree.ObsType = ObstacleType.nothing;
            try
            {
                tree = (Obstacle)comp;
            }catch{}
            if (comp is Jewel || tree.ObsType == ObstacleType.tree)
            {
                element j = my_map.Mapa[Posicao[1]-1, Posicao[0]];
                if (tree.ObsType == ObstacleType.tree)
                    my_map.Mapa[this.Posicao[1]-1, this.Posicao[0]] = oldTree;
                    else 
                        my_map.Mapa[this.Posicao[1]-1, this.Posicao[0]] = ept;
                Colected(j);
                return;
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
                        Jewel j = (Jewel)e;
                        j.PrintRecharged();
                    }
                    Jewel je = (Jewel)e;
                    je.PrintCollected();
                    pontos += (int)je.Color;
                    n_joias += 1;
                    break;
                case "$$ ":
                    energy += 3;
                    Obstacle o = (Obstacle)e;
                    o.PrintRecharged();
                    break;
                default:
                    break;
            }
        }
    }
    private void DangerSensor(Map myMap, element e){
        string element = e.Representacao;
        if (element == "!! ")
        {
            energy -= 30;
        }
        try
        {
            if (myMap.Mapa[this.Posicao[1], this.Posicao[0]+1].Representacao == "!! ")
            {
                energy -= 10;
                Console.WriteLine("@#$!Cuidado@#$!");
            }
        }catch{}
        try
        {
            if (myMap.Mapa[this.Posicao[1], this.Posicao[0]-1].Representacao == "!! ")
            {
                energy -= 10;
                Console.WriteLine("@#$!Cuidado@#$!");
            }
        }catch{}
        try
        {
            if (myMap.Mapa[this.Posicao[1]+1, this.Posicao[0]].Representacao == "!! ")
            {
                energy -= 10;
                Console.WriteLine("@#$!Cuidado@#$!");
            }
        }catch{}
        try
        {
            if (myMap.Mapa[this.Posicao[1]-1, this.Posicao[0]].Representacao == "!! ")
            {
                energy -= 10;
                Console.WriteLine("@#$!Cuidado@#$!");
            }
        }catch{}
    }
    /// <summary>
    /// Imprime no console informações do robô sobre: Energia, Pontos e Números de joias coletadas
    /// </summary>
    public void RobotInfos(){
        Console.WriteLine($"->Energia: {energy}");
        Console.WriteLine($"->Pontos: {pontos}");
        Console.WriteLine($"->Num Joias coletadas: {n_joias}");
    }
    /// <summary>
    /// Retorna ou escreve a quantidade de energia do robô
    /// </summary>
    /// <value></value>
    public int Energy{get {return energy;} set{energy = value;}}
    /// <summary>
    /// Retorna ou escreve a quantidade de pontos
    /// </summary>
    /// <value></value>
    public int Pontos{get {return pontos;}}
}