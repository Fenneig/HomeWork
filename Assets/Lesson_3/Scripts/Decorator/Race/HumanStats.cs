namespace Lesson_3.Scripts.Decorator.Race
{
    public class HumanStats : StatsModifier
    {
        private float _statsModifier;

        public HumanStats(IStats baseStats, float statsModifier) : base(baseStats) =>
            _statsModifier = statsModifier;

        public override int Strength => (int) (BaseStats.Strength * _statsModifier);
        public override int Intellect => (int) (BaseStats.Intellect * _statsModifier);
        public override int Agility => (int) (BaseStats.Agility * _statsModifier);
    }
}