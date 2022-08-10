using System;
using System.Collections.Generic;
using System.Text;

namespace RestBDDAutomationPack.Models
{
  
public class Payouts
{
    public string id { get; set; }
    public string reference { get; set; }
    public string date { get; set; }
    public string bankAccountIban { get; set; }
    public string bankAccountBic { get; set; }
    public string currency { get; set; }
    public float amount { get; set; }
    public int chargedAmount { get; set; }
    public int refundedAmount { get; set; }
    public int fees { get; set; }
    public int feeVATpercent { get; set; }
    public int feeTaxRate { get; set; }
    public int feeTaxAmount { get; set; }
    public Transactiontaxdetail[] transactionTaxDetails { get; set; }
    public int numberOfPaymentActions { get; set; }
    public Paymentaction[] paymentActions { get; set; }
}

public class Transactiontaxdetail
{
    public int rate { get; set; }
    public int amount { get; set; }
}

public class Paymentaction
{
    public string id { get; set; }
    public string paymentId { get; set; }
    public string paymentAction { get; set; }
    public string paymentMethod { get; set; }
    public string paymentType { get; set; }
    public DateTime timestamp { get; set; }
    public string reference { get; set; }
    public int amount { get; set; }
    public int vatAmount { get; set; }
    public string currency { get; set; }
    public int fee { get; set; }
    public int flexibleFee { get; set; }
    public int fixedFee { get; set; }
    public int feeVATpercent { get; set; }
    public int feeTaxRate { get; set; }
    public int feeTaxAmount { get; set; }
    public Transactiontaxdetail1[] transactionTaxDetails { get; set; }
    public string subscriptionId { get; set; }
}

public class Transactiontaxdetail1
{
    public int rate { get; set; }
    public int amount { get; set; }
}
}
