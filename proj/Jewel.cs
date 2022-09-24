public class Jewel : element, ICollectable, IRechargeable
{
    private Jewel_colors color;
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
    public Jewel_colors Color{
            get{return color;}
            set{color = value;}
        }
    
    public void PrintCollected(){
        Console.WriteLine($"Joia Coletada: {this.Color}");
    }
    public void PrintRecharged(){
        if(this.Color == Jewel_colors.blue)
            Console.WriteLine($"*+5 de energia*");
    }
}