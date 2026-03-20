using System;

class MobileProgram
{
    static void Main(string[] args)
    {
        // ── TASK 1: Jim's Mobile (Step 4 - initial setup) ──────────────────
        Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6", "07712223344");

        Console.WriteLine("Account Type: " + jimMobile.getAccType() +
                          "\nMobile Number: " + jimMobile.getNumber() +
                          "\nDevice: " + jimMobile.getDevice() +
                          "\nBalance: " + jimMobile.getBalance());

        // ── Step 5 - mutators ──────────────────────────────────────────────
        jimMobile.setAccType("PAYG");
        jimMobile.setDevice("iPhone 6S");
        jimMobile.setNumber("07713334466");
        jimMobile.setBalance(15.50);

        Console.WriteLine();
        Console.WriteLine("Account Type: " + jimMobile.getAccType() +
                          "\nMobile Number: " + jimMobile.getNumber() +
                          "\nDevice: " + jimMobile.getDevice() +
                          "\nBalance: " + jimMobile.getBalance());

        // ── Step 6 - addCredit, makeCall, sendText ─────────────────────────
        Console.WriteLine();
        jimMobile.addCredit(10.0);
        jimMobile.makeCall(5);
        jimMobile.sendText(2);

        // ── TASK 2: Second Mobile account ─────────────────────────────────
        Console.WriteLine();
        Console.WriteLine("New Mobile Account");
        Mobile saraMobile = new Mobile("PAYG", "Google Pixel 8", "04298887766");

        saraMobile.addCredit(25.0);
        saraMobile.makeCall(10);   // 10 minutes
        saraMobile.sendText(3);    // 3 texts
        saraMobile.sendText(2);    // 2 more texts

        Console.WriteLine("\nFinal account details for Sara:");
        Console.WriteLine("Account Type: " + saraMobile.getAccType() +
                          "\nMobile Number: " + saraMobile.getNumber() +
                          "\nDevice: " + saraMobile.getDevice() +
                          "\nBalance: " + saraMobile.getBalance());

        Console.ReadLine();
    }
}
