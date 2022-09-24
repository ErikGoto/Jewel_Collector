public class JewelCollector {

public static void Main() {
    int myMapSize = 10;
    Map my_map = new Map(myMapSize);
    bool running = true;

    int[] posIniRobs = {0,0};
    Robot R2D2 = new Robot(posIniRobs, 10);
    my_map.add_element(posIniRobs, (element)R2D2);
    
    do {
        if (my_map.JewelsNumber() == 0 && myMapSize < 31)
        {
            myMapSize++;
            my_map = new Map(myMapSize);
        }
        my_map.move_element(R2D2);
        Console.WriteLine($"Nível {myMapSize - 9} -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        R2D2.RobotInfos();
        Console.WriteLine("Enter the command: ");
        string command = Console.ReadLine();
        Console.WriteLine("\n\n\n\n\n");
        
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
    } while (R2D2.Energy > -1);

    Console.WriteLine($"\n\n\n---------------------------------\n----------_____________----------\n----------|Fim de Jogo|----------\n---------------------------------\n->Pontuacao: {R2D2.Pontos}");
    }

    

}



