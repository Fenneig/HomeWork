namespace Lesson_1.Scripts.WeaponTask.Magazine
{
    public class InfiniteMagazine : GunMagazine
    {
        public override bool TrySpendAmmo(int amount) => true;

        public override void Reload()
        { }

        public override string ShowAmmo() => "∞";
    }
}