using UnityEngine;

namespace Lesson_1.Scripts.MerchantTask.TradePatterns
{
    public class NoTrade : ITradePattern
    {
        public void Trade()
        {
            Debug.Log("I won't trade with you");
        }
    }
}