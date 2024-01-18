using Lesson_1.Scripts.MerchantTask.TradePatterns;
using UnityEngine;

namespace Lesson_1.Scripts.MerchantTask
{
    public class Merchant : MonoBehaviour
    {
        private ITradePattern _tradePattern;

        public void Trade() => _tradePattern.Trade();

        public void SwitchTradePattern(ITradePattern tradePattern) => _tradePattern = tradePattern;
    }
}