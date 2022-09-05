using ZooKeepers;
using Food;
namespace CopenhagenZoo

{
    internal class Program
    {
        static void Main(string[] args)
        {
            GUI menu = new GUI();//Creates and object for the menus
            FoodDispencer food = new FoodDispencer();//Creates an object for the food dispencer
            bool exit = false;//Bool to exit the program if set to true

            List<Animal> animals = new List<Animal>();//A list to store the animals
            //Creates different animals
            Animal zebra1 = new Animal("Zebra", true, animals);
            Animal zebra2 = new Animal("Zebra", false, animals);
            Animal hippo1 = new Animal("Flodhest", false, animals);
            Animal hippo2 = new Animal("Flodhest", true, animals);
            Animal tiger = new Animal("Tiger", true, animals);


            List<ZooKeeper> zooKeepers = new List<ZooKeeper>();//List to store the zooKeepers
            //Creates the zooKeepers
            ZooKeeper zk1 = new ZooKeeper("alskæfds", zooKeepers, food);
            ZooKeeper zk2 = new ZooKeeper("kjadakjd", zooKeepers, food);

            ConsoleKeyInfo userInterface;//
            do//i use a do while to make the code run while exit is not true
            {
                menu.StartMenu();//Display the start menu in console
                userInterface = Console.ReadKey();//This reads wich key the user presses
                string gender;//This variable stores the gender that we set the animal to be
                switch (userInterface.Key)
                {                        
                    case ConsoleKey.D1://If the user presses 1 it activates this code
                        Console.Clear();//clears console
                        foreach (Animal animal in animals)
                        {
                            switch(animal.Gender)//Converts the bool to a string
                            {
                                case true://If the bool is true it sets the gender to be a male
                                    gender = "han";
                                    break;
                                case false://If it is false it sets the gender to be a female
                                    gender = "hun";
                                    break;
                            }
                            Console.WriteLine("Race: " + animal.Race + "\r\nKøn: " + gender + "\r\n");//This code wtrites the animale with the race and gender information in console
                        }
                        Thread.Sleep(10000);//Makes the thread sleep for 10 seconds
                        Console.Clear();//clears the console
                        break;

                    case ConsoleKey.D2://If the user presses 2 it runs this code
                        Console.Clear();//Clears console window
                        foreach (ZooKeeper zooKeeper in zooKeepers)//for each zoo keeper in the list it writes the information in console
                        {
                            Console.WriteLine("Navn: " + zooKeeper.Name + "\r\nID: " + zooKeeper.Id + "\r\n");
                        }
                        Thread.Sleep(10000);//Pauses the code for 10 seconds
                        Console.Clear();//Clears console
                        break;

                    case ConsoleKey.D3://If the user presses 3 it runs this code
                        Console.Clear();//Clears console
                        menu.FoodMenu();//Displays the food menu in console
                        userInterface = Console.ReadKey();//Reads what the user presses
                        switch (userInterface.Key)
                        {
                            case ConsoleKey.D1://If the user presses 1 it runs this code wich feeds the zebras
                                zk1.Feed(1);
                                break;
                            case ConsoleKey.D2://if the user presses 2 it runs this code wich feeds the hippos
                                zk2.Feed(2);
                                break;
                            case ConsoleKey.D3://If the user presses 3 it runs this code wich feeds the tigers
                                zk1.Feed(3);
                                break;
                        }
                        break;

                    case ConsoleKey.D4://If the user presse 4 it runs this code
                        exit = true;//Sets the bool "exit" to be true which closes the console
                        break;
                }
            } while (exit != true);//If exit is not true it runs the code inside of the do-while again
        }
    }
}