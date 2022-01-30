namespace ProjetoRPG.Entities
{
    public class Hobbit : Hero
    {
        public Hobbit(string Name, int Level, string HeroType, int Life, int Power)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.Power = Power;
        }
        public Hobbit()
        {

        }

        public override string Attack()
        {
            return this.Name + " golpeou";

        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " golpeou com ataque efetivo com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " golpeou com força fraca com bonus de " + Bonus;
            }
        }
        public override string Defense()
        {
            return this.Name + " se esquivou";
        }
    }
}
