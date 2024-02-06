namespace Lesson_3.Scripts.Decorator.Class
{
    public class MageStats : StatsModifier
    {
        private float _intellectModifier;

        public MageStats(IStats baseStats, float intellectModifier) : base(baseStats) =>
            _intellectModifier = intellectModifier;

        public override int Intellect => (int) (BaseStats.Intellect * _intellectModifier);
    }
}