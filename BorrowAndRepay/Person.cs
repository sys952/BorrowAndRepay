using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowAndRepay
{
    class Person
    {
        public string name;
        public int money;

        public Person()
        {
        
        }
        public Person(string mName, int mMoney)
        {
            name = mName;
            money = mMoney;
        }

        public void Action(Person P1, Person P2, int amountOfMoney, int control)
        {
            if (control == 0)
            {
                P1.money += amountOfMoney;
                P2.money -= amountOfMoney;
            }
            if (control == 1)
            {
                P1.money -= amountOfMoney;
                P2.money += amountOfMoney;
            }
            
        }
        public int getMoney()
        {
            return money;
        }
        public string getName()
        {
            return name;
        }
        
    }
}
