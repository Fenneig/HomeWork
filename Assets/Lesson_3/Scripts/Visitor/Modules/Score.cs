using System;
using Lesson_3.Scripts.Visitor.Configs;
using Lesson_3.Scripts.Visitor.Enemy;
using Lesson_3.Scripts.Visitor.Interfaces;

namespace Lesson_3.Scripts.Visitor.Modules
{
    public class Score: IDisposable
    {
        private IFoeEventNotifier _foeEventNotifier;
        private FoeScoreVisitor _foeScoreVisitor;

        public event Action<int> ScoreChanged; 

        public Score(IFoeEventNotifier foeEventNotifier, ScoreConfig scoreConfig)
        {
            _foeEventNotifier = foeEventNotifier;
            _foeEventNotifier.DeathNotified += OnFoeKilled;

            _foeScoreVisitor = new FoeScoreVisitor(scoreConfig);
        }

        public void Dispose() => _foeEventNotifier.DeathNotified -= OnFoeKilled;

        private void OnFoeKilled(Foe foe)
        {
            _foeScoreVisitor.Visit(foe);
            ScoreChanged?.Invoke(_foeScoreVisitor.Score);
        }

        private class FoeScoreVisitor : IFoeVisitor
        {
            private ScoreConfig _scoreConfig;

            public FoeScoreVisitor(ScoreConfig scoreConfig) => _scoreConfig = scoreConfig;

            public int Score { get; private set; }

            public void Visit(Ork ork) => Score += _scoreConfig.OrkPoints;

            public void Visit(Human human) => Score += _scoreConfig.HumanPoints;

            public void Visit(Elf elf) => Score += _scoreConfig.ElfPoints;

            public void Visit(Robot robot) => Score += _scoreConfig.RobotPoints;

            public void Visit(Foe foe) => Visit((dynamic) foe);
        }
    }
}
