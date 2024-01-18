using UnityEngine;

namespace Lesson_1.Scripts.MerchantTask.TradePatterns
{
    public class ArmorTrade : ITradePattern
    {
        public void Trade()
        {
            Debug.Log("I will trade you some armor!");
        }
    }
}