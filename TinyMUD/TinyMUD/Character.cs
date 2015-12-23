using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyMUD
{
    public abstract class Character:Entity
    {
        public int Exp;
        public int ExpForLvl;
        public double MaxHP;
        public double HP;
        public string ClassName;

        public Character()
        {
            Level = 1;
            Exp = 0;
            ExpForLvl = 100;
            MaxHP = 50;
            HP = 50;
        }

        public void DoLevel()
        {
            Level += 1;
            ExpForLvl = Level * 100;
            MaxHP += MaxHP * .1;
            HP = MaxHP;

        }

        public void DoStat()
        {
            double ExpToLvl = ExpForLvl - Exp;

            MyTTY.Show("You are " + Name + ", a level" + Level + ClassName + ".\n");
            MyTTY.Show("You have " + HP + "(" + MaxHP + ") hitpoints.\n");
            MyTTY.Show("You have " + Exp + "experience points.\n");
            MyTTY.Show("You need " + ExpToLvl + " to reach the next level.\n");

        }
    }
}
