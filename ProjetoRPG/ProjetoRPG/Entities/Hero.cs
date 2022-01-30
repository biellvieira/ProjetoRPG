using System;

namespace ProjetoRPG.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Life, int Power)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.Power = Power;
        }
        public Hero()
        {

        }
        public string Name;
        public int Level;
        public string HeroType;
        public int Life;
        public int Power;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.Life + " " + this.Power;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }

        public virtual string Defense()
        {
            return this.Name + " Defendeu com seu escudo";
        }

        
    }
}
