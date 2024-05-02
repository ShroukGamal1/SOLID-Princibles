
/* we have a PaymentProcessor class that handles various payment methods, such as credit
cards, PayPal, and bank transfers. 
Currently, the ProcessPayment method uses a switch
statement to handle different payment types. 
This violates the OCP because adding a new
payment method requires modifying the existing code
*/
public class PaymentProcessor
{
public void ProcessPayment(PaymentType type, double amount)
{
switch (type)
{
case PaymentType.CreditCard:
 //Process credit card payment
break;
case PaymentType.PayPal:
// Process PayPal payment
break;
case PaymentType.BankTransfer:
// Process bank transfer payment
break;
// Add more cases for other payment types
}
}
}

public enum PaymentType
{
CreditCard,
PayPal,
BankTransfer
}
//solution 
/// <summary>
/// 
/// </summary>
//1- define interface PaymentProcessor defining common behavior for different types of payments 

//2- make a class for every paymentType that implement the interface  PaymentProcessor and each class override the function ProcessPayment

public interface PaymentProcessor{
    public void ProcessPayment(double amount);
       
}

public class CreditCard:PaymentProcessor{
    
    public override void ProcessPayment(double amount){
        ////Process credit card payment
    }
}

public class BankTransfer:PaymentProcessor{
    
    public override void ProcessPayment(double amount){
        // Process bank transfer payment
    }
}
public class PayPal:PaymentProcessor{
    
    public override void ProcessPayment(double amount){
         //Process PayPal payment
    }
}

/////////////////////////////////