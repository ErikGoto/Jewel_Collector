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

    public void atualiza_map(int[] pos, string representacao){
        //Colocar condições para que ele não consiga andar sobre trees e water
        mapa[pos[1], pos[0]] = representacao + " ";
        print_map();
    }
    public void remove_element(int[] pos){
        mapa[pos[1], pos[0]] = "-- ";    
    }
}