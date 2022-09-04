
    
public class Robot : element
{
    private int n_joias;
    private int pontos;
    public Robot(int[] posIni){
        Posicao = posIni;
        n_joias = 0;
        pontos = 0;
    }

    public void down_desl(){
        if (Posicao[1] < 9)
            Posicao[1]++;
    }
    public void up_desl(){
        if (Posicao[1] > 0)
            Posicao[1]--;
    }
    public void left_desl(){
        if (Posicao[0] > 0)
            Posicao[0]--;
    }
    public void right_desl(){
        if (Posicao[0] < 9)
            Posicao[0]++;
    }
}