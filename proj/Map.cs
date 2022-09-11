class Map
{
    private element[,] mapa = new element[10,10];
    Espaco_vazio empty = new Espaco_vazio("-- ");
    public Map(){
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
                mapa[i,j] = empty;
    }

    public void print_map(){
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++)
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