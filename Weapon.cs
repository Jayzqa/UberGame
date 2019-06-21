

namespace UberGame
{
    public class Weapon
    {
        private int attack;

        public int GetAttack() {
            return attack;
        }
        public void SetAttack(int newAttack) {
            attack = newAttack;
        }

        public void Init()
        {
            SetAttack(Die.Throw1d20());
        }
    }
}
