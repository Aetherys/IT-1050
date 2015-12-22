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
            int special;
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

            special = ReadClass(archetype, wrmc);
            
        }

        void ArchetypeInfo()
        {
            MyTTY.Show("Stuff.");
        }

        public Character ReadClass(int archetype, string wrmc)
        {
            int special;

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

            special = MyTTY.ReadIntLimit("\nEnter the number of your selection: ", 2);

            switch (archetype)
            {
                case 1:
                    Character player = (special < 2) ? new Knight() : new Berserker();

            }

            return player;
        }
    }
}
