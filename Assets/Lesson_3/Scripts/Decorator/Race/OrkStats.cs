namespace Lesson_3.Scripts.Decorator.Race
{
    public class OrkStats : StatsModifier
    {
        private readonly float _strengthModifier;

        public OrkStats(IStats baseStats, float strengthModifier) : base(baseStats) =>
            _strengthModifier = strengthModifier;

        public override int Strength => (int) (BaseStats.Strength * _strengthModifier);
    }
}