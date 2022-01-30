
namespace ProjetoRPG.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int Life, int Power)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.Power = Power;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a sua espada";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " atacou de maneira super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " atacou com força fraca com bonus de " + Bonus;
            }
        }
        public virtual string Defense()
        {
            return this.Name + " defendeu com seu escudo";
        }
    }
}
