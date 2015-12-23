using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyMUD
{
    class CharCreator
    {

        void CreateChar()
        {
            Character player;
            int archetype;
            string wrmc = "";
            

            string name = MyTTY.ReadString("Enter your name: ");
            bool sex = MyTTY.ReadBool("Are you male? ");

            MyTTY.Clear();
            MyTTY.Show("The following class archetypes are available:\n");
            MyTTY.Show("1) Warrior\n");
            MyTTY.Show("2) Rogue\n");
            MyTTY.Show("3) Mage\n");
            MyTTY.Show("4) Cleric\n");

            archetype = MyTTY.ReadIntLimit("\nEnter the number of your selection: ", 4);

            switch (archetype)
            {
                case 1:
                    wrmc = "warriors";
                    break;
                case 2:
                    wrmc = "rogues";
                    break;
                case 3:
                    wrmc = "magi";
                    break;
                case 4:
                    wrmc = "clerics";
                    break;
            }

            player = ReadClass(archetype, wrmc);
            
        }

        void ArchetypeInfo()
        {
            MyTTY.Show("Stuff.");
        }


        public Character ReadClass(int archetype, string wrmc)
        {
            int choice;
            Character player;

            MyTTY.Show("The following " + wrmc + " are available to you:\n\n");
            
            switch (archetype)
            {
                case 1:
                    MyTTY.Show("1) Knight\n");
                    MyTTY.Show("2) Berserker\n");
                    break;

                case 2:
                    MyTTY.Show("1) Hunter\n");
                    MyTTY.Show("2) Assassin\n");
                    break;

                case 3:
                    MyTTY.Show("1) Sorcerer\n");
                    MyTTY.Show("2) Warlock\n");
                    break;

                case 4:
                    MyTTY.Show("1) Priest\n");
                    MyTTY.Show("2) Druid\n");
                    break;
            }

            choice = MyTTY.ReadIntLimit("\nEnter the number of your selection: ", 2);

            switch (archetype)
            {
                case 1:
                    if (choice < 2) player = new Knight(); else player = new Berserker();
                    break;
                case 2:
                    if (choice < 2) player = new Hunter(); else player = new Assassin();
                    break;
                case 3:
                    if (choice < 2) player = new Sorcerer(); else player = new Warlock();
                    break;
                case 4:
                    if (choice < 2) player = new Priest(); else player = new Druid();
                    break;
                default:
                    player = null;
            }

            return player;
        }
    }
}
