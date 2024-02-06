namespace Lesson_3.Scripts.Decorator.Passive
{
    public class FoxCunning : StatsModifier
    {
        private float _intellectBonus;

        public FoxCunning(IStats baseStats, float intellectBonus) : base(baseStats)
        {
            _intellectBonus = intellectBonus;
        }

        public override int Intellect => (int) (BaseStats.Intellect + _intellectBonus);
    }
}