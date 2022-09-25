public class element
{
    private int[] posicao = new int[2];
    private string representacao = "-- ";

    /// <summary>
    /// Posição do elemento na forma [x,y]
    /// </summary>
    /// <value></value>
    public int[] Posicao{
       get{return posicao;}
       set{posicao = value;}
    }
    /// <summary>
    /// Define a representacao do elemento. Ex: Jr, Jb, Jg, ##, $$, ||.
    /// </summary>
    /// <value></value>
    public string Representacao{
        get{return representacao;}
        set{representacao = value;}
    }

    public override string ToString()
    {
        return this.Representacao;
    }
}