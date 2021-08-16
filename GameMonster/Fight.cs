using System;
using System.Collections.Generic;
namespace GameMonster
{

    class Fight
    {
        static void Main()
        {
            Console.WriteLine("                                       chose your job ");
            Console.WriteLine("1 : Thief    (attack : 20 ) (Defnse : 2  ) (Hp : 40 ) (mana : 20) (dodge : 40)");
            Console.WriteLine("2 : Bowman   (attack : 20 ) (Defnse : 7  ) (Hp : 60 ) (mana : 25) (dodge : 30)");
            Console.WriteLine("3 : Warrior  (attack : 10 ) (Defnse : 20 ) (Hp : 80 ) (mana : 20) (dodge : 15)");
            Console.WriteLine("4 : Mage     (attack : 40 ) (Defnse : 4  ) (Hp : 40 ) (mana : 80) (dodge : 15)");
            Console.WriteLine("5 : Pirate   (attack : 30 ) (Defnse : 7  ) (Hp : 60 ) (mana : 30) (dodge : 25)");

            Mushroom mushroom = new Mushroom();

            int Chose;

            do
            {
                Console.WriteLine("take a numbre between 1 and 5 ");
                Chose = int.Parse(Console.ReadLine());


            } while ((Chose > 5) || (Chose < 0));

            Player Player = new Player();

            if (Chose == 1)
            {
                Thief Thief = new Thief();

                Player.SetAttack(Thief.Attack);
                Player.SetDefense(Thief.Defense);
                Player.SetHp(Thief.Hp);
                Player.SetJob(Thief.Job);
                Player.SetMana(Thief.Mana);
                Player.SetDodge(Thief.Dodge);
            }
            else if (Chose == 2)
            {
                Bowman Bowman = new Bowman();

                Player.SetAttack(Bowman.Attack);
                Player.SetDefense(Bowman.Defense);
                Player.SetHp(Bowman.Hp);
                Player.SetJob(Bowman.Job);
                Player.SetMana(Bowman.Mana);
                Player.SetDodge(Bowman.Dodge);
            }
            else if (Chose == 3)
            {
                Warrior Warrior = new Warrior();

                Player.SetAttack(Warrior.Attack);
                Player.SetDefense(Warrior.Defense);
                Player.SetHp(Warrior.Hp);
                Player.SetJob(Warrior.Job);
                Player.SetMana(Warrior.Mana);
                Player.SetDodge(Warrior.Dodge);
            }
            else if (Chose == 4)
            {
                Mage Mage = new Mage();
                Player.SetAttack(Mage.Attack);
                Player.SetDefense(Mage.Defense);
                Player.SetHp(Mage.Hp);
                Player.SetJob(Mage.Job);
                Player.SetMana(Mage.Mana);
                Player.SetDodge(Mage.Dodge);
            }
            else if (Chose == 5)
            {
                Pirate Pirate = new Pirate();
                Player.SetAttack(Pirate.Attack);
                Player.SetDefense(Pirate.Defense);
                Player.SetHp(Pirate.Hp);
                Player.SetJob(Pirate.Job);
                Player.SetMana(Pirate.Mana);
                Player.SetDodge(Pirate.Dodge);
            }
            Console.Clear();
            int NumberRound = 0;
            while (((Player.Hp > 0) && (mushroom.mHp > 0)))
            {
                NumberRound++;
                Console.WriteLine("  ********** round " + NumberRound + " ********** ");
                Random Dodge = new Random();
                int DodgePlayer = Dodge.Next(101);

                Random Accuracy = new Random();
                int AccuracyMonster = Accuracy.Next(101);

                Random CDodge = new Random();
                int MonsterDodge = CDodge.Next(101);

                Boolean TestDodgePlayer = false;
                Boolean TestAccuracy = false;
                Boolean TestMonsterDodge = false;

                if (DodgePlayer <= Player.Dodge)
                {
                    TestDodgePlayer = true;
                    Console.WriteLine("you had dodged his attack");

                }

                if (AccuracyMonster <= mushroom.mAccuracy)
                {
                    TestAccuracy = true;

                }

                if (MonsterDodge <= mushroom.mDodge)
                {
                    TestMonsterDodge = true;
                    Console.WriteLine("the Monster dodged your attack");

                }

                if (TestMonsterDodge == false)
                {
                    Console.WriteLine("you hit with " + (Player.Attack - mushroom.mDefense) + " Dmg");
                    mushroom.SetHp(mushroom.GetHp() - (Player.Attack - mushroom.mDefense));
                }

                if ((TestAccuracy == true) && (TestDodgePlayer == false) && (mushroom.mHp > 0))
                {
                    Console.WriteLine("you get hited by " + (mushroom.mAttack - Player.Defense) + "Dmg");
                    Player.SetHp(Player.GetHP() - (mushroom.mAttack - Player.Defense));
                }
                Console.WriteLine("your hp is :" + Player.Hp);
                Console.WriteLine("Monster hp : " + mushroom.GetHp());

            }
            if (mushroom.GetHp() > 0)
            {
                Console.WriteLine("YOU LOST ");

            }
            else
            {
                Random drops = new Random();
                int Drops = drops.Next(101);
                Console.WriteLine("YOU WON ");
                if (Drops <= 25)
                {
                    Console.WriteLine("You Droped a " + mushroom.GetDrop(0));

                }
                else if (Drops <= 50)
                {
                    Console.WriteLine("You Droped a " + mushroom.GetDrop(1));

                }
                else if (Drops <= 75)
                {
                    Console.WriteLine("You Droped a " + mushroom.GetDrop(2));

                }
                else if (Drops <= 99)
                {
                    Console.WriteLine("You Droped a Nothing ");

                }
                else
                {
                    Console.WriteLine("You Droped a " + mushroom.GetDrop(3));

                }
            }
        }
    }
}