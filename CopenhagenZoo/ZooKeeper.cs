using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food;

namespace ZooKeepers
{
    internal class ZooKeeper
    {
        //Creates a variable for food
        FoodDispencer food;
        
        //Instance variables
        private string name;
        private int id;

        //Encapsulations
        public string Name { get { return name; } }
        public int Id { get { return id; } }

        //Constructor
        public ZooKeeper(string name, List<ZooKeeper> staff, FoodDispencer food)
        {
            this.name = name;
            this.food = food;
            this.id = idMaker(staff);
            staff.Add(this);            
        }
        //Method which makes the id
        private byte idMaker(List<ZooKeeper> staff)
        {
            byte id = 1;
            foreach (ZooKeeper zooKeeper in staff)
            {
                if (id == zooKeeper.Id)
                {
                    id++;
                }
                else
                {
                    return id;
                }
            }
            return id;
        }
        //Method that feeds the animals
        public void Feed(int animals)
        {
            food.FeedAnimals(animals);
        }
    }
}