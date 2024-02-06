namespace Lesson_3.Scripts.Decorator.Race
{
    public class ElfStats : StatsModifier
    {
        private readonly float _agilityModifier;

        public ElfStats(IStats baseStats, float agilityModifier) : base(baseStats) =>
            _agilityModifier = agilityModifier;

        public override int Agility => (int) (BaseStats.Agility * _agilityModifier);
    }
}