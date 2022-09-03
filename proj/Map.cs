class Map
{
    public string[,] mapa = new string[10,10];
    public Map(){
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
                mapa[i,j] = "-- ";
    }

    public void print_map(){
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++)
                Console.Write(mapa[i,j]);
            Console.WriteLine("\n");
        }
    }
}