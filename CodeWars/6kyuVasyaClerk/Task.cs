using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyuVasyaClerk
{
    public class Task
    {
        //The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line. Each of them has a single 100, 50 or 25 dollars bill. A "Avengers" ticket costs 25 dollars.
        // Vasya is currently working as a clerk.He wants to sell a ticket to every single person in this line.
        //Can Vasya sell a ticket to each person and give the change if he initially has no money and sells the tickets strictly in the order people follow in the line?
        //Return YES, if Vasya can sell a ticket to each person and give the change. Otherwise return NO.

        //Line.Tickets(new int[] {25, 25, 50}) => YES 
        //Line.Tickets(new int[] {25, 100}) => NO. Vasya will not have enough money to give change to 100 dollars

        public class Line
        {
            public static string Tickets(int[] peopleInLine)
            {
                const int ticketPrice = 25;
                var moneyBuffer = new List<int>();

                string returnValue = "YES";

                if (peopleInLine.Length == 0) return "NO";

                foreach (int ticketMoney in peopleInLine)
                {
                    if (ticketMoney.Equals(ticketPrice))
                    {
                        moneyBuffer.Add(ticketMoney);
                        returnValue = "YES";
                    }
                    else
                    {
                        IEnumerable<int> returningBillCandidates = moneyBuffer.FindAll(i => i < ticketMoney);
                        int toReturnFromTicketMoney = ticketMoney - ticketPrice;

                        if (returningBillCandidates.Sum() >= toReturnFromTicketMoney)

                            foreach (int returningBill in returningBillCandidates.OrderByDescending(i => i))
                            {
                                if (toReturnFromTicketMoney - returningBill > 0)
                                {
                                    returnValue = "NO";
                                    continue;
                                }

                                toReturnFromTicketMoney -= returningBill;
                                moneyBuffer.Remove(returningBill);

                                if (toReturnFromTicketMoney != 0) continue;

                                moneyBuffer.Add(ticketMoney);
                                returnValue = "YES";
                                break;
                            }
                        else
                            returnValue = "NO";
                    }
                }

                return returnValue;
            }

            // jpryciaks solution
            //public static string Tickets(int[] peopleInLine)
            //{
            //    var bank = 0;

            //    foreach (int x in peopleInLine)
            //    {
            //        if (x == 25) bank += 25;
            //        else
            //        {
            //            bank -= x - 25;

            //            if (bank <= 0) return "NO";

            //            bank += 25;
            //        }
            //    }

            //    return "YES";
            //}

            // sideflip solution
            //public static string Tickets(int[] peopleInLine)
            //{
            //    int[] cash = { 0, 0, 0 };

            //    foreach (var t in peopleInLine)
            //    {
            //        switch (t)
            //        {
            //            case 25:
            //                cash[0] += 25;
            //                break;
            //            case 50:
            //                cash[1] += 50;
            //                cash[0] -= 25;
            //                break;
            //            default:
            //                cash[2] += 100;
            //                cash[0] -= 25;
            //                cash[1] -= 50;
            //                break;
            //        }

            //        if (cash[0] < 0 || cash[1] < 0 || cash[2] < 0) return "NO";
            //    }
            //    return "YES";
            //}
        }
    }
}
