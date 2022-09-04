class Map
{
    private string[,] mapa = new string[10,10];
    public Map(){
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
                mapa[i,j] = "-- ";
    }

    private void print_map(){
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++)
                Console.Write(mapa[i,j]);
            Console.WriteLine("\n");
        }
    }

    public void move_element(int[] pos, string representacao){
        mapa[pos[1], pos[0]] = representacao + " ";
        print_map();
    }
    public void add_element(int[] pos, element e){
        mapa[pos[1], pos[0]] = e.Representacao + " ";
    }

    public void remove_element(int[] pos){
        mapa[pos[1], pos[0]] = "-- ";    
    }
}