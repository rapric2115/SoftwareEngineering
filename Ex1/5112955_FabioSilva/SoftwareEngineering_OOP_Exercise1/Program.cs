public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage
        Member a = new Member("Fabio", 37, "Premium");
        Member b = new Member("Roberta", 36, "VIP");
        Member c = new Member("Matheus", -12, "Standard");


        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic

        for (int i = 0; i < 5 ; i++)
        {
            a.BorrowBook();
        }

        for (int i = 0; i < 15; i++)
        {
            b.BorrowBook();
        }

        for (int i = 0; i < 5; i++)
        {
            c.BorrowBook();
        }


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"\nMember: {a.Name}, Age: {a.Age}, Membership level: {a.MembershipLevel}, Books borrowed: {a.GetBooksBorrowed()} ");
        Console.WriteLine($"Member: {b.Name}, Age: {b.Age}, Membership level: {b.MembershipLevel}, Books borrowed: {b.GetBooksBorrowed()} ");
        Console.WriteLine($"Member: {c.Name}, Age: {c.Age}, Membership level: {c.MembershipLevel}, Books borrowed: {c.GetBooksBorrowed()} ");

        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine($"\nTotal Books Borrowed: {Member.TotalBooksBorrowed}\n");

        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields
        for (int i = 0; i < 5; i++)
        {
            a.ReturnBook();
        }
        
        for (int i = 0; i < 5; i++)
        {
            b.ReturnBook();
        }
        
        for (int i = 0; i < 5; i++)
        {
            c.ReturnBook();
        }



        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"\nMember: {a.Name}, Age: {a.Age}, Membership level: {a.MembershipLevel}, Books borrowed: {a.GetBooksBorrowed()} ");
        Console.WriteLine($"Member: {b.Name}, Age: {b.Age}, Membership level: {b.MembershipLevel}, Books borrowed: {b.GetBooksBorrowed()} ");
        Console.WriteLine($"Member: {c.Name}, Age: {c.Age}, Membership level: {c.MembershipLevel}, Books borrowed: {c.GetBooksBorrowed()} ");


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine($"\nTotal Members: {Member.TotalMembers} and Total Books Borrowed: {Member.TotalBooksBorrowed}\n");

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
