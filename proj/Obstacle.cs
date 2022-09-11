public class Obstacle : element
{
    public Obstacle(ObstacleType t){
        switch (t)
        {
            case ObstacleType.tree:
                this.Representacao = "$$ "; //tree
                break;
            case ObstacleType.water:
                this.Representacao = "## "; //water
                break;
            default:
                break;
        }
        
    }
}