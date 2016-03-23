using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6kyuVasyaClerk
{
    public class Task1
    {
        //The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line. Each of them has a single 100, 50 or 25 dollars bill. A "Avengers" ticket costs 25 dollars.
        // Vasya is currently working as a clerk.He wants to sell a ticket to every single person in this line.
        //Can Vasya sell a ticket to each person and give the change if he initially has no money and sells the tickets strictly in the order people follow in the line?
        //Return YES, if Vasya can sell a ticket to each person and give the change. Otherwise return NO.

        //Line.Tickets(new int[] {25, 25, 50}) => YES 
        //Line.Tickets(new int[] {25, 100}) => NO. Vasya will not have enough money to give change to 100 dollars

        public class Line1
        {
            public static string Tickets(int[] peopleInLine)
            {
                // Print input
                //Console.WriteLine(string.Join(", ", peopleInLine));

                const int ticketPrice = 25;
                var moneyBuffer = new List<int>();

                // Default return value
                string returnValue = "YES";

                // If Array contains no elements terminate all actions
                if (peopleInLine.Length == 0) return "NO";

                // List input values
                foreach (int ticketMoney in peopleInLine)
                {
                    // If ticket money is equals ticket price which means 25 add it to the moneyBuffer
                    if (ticketMoney.Equals(ticketPrice))
                    {
                        moneyBuffer.Add(ticketMoney);
                        returnValue = "YES";
                    }
                    else
                    {
                        // Returning bill candidates are smaller then ticketMoney
                        IEnumerable<int> returningBillCandidates = moneyBuffer.FindAll(i => i < ticketMoney);

                        // To return amount
                        int toReturnFromTicketMoney = ticketMoney - ticketPrice;

                        // Sum of returning bill candidates has to be bigger or equals returning abount
                        if (returningBillCandidates.Sum() >= toReturnFromTicketMoney)

                            // Values has to start from higher to lower
                            foreach (int returningBill in returningBillCandidates.OrderByDescending(i => i))
                            {
                                // If is returning value to big skip it 
                                if (toReturnFromTicketMoney - returningBill > 0)
                                {
                                    returnValue = "NO";
                                    continue;
                                }

                                // Reduce returning amount
                                toReturnFromTicketMoney -= returningBill;

                                // Remove bill from money buffer
                                moneyBuffer.Remove(returningBill);

                                // If the money is not returned complitly keep going
                                if (toReturnFromTicketMoney != 0) continue;

                                // Add money buffer new bill and go to another bill
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
        }
    }
}
