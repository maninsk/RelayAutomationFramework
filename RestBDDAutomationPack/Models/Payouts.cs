using System;
using System.Collections.Generic;
using System.Text;

namespace RestBDDAutomationPack.Models
{

   
    public class Payouts
    {
        public int numberOfPayouts { get; set; }
        public Payout[] payouts { get; set; }
    }

    public class Payout
    {
        public string id { get; set; }
        public string reference { get; set; }
        public string date { get; set; }
        public string bankAccountIban { get; set; }
        public string bankAccountBic { get; set; }
        public string currency { get; set; }
        public int amount { get; set; }
        public int chargedAmount { get; set; }
        public int numberOfCharges { get; set; }
        public int refundedAmount { get; set; }
        public int numberOfRefunds { get; set; }
        public int fees { get; set; }
        public int feeVATpercent { get; set; }
        public int feeTaxRate { get; set; }
        public int feeTaxAmount { get; set; }
        public Transactiontaxdetail[] transactionTaxDetails { get; set; }
    }

    public class Transactiontaxdetail
    {
        public int rate { get; set; }
        public int amount { get; set; }
    }


}
