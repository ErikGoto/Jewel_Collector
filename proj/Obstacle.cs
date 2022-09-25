public class Obstacle : element
{
    private ObstacleType obsType;
    /// <summary>
    /// Construtor da classe obstacle. Objetos da classe obstacle impedem o avanço do robô
    /// </summary>
    /// <param name="t">Tipo do obstáculo. Ex: Tree, water, radioactive</param>
    public Obstacle(ObstacleType t){
        switch (t)
        {
            case ObstacleType.tree:
                this.Representacao = "$$ "; //tree
                obsType = ObstacleType.tree;
                break;
            case ObstacleType.old_tree:
                this.Representacao = "|| "; //tree depois de ser usada
                obsType = ObstacleType.old_tree;
                break;
            case ObstacleType.water:
                this.Representacao = "## "; //water
                obsType = ObstacleType.water;
                break;
            case ObstacleType.radioactive:
                this.Representacao = "!! "; //radioactive
                obsType = ObstacleType.radioactive;
                break;
            case ObstacleType.nothing:
                this.Representacao = "__ "; //radioactive
                obsType = ObstacleType.nothing;
                break;
            default:
                break;
        }
        
    }

    public ObstacleType ObsType{get{return obsType;} set{obsType = value;}}
    public void PrintRecharged(){
        if(this.obsType == ObstacleType.tree)
            Console.WriteLine($"*+3 de energia*");
    }
}