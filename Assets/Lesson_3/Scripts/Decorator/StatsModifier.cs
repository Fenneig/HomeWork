namespace Lesson_3.Scripts.Decorator
{
    public abstract class StatsModifier : IStats
    {
        protected IStats BaseStats;

        public StatsModifier(IStats baseStats) => BaseStats = baseStats;

        public virtual int Strength => BaseStats.Strength;
        public virtual int Intellect => BaseStats.Intellect;
        public virtual int Agility => BaseStats.Intellect;
    }
}