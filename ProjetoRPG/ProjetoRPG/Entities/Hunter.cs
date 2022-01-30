
namespace ProjetoRPG.Entities
{
    public class Hunter : Hero
    {
        public Hunter(string Name, int Level, string HeroType, int Life, int Power)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.Power = Power;
        }
        public Hunter()
        {

        }

        public override string Attack()
        {
            return this.Name + " atirou uma flecha";

        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " atirou uma flecha super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " atirou uma flecha com força fraca com bonus de " + Bonus;
            }
        }
        public override string Defense()
        {
            return this.Name + " defendeu com seu escudo";
        }
    }
}
