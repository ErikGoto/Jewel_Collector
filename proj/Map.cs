class Map
{
    private static int mapSize = 5;
    private element[,] mapa = new element[mapSize,mapSize];
    Espaco_vazio empty = new Espaco_vazio("-- ");
    public Map(int size){
        element [,] mapaAux = new element[size,size];
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                mapaAux[i,j] = empty;
        Console.WriteLine($"Mapa lenght: {mapa.Length}\n");

        mapa = mapaAux;
        mapSize = size;
    }

    public void print_map(){
        for (int i = 0; i < mapSize; i++){
            for (int j = 0; j < mapSize; j++)
                Console.Write(mapa[i,j]);
            Console.WriteLine("\n");
        }
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

    public element[,] Mapa{get {return mapa;}}
}