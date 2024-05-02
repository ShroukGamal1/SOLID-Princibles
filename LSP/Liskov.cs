
/*e, the SavingsAccount class inherits from the Account class but overrides
the Withdraw method to impose a withdrawal fee. However, this violates the LSP because
instances of SavingsAccount cannot be substituted for instances of Account without
causing unexpected behavior*/

public class Account
{
public decimal Balance { get; protected set; }
public virtual void Deposit(decimal amount)
{
Balance += amount;
}
public virtual void Withdraw(decimal amount)
{
if (Balance  amount)
{
Balance -= amount;
}
else
{
throw new InvalidOperationException("Insufficient balance.");
}
}
}

public class SavingsAccount : Account
{
public decimal InterestRate { get; set; }
public override void Withdraw(decimal amount)
{
 Impose a withdrawal fee
amount += 5.0m;
base.Withdraw(amount);
}
}

//solution 
//1- Abstract base class defining common behavior for different types of accounts
// 2- that defines the basic behavior of an account.
//3- Account and SavingsAccount inherit from AccountBase and implement the Withdraw method according to their logic.
///////////////////////
/////
///1-
public abstract class BaseAccount{
public decimal Balance { get; protected set; }
public virtual void Deposit(decimal amount)
{
Balance += amount;
}
public virtual void Withdraw(decimal amount);

}
//2-
//////////////////////
public class Account:BaseAccount
{
public override void Withdraw(decimal amount)
{
if (Balance  amount)
{
Balance -= amount;
}
else
{
throw new InvalidOperationException("Insufficient balance.");
}
}
}
////////////////////
/////-3
public class SavingsAccount : Account
{
public decimal InterestRate { get; set; }
public override void Withdraw(decimal amount)
{
 
amount += 5.0m;
 if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Insufficient balance.");
        }
}
}