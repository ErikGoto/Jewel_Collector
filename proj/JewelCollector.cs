public class JewelCollector {

public static void Main() {
    Map my_map = new Map(10);
    bool running = true;

    int[] posIniRobs = {0,0};
    Robot R2D2 = new Robot(posIniRobs);
    my_map.add_element(posIniRobs, (element)R2D2);
    
    do {
        my_map.move_element(R2D2);
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("Enter the command: ");
        string command = Console.ReadLine();

        
        if (command.Equals("quit")) {
            running = false;
        } else if (command.Equals("w")) {
            
            my_map.remove_element(R2D2.Posicao);
            R2D2.up_desl(my_map);
           
            
        } else if (command.Equals("a")) {
            
            my_map.remove_element(R2D2.Posicao);
            R2D2.left_desl(my_map);
            
        } else if (command.Equals("s")) {
            
            my_map.remove_element(R2D2.Posicao);
            R2D2.down_desl(my_map);
            
        } else if (command.Equals("d")) {
            
            my_map.remove_element(R2D2.Posicao);
            R2D2.right_desl(my_map);
            
        } else if (command.Equals("g")) {
            R2D2.grab(my_map);  
        }

        Console.Write($"\nPosicao do Robo {R2D2.Posicao[0]}, {R2D2.Posicao[1]}\n");
    } while (running);
    }

}