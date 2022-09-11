public class Jewel : element
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
}