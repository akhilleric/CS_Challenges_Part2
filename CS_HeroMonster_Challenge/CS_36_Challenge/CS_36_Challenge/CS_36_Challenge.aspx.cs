using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_36_Challenge
{
    public partial class CS_36_Challenge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character myHero = new Character();
            myHero.Name = "Arthur";
            myHero.Health = 100;
            myHero.DamageMaximum = 15;
            myHero.AttackBonus = true;

            Character myMonster = new Character();
            myMonster.Name = "Bungalo";
            myMonster.Health = 100;
            myMonster.DamageMaximum = 10;
            myMonster.AttackBonus = true;

            Dice dice = new Dice();

            //Bonus
            if (myHero.AttackBonus)           
                myMonster.Defend(myHero.Attack(dice));
            if (myMonster.AttackBonus)
                myHero.Defend(myMonster.Attack(dice));

            while (myHero.Health > 0 && myMonster.Health > 0)
            {
                myMonster.Defend(myHero.Attack(dice));
                myHero.Defend(myMonster.Attack(dice));

                printStats(myHero);
                printStats(myMonster);
            }


            displayResult(myHero, myMonster);

            

        }
        private void displayResult(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
                resultLabel.Text += String.Format("<p>Both {0} and {1} died.", opponent1.Name, opponent2.Name);
            else if (opponent1.Health <= 0)
                resultLabel.Text += String.Format("<p>{0} defeats {1}</p>", opponent2.Name, opponent1.Name);
            else
                resultLabel.Text += String.Format("<p>{0} defeats {1}</p>", opponent1.Name, opponent2.Name);
        }


        private void printStats(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} - DamageMaximum: {2} - AttackBonus: {3}</p>", 
                character.Name, 
                character.Health.ToString(), 
                character.DamageMaximum.ToString(), 
                character.AttackBonus.ToString());
        }


    }
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            //Random random = new Random();
            //int damage = random.Next(this.DamageMaximum);
            dice.Sides = this.DamageMaximum;
            return dice.Roll();
            
        }
        public void Defend(int damage)
        {
            this.Health -= damage;
        }


    
    }
    
    class Dice
    {
        public int Sides { get; set; }

        Random random = new Random();
        public int Roll()
        {
           return random.Next(this.Sides);
        }
    }

}