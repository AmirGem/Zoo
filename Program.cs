namespace Zoo
{
    internal class Program
    {
        interface IZoo
        {
            string Name();
            int AnimalsCount();
            string Address();
        }
        interface IAnimal
        {
            string AnimalName();
            string AnimalSound();
            int AnimalVazn();
            string AnimalColor();
        }
        class ZooKaraj : IZoo
            {
            public string Address()
            {
                string zooAddress = "karaj";
                return zooAddress;
            }

            public int AnimalsCount()
            {
                int animalCount = 50;
                return animalCount;
            }

            public string Name()
            {
                string zooName = "Zoo Karaj";
                return zooName;
            }

            class Gorbe : IAnimal
            {
                public string AnimalName()
                {
                    string animalName = "Gorbe";
                    return animalName;
                }
                public string AnimalSound()
                {
                    string animalSound = "Meow";
                    return animalSound;
                }
                public int AnimalVazn() 
                {
                    int animalVazn = 5;
                    return animalVazn;
                }
                public string AnimalColor() 
                {
                    string animalColor = "Red";
                    return animalColor;
                
                }
            }
            }
        static void Main(string[] args)
        {
            Gorbe gorbe = new Gorbe();
            ZooKaraj zooK = new ZooKaraj();
            Console.WriteLine(zooK.Name());
            Console.WriteLine(zooK.Address());
            Console.WriteLine(zooK.AnimalsCount());
            
        }
            
    }
    }

    
