public class JewelCollector {

public static void Main() {
    Map my_map = new Map();
    bool running = true;

    int[] posIniRobs = {0,0};
    Robot R2D2 = new Robot(posIniRobs);

    do {
        my_map.atualiza_map(R2D2.Posicao,"R2");
        Console.WriteLine("Enter the command: ");
        string command = Console.ReadLine();
  
        if (command.Equals("quit")) {
            running = false;
        } else if (command.Equals("w")) {
            my_map.remove_element(R2D2.Posicao);
            R2D2.up_desl();
        } else if (command.Equals("a")) {
            my_map.remove_element(R2D2.Posicao);
            R2D2.left_desl();
        } else if (command.Equals("s")) {
            my_map.remove_element(R2D2.Posicao);
            R2D2.down_desl();
        } else if (command.Equals("d")) {
            my_map.remove_element(R2D2.Posicao);
            R2D2.right_desl();
        } else if (command.Equals("g")) {
              
        }

        Console.Write($"\nPosicao do Robo {R2D2.Posicao[0]}, {R2D2.Posicao[1]}\n");
    } while (running);
    }

}