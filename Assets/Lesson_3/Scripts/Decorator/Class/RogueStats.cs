namespace Lesson_3.Scripts.Decorator.Class
{
    public class RogueStats : StatsModifier
    {
        private float _agilityModifier;

        public RogueStats(IStats baseStats, float agilityModifier) : base(baseStats) =>
            _agilityModifier = agilityModifier;

        public override int Agility => (int) (BaseStats.Agility * _agilityModifier);
    }
}