public class JewelCollector {

public static void Main() {
    Map my_map = new Map();
    bool running = true;

    int[] posIniRobs = {0,0};
    Robot R2D2 = new Robot(posIniRobs);
    
    //Inserindo elementos no mapa
    int[] posJb = {3,4};
    int[] posJg = {9,1};
    int[] posJg2 = {0,1};
    Jewel Jb = new Jewel(Jewel_colors.blue);
    Jewel Jg = new Jewel(Jewel_colors.green);
    Jewel Jr = new Jewel(Jewel_colors.red);
    my_map.add_element(posJg, (element)Jg);
    my_map.add_element(posJg2, (element)Jg);
    my_map.add_element(posJb, (element)Jb);

    do {
        my_map.move_element(R2D2.Posicao,"R2");
        Console.WriteLine("Enter the command: ");
        string command = Console.ReadLine();
  
        if (command.Equals("quit")) {
            running = false;
        } else if (command.Equals("w")) {
            if ((R2D2.Posicao[1] > 0) && my_map.Mapa[R2D2.Posicao[1]-1, R2D2.Posicao[0]] == "-- ")
            {
                my_map.remove_element(R2D2.Posicao);
                R2D2.up_desl();
            }
            
        } else if (command.Equals("a")) {
            if ((R2D2.Posicao[0] > 0) && my_map.Mapa[R2D2.Posicao[1], R2D2.Posicao[0]-1] == "-- ")
            {
                my_map.remove_element(R2D2.Posicao);
                R2D2.left_desl();
            }
        } else if (command.Equals("s")) {
            if ((R2D2.Posicao[1] < 9) && my_map.Mapa[R2D2.Posicao[1]+1, R2D2.Posicao[0]] == "-- ")
            {
                my_map.remove_element(R2D2.Posicao);
                R2D2.down_desl();
            }
        } else if (command.Equals("d")) {
            if ((R2D2.Posicao[0] < 9) && my_map.Mapa[R2D2.Posicao[1], R2D2.Posicao[0]+1] == "-- ")
            {
                my_map.remove_element(R2D2.Posicao);
                R2D2.right_desl();
            }
        } else if (command.Equals("g")) {
            my_map = R2D2.grab(my_map);
                  
        }

        Console.Write($"\nPosicao do Robo {R2D2.Posicao[0]}, {R2D2.Posicao[1]}\n");
    } while (running);
    }

}