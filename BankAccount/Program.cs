using System;

Console.WriteLine($"=== 계좌 개설 ===");
BankAccount account1 = new BankAccount("1001", "홍길동", 100000);
BankAccount account2 = new BankAccount("1002", "이순신", 50000);
BankAccount.ShowTotalAccounts();

Console.WriteLine($"\n=== 거래 ===");
account1.Deposit(50000);
account2.Deposit(30000);
account1.Withdraw(200000);
account1.Withdraw(100000);

Console.WriteLine($"\n=== 최종 계좌 정보 ===");
account1.ShowInfo();
account2.ShowInfo();

class BankAccount
{
    private static int TotalAccounts;
    public static void ShowTotalAccounts()
    {
        Console.WriteLine($"현재 총 계좌 수: {TotalAccounts}");
    }

    public string AccountNumber { get; private set; }
    public string OwnerName { get; private set; }
    public int Balance { get; private set; }

    public BankAccount(string account_number, string owner_name, int amount)
    {
        AccountNumber = account_number;
        OwnerName = owner_name;
        Balance = amount;
        Console.WriteLine($"[{AccountNumber}] {OwnerName} 계좌가 개설되었습니다.");
        TotalAccounts++;
    }

    public void Deposit(int amount)
    {
        Balance += amount;
        Console.WriteLine($"[{AccountNumber}] {amount}원 입금 완료. 잔액: {Balance}원");
    }

    public void Withdraw(int amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금 실패. 잔액이 부족합니다.");
            return;
        }
        Balance -= amount;
        Console.WriteLine($"[{AccountNumber}] {amount}원 출금 완료. 잔액: {Balance}원");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"계좌번호: {AccountNumber}, 예금주: {OwnerName}, 잔액: {Balance}원");
    }
}