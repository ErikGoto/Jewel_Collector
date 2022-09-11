public class element
{
    private int[] posicao = new int[2];
    private string representacao = "-- ";

    public int[] Posicao{
       get{return posicao;}
       set{posicao = value;}
    }
    public string Representacao{
        get{return representacao;}
        set{representacao = value;}
    }

    public override string ToString()
    {
        return this.Representacao;
    }
}