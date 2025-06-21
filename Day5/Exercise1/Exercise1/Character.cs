using System;


namespace Exercise1
{
    public class Character
    {
        public Character(string name, int health, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.attackPower = attackPower;
        }

        public string name { get; set; }
        public int health { get; set; }

        public int attackPower { get; set; }


     
        public void Attack(Character target)
        {
            Console.WriteLine($"{this.name} attack {target.name} and dealt {this.attackPower} damage!");
            target.takeDamage(this.attackPower);
            
        }

        public void takeDamage(int damage)
        {
            health -= damage;
            if (health < 0)
                health = 0;

        }

        public bool isAlive()
        {
            return health > 0;
        }

     

    }
}
