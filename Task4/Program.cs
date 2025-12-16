using Task4;

// Пример использования класса BankAccount
BankAccount account = new BankAccount(1001, 5000.00m, "John Doe");

// Внесение и снятие средств, заморозка и разморозка счета
account.Deposit(1000.00m);
account.Withdraw(200.00m);

account.FreezeAccount();
account.Deposit(500.00m); // Не должно выполниться из-за замороженного счета

account.UnfreezeAccount();
account.Deposit(500.00m); // Должно выполниться после разморозки счета
