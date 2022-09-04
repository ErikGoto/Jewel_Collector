
    
class Robot : element
{
    private int n_joias;
    private int pontos;
    private Map robot_map = new Map();
    public Robot(int[] posIni){
        this.Representacao = "R2 ";
        Posicao = posIni;
        n_joias = 0;
        pontos = 0;
    }

    public void down_desl(Map my_map){
        if (Posicao[1] < 9)
        {
            if (my_map.Mapa[Posicao[1]+1, Posicao[0]].Representacao == "-- ")
            Posicao[1]++;
        }
            
    }
    public void up_desl(Map my_map){
        if (Posicao[1] > 0)
        {
            if (my_map.Mapa[Posicao[1]-1, Posicao[0]].Representacao == "-- ")
                Posicao[1]--;
        }
            
    }
    public void left_desl(Map my_map){
        if (Posicao[0] > 0)
        {
            if (my_map.Mapa[Posicao[1], Posicao[0]-1].Representacao == "-- ")
                Posicao[0]--;
        }
            
    }
    public void right_desl(Map my_map){
        if (Posicao[0] < 9)
        {
            if (my_map.Mapa[Posicao[1], Posicao[0]+1].Representacao == "-- ")
                Posicao[0]++;
        }
    }

    public Map grab(Map my_map){
        robot_map = my_map;
        
        return my_map;
    }
}