public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage

        Member m1 = new Member("Renato", 30, "Standard");
        Member m2 = new Member("Thallita", 29, "Premium");
        Member m3 = new Member("Luiz", 25, "VIP");


        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic


        for (int i = 0; i < 3; i++)
        {
            m1.BorrowBook();
        }
        for (int i = 0; i < 5; i++)
        {
            m2.BorrowBook();
        }
        for (int i = 0; i < 10; i++)
        {
            m3.BorrowBook();
        }


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data

        string l = "\n---------------\n";

        Console.WriteLine($"{m1.Name}\nAge: {m1.Age}\nmembership level: {m1.MembershipLevel}\nBook Borrowed: {m1.GetBooksBorrowed()}");
        Console.WriteLine(l);
        Console.WriteLine($"{m2.Name}\nAge: {m2.Age}\nmembership level: {m2.MembershipLevel}\nBook Borrowed: {m2.GetBooksBorrowed()}");
        Console.WriteLine(l);
        Console.WriteLine($"{m3.Name}\nAge: {m3.Age}\nmembership level: {m3.MembershipLevel}\n Book Borrowed: {m3.GetBooksBorrowed()}");
        Console.WriteLine(l);


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data

        Console.WriteLine($"Total Members: {Member.TotalMembers}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");
        Console.WriteLine(l);



        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields

        for (int i = 0; i < 3; i++)
        {
            m1.ReturnBook();
        }
        for (int i = 0; i < 5; i++)
        {
            m2.ReturnBook();
        }
        for (int i = 0; i < 10; i++)
        {
            m3.ReturnBook();
        }



        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data

        Console.WriteLine($"{m1.Name}\nAge: {m1.Age}\nmembership level: {m1.MembershipLevel}\nBook Borrowed: {m1.GetBooksBorrowed()}");
        Console.WriteLine(l);
        Console.WriteLine($"{m2.Name}\nAge: {m2.Age}\nmembership level: {m2.MembershipLevel}\nBook Borrowed: {m2.GetBooksBorrowed()}");
        Console.WriteLine(l);
        Console.WriteLine($"{m3.Name}\nAge: {m3.Age}\nmembership level: {m3.MembershipLevel}\n Book Borrowed: {m3.GetBooksBorrowed()}");
        Console.WriteLine(l);


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data

        Console.WriteLine($"Total Members: {Member.TotalMembers}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");
        Console.WriteLine(l);

        /*
            Instructions for Expected Output:

            If you create the following members:
            - Alice, Age: 25, Membership Level: Standard
            - Bob, Age: 30, Membership Level: Premium
            - Charlie, Age: 40, Membership Level: VIP

            Then the program should produce the following output when borrowing and returning books:

            Alice has reached their borrowing limit.
            Bob has reached their borrowing limit.
            Charlie has reached their borrowing limit.
            Alice, Age: 25, Level: Standard, Books Borrowed: 3
            Bob, Age: 30, Level: Premium, Books Borrowed: 5
            Charlie, Age: 40, Level: VIP, Books Borrowed: 10
            Total Members: 3
            Total Books Borrowed: 18
            Alice has returned all their books.
            Bob has returned all their books.
            Charlie has returned all their books.
            Alice, Age: 25, Level: Standard, Books Borrowed: 0
            Bob, Age: 30, Level: Premium, Books Borrowed: 0
            Charlie, Age: 40, Level: VIP, Books Borrowed: 0
            Total Members: 3
            Total Books Borrowed: 0
        */
    }
}
