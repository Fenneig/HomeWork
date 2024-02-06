using System;
using Lesson_3.Scripts.Decorator.Class;
using Lesson_3.Scripts.Decorator.Config;
using Lesson_3.Scripts.Decorator.Passive;
using Lesson_3.Scripts.Decorator.Race;

namespace Lesson_3.Scripts.Decorator
{
    public class StatProvider
    {
        private readonly ConfigsRepository _configsRepository;

        public StatProvider(ConfigsRepository configsRepository) => _configsRepository = configsRepository;

        public IStats SetRace(IStats stats, RaceType raceType)
        {
            float modifier = _configsRepository.GetRaceModifier(raceType);
            
            return raceType switch
            {
                RaceType.Elf => new ElfStats(stats, modifier),
                RaceType.Human => new HumanStats(stats, modifier),
                RaceType.Ork => new OrkStats(stats, modifier),
                _ => throw new ArgumentOutOfRangeException(nameof(raceType), raceType, null)
            };
        }
        
        public IStats SetClass(IStats stats, ClassType classType)
        {
            float modifier = _configsRepository.GetClassModifier(classType);
            
            return classType switch
            {
                ClassType.Mage => new MageStats(stats, modifier),
                ClassType.Rogue => new RogueStats(stats, modifier),
                ClassType.Warrior => new WarriorStats(stats, modifier),
                _ => throw new ArgumentOutOfRangeException(nameof(classType), classType, null)
            };
        }
        
        public IStats SetPassive(IStats stats, PassiveType passiveType)
        {
            float modifier = _configsRepository.GetPassiveModifier(passiveType);
            
            return passiveType switch
            {
                PassiveType.BullsStrength => new BullsStrength(stats, modifier),
                PassiveType.CatsGrace => new CatsGrace(stats, modifier),
                PassiveType.FoxCunning => new FoxCunning(stats, modifier),
                _ => throw new ArgumentOutOfRangeException(nameof(passiveType), passiveType, null)
            };
        }
    }
}