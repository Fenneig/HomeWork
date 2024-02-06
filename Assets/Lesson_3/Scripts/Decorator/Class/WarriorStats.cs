namespace Lesson_3.Scripts.Decorator.Class
{
    public class WarriorStats : StatsModifier
    {
        private readonly float _strengthModifier;

        public WarriorStats(IStats baseStats, float strengthModifier) : base(baseStats) =>
            _strengthModifier = strengthModifier;

        public override int Strength => (int) (BaseStats.Strength * _strengthModifier);
    }
}