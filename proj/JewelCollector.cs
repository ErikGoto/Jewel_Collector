public class JewelCollector {

public static void Main() {
    Map my_map = new Map();
    bool running = true;
  
    do {
        my_map.print_map();
        Console.WriteLine("Enter the command: ");
        string command = Console.ReadLine();
  
        if (command.Equals("quit")) {
            running = false;
        } else if (command.Equals("w")) {
              
        } else if (command.Equals("a")) {
              
        } else if (command.Equals("s")) {
            
        } else if (command.Equals("d")) {
          
        } else if (command.Equals("g")) {
              
        }
    } while (running);
    }
}