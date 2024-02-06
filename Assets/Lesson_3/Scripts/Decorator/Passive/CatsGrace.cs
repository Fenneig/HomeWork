namespace Lesson_3.Scripts.Decorator.Passive
{
    public class CatsGrace : StatsModifier
    {
        private float _agilityBonus;

        public CatsGrace(IStats baseStats, float agilityBonus) : base(baseStats)
        {
            _agilityBonus = agilityBonus;
        }

        public override int Agility => (int) (BaseStats.Agility + _agilityBonus);
    }
}