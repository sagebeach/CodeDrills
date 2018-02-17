using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character
            {
                //set properties
                Name = "Drizzt",
                Health = 90,
                DamageMaximum = 50,
                AttackBonus = 2
            };

            Character monster = new Character
            {
                //set properties
                Name = "Orc King",
                Health = 100,
                DamageMaximum = 25,
                AttackBonus = 10 //could be used to set a damage base for a character. If damage is randomized with a lower limit of 0 this could cause problems though. 
            };
            int heroAttack = hero.Attack(); //creates a damagetotal from the attack.
            monster.Defend(heroAttack); //passes the damagetotal to be subtracted from the health total.
            int monsterAttack = monster.Attack();
            hero.Defend(monsterAttack);
            printResults(heroAttack, monsterAttack, hero.Name, monster.Name, hero.Health, monster.Health);
        }

        private void printResults(int heroAttack, int monsterAttack, string heroName, string monsterName, int heroHealth, int monsterHealth)
        {
            battleLabel.Text = String.Format("Hero does {0} damage | Monster does {1} damage", heroAttack, monsterAttack);
            statLabel.Text = 
                String.Format("Battle Results |<br />" +
                "Hero: {0}<br />" +
                "Health: {1}<br /><br />" +
                "Monster: {2}<br />" +
                "Health: {3}",
                heroName, heroHealth, monsterName, monsterHealth); //this could be made better by creating a loop around the calls to monster and hero attack/defend that concatenate results onto the end of these strings?
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public int AttackBonus { get; set; }


        Random random = new Random();
        public int Attack() //randomly determine the amount of damage this Character object inflicted.
        {
            int damage = (random.Next(1, DamageMaximum) + AttackBonus);
            return damage;
        }

        public int Defend(int damage) //deducts the damage from this Character's health
        {
            Health = Health - damage;
            return Health;
        } 
            
    }
}