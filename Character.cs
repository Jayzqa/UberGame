

namespace UberGame
{
    public class Character
    {
        private Weapon w = null;

        //Alustetaan hahmon muuttujat
        private string name;
        private string characterClass;

        private int health;
        private int strength;
        private int dexterity;

        private int wDmg;
        private int dmg;

        //Alustetaan hahmon ase
        public void Init()
        {
            w = new Weapon();
            w.Init();
            wDmg = w.GetAttack();
        }
        public void InitVillain()
        {
            name = "Angry skeletor";
            characterClass = "Skeleton";
            health = 100;
            strength = 10;
            dexterity = 3;
        }
        public string GetName()
        {
            if (name != null && name.Length != 0)
            {
                return name;
            }
            else
            {
                return "Enter a name for your character!";
            }
        }


        public (int, int, int, int) GetStats() // Palauttaa hahmon tiedot
        {    
            return (health, strength, dexterity, dmg);
        }

        public int GetDmg() // Palauttaa hahmon tiedot
        {
            return dmg;
        }

        public string GetClass()
        { 
            return characterClass;
        }

        public int GetHealth()
        {
            return health;
        }

        //Uutta arvoa ei aseteta jos se on tyhjä merkkirivi
        public void SetName(string newName)
        {
            if (newName.Length != 0)
            {
                name = newName;
            }
        }

        public void SetClass(string newClass)
        {
            switch (newClass)
            {
                case "Warrior":
                    characterClass = "Warrior";
                    health = 100;
                    strength = 10;
                    dexterity = 1;
                    break;
                case "Rogue":
                    characterClass = "Rogue";
                    health = 100;
                    strength = 3;
                    dexterity = 3;
                    break;
                default:
                    characterClass = "Peasant";
                    health = 10;
                    strength = 1;
                    dexterity = 1;
                    break;
            }
        }
        public void Attack(string action)
        {
            switch (action)
            {

                case "1":
                    dmg = (wDmg + strength) * Die.Throw1d6();
                    health = health - dmg;
                    break;

                case "2":
                    dmg = (wDmg + dexterity) * Die.Throw1d6();
                    health = health - dmg;
                    break;

                default:
                    dmg = wDmg + strength;
                    health = health - dmg;
                    break;
            }


        
        }

    }
}

