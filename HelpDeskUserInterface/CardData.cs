using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskUserInterface
{
    public class CardData
    {
        private Dictionary<CardAmountType, MonthType> KeyValuePairs;
        public CardData()
        {
            KeyValuePairs = new Dictionary<CardAmountType, MonthType>
            {
                { CardAmountType.Ten, MonthType.One },
                { CardAmountType.Fifteen, MonthType.Three },
                { CardAmountType.Fifty, MonthType.Twelve },
                { CardAmountType.TwentyFive, MonthType.Six }
            };

        }
        
        public MonthType GetDataByAmountType(CardAmountType cardAmountType)
        {
            return KeyValuePairs[cardAmountType];
        }
    }

}

