public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage


        Member alice = new Member("Alice", 25, "Standard");
        Member bob = new Member("Bob", 30, "Premium");
        Member charlie = new Member("Charlie", 40, "VIP");


        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic


        for (int i = 0; i < 4; i++)
            alice.BorrowBook();

        for (int i = 0; i < 6; i++)
            bob.BorrowBook();

        for (int i = 0; i < 11; i++)
            charlie.BorrowBook();


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data

        PrintMember(alice);
        PrintMember(bob);
        PrintMember(charlie);


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data


        Console.WriteLine($"Total Members: {Member.TotalMembers}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");


        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields

        while (alice.GetBooksBorrowed() > 0)
            alice.ReturnBook();

        while (bob.GetBooksBorrowed() > 0)
            bob.ReturnBook();

        while (charlie.GetBooksBorrowed() > 0)
            charlie.ReturnBook();





        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data

        PrintMember(alice);
        PrintMember(bob);
        PrintMember(charlie);




        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data


        Console.WriteLine($"Total Members: {Member.TotalMembers}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");




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

    static void PrintMember(Member m)
    {
        Console.WriteLine(
            $"{m.Name}, Age: {m.Age}, Level: {m.MembershipLevel}, Books Borrowed: {m.GetBooksBorrowed()}"
        );
    }


















}
