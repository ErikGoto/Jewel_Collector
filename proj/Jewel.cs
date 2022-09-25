public class Jewel : element, ICollectable, IRechargeable
{
    private Jewel_colors color;
    /// <summary>
    /// Construtor da classe joias
    /// </summary>
    /// <param name="c">Define a cor da Jewel</param>
    public Jewel(Jewel_colors c){
        color = c;
        switch (c)
        {
            case Jewel_colors.red:
                this.Representacao = "Jr ";
                break;
            case Jewel_colors.blue:
                this.Representacao = "Jb ";
                break;
            case Jewel_colors.green:
                this.Representacao = "Jg ";
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// Get e set da cor da joia
    /// </summary>
    /// <value></value>
    public Jewel_colors Color{
            get{return color;}
            set{color = value;}
        }
    /// <summary>
    /// Imprime no console a cor da joia coletada
    /// </summary>
    public void PrintCollected(){
        Console.WriteLine($"Joia Coletada: {this.Color}");
    }
    /// <summary>
    /// Se a joia coletada for da cor *blue*, imprime na tela a quantidade de energia recuperada pelo robô
    /// </summary>
    public void PrintRecharged(){
        if(this.Color == Jewel_colors.blue)
            Console.WriteLine($"*+5 de energia*");
    }
}