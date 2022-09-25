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
        ConsoleKeyInfo command = Console.ReadKey(true);
        Console.WriteLine("\n\n\n\n\n");
        
        Console.WriteLine(command.Key.ToString());
        switch (command.Key.ToString())
        {
            case "W":
                my_map.remove_element(R2D2.Posicao);
                R2D2.up_desl(my_map);
                break;
            case "A":
                my_map.remove_element(R2D2.Posicao);
                R2D2.left_desl(my_map);
                break;
            case "S":
                my_map.remove_element(R2D2.Posicao);
                R2D2.down_desl(my_map);
                break;
            case "D":
                my_map.remove_element(R2D2.Posicao);
                R2D2.right_desl(my_map);
                break;
            case "G":
                R2D2.grab(my_map); 
                break;
            default:break;
        }
    } while ((R2D2.Energy > -1));

    Console.WriteLine($"\n\n\n---------------------------------\n----------_____________----------\n----------|Fim de Jogo|----------\n---------------------------------\n->Pontuacao: {R2D2.Pontos}");
    }
}



