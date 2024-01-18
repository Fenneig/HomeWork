using UnityEngine;

namespace Lesson_1.Scripts.MerchantTask.TradePatterns
{
    public class FruitTrade : ITradePattern
    {
        public void Trade()
        {
            Debug.Log("I have some fruits for you to exchange!");
        }
    }
}