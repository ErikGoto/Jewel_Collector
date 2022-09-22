public class Obstacle : element
{
    private ObstacleType obsType;
    public Obstacle(ObstacleType t){
        switch (t)
        {
            case ObstacleType.tree:
                this.Representacao = "$$ "; //tree
                obsType = ObstacleType.tree;
                break;
            case ObstacleType.water:
                this.Representacao = "## "; //water
                obsType = ObstacleType.water;
                break;
            case ObstacleType.radioactive:
                this.Representacao = "!! "; //radioactive
                obsType = ObstacleType.radioactive;
                break;
            default:
                break;
        }
        
    }

    public ObstacleType ObsType{get{return obsType;}}
}