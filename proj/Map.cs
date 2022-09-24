class Map
{
    private static int mapSize = 10;
    private element[,] mapa = new element[mapSize,mapSize];
    Espaco_vazio empty = new Espaco_vazio("-- ");
    public Map(int size){
        element [,] mapaAux = new element[size,size];
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                mapaAux[i,j] = empty;
        mapa = mapaAux;
        mapSize = size;

        //Adiciona os elementos no mapa
        Random rdn = new Random();
        int [] rdnA = new int[] {rdn.Next(2, mapSize), rdn.Next(2, mapSize)};

        element[] e = new element[6];
        //Elementos adicionados aleatoriamente no mapa ficam no array 'e'
        e[0] = new Jewel(Jewel_colors.red);
        e[1] = new Jewel(Jewel_colors.green);
        e[2] = new Jewel(Jewel_colors.blue);
        e[3] = new Obstacle(ObstacleType.tree);
        e[4] = new Obstacle(ObstacleType.water);
        if (mapSize > 10)
            e[5] = new Obstacle(ObstacleType.radioactive);
            else
                e[5] = new Obstacle(ObstacleType.tree);
        for(int i = 0; i<mapSize/5; i++)
        {
            foreach (element item in e)
            {
                rdnA[0] = rdn.Next(2, mapSize);
                rdnA[1] = rdn.Next(2, mapSize);
                add_element(rdnA, item);
            }
        }
        add_forest();
        add_forest();
    }

    public void print_map(){
        for (int i = 0; i < mapSize; i++){
            for (int j = 0; j < mapSize; j++)
                Console.Write(mapa[i,j]);
            Console.WriteLine("\n");
        }

        int jn = JewelsNumber();
        Console.WriteLine($"Jewels Number: {jn}");
    }

    public void move_element(element e){
        int[] pos = e.Posicao; 
        mapa[pos[1], pos[0]] = e;
        print_map();
    }
    
    public void add_element(int[] pos, element e){
        mapa[pos[1], pos[0]] = e;
    }
    
    public void remove_element(int[] pos){
        mapa[pos[1], pos[0]] = empty;    
    }

    private void add_forest(){
        Random rdn = new Random();
        int[] rdnArray = new int[2];
        rdnArray[0] = rdn.Next(2, mapSize);
        rdnArray[1] = rdn.Next(2, mapSize);

        Obstacle tree = new Obstacle(ObstacleType.tree);
        try
        {
            add_element(rdnArray, tree);
            for (int i = 0; i < mapSize/4; i++)
            {
                rdnArray[0] += 1; 
                add_element(rdnArray, tree);
            }

                rdnArray[1] += 1; 
                add_element(rdnArray, tree);
                rdnArray[0] -= 1;
                add_element(rdnArray, tree);
        }
        catch (System.Exception)
        {} 
    }

    public int JewelsNumber(){
        int n = 0;
        for (int i = 0; i < mapSize; i++)
            for (int j = 0; j < mapSize; j++)
                if (mapa[i,j].ToString().Substring(0,1) == "J")
                    n++;
        return n;
    }
    public element[,] Mapa{get {return mapa;}}
}