namespace ProjetoRPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int Life, int Power)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.Power = Power;
        }
        public Wizard()
        {

        }

        public override string Attack()
        {
            return this.Name + " lançou magia";

        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " lançou uma magia com força fraca com bonus de " + Bonus;
            }
        }
        public override string Defense()
        {
            return this.Name + " defendeu com sua magia";
        }
    }
}
