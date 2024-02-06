namespace Lesson_3.Scripts.Decorator.Passive
{
    public class BullsStrength : StatsModifier
    {
        private float _strengthBonus;

        public BullsStrength(IStats baseStats, float strengthBonus) : base(baseStats) =>
            _strengthBonus = strengthBonus;

        public override int Strength => (int) (BaseStats.Strength + _strengthBonus);
    }
}