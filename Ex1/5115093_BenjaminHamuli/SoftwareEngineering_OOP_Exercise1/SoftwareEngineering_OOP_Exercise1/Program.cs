public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage

        Member m1 = new Member("Alice", 25, "Standard");
        Member m2 = new Member("Bob", 30, "Premium");
        Member m3 = new Member("Charlie", 40, "VIP");

        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic

        for (int i = 0; i < 4; i++)
            m1.BorrowBook();

        for (int i = 0; i < 6; i++)
            m2.BorrowBook();

        for (int i = 0; i < 11; i++)
            m3.BorrowBook();

        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data

        Console.WriteLine($"{m1.Name}, Age: {m1.Age}, Level: {m1.MembershipLevel}, Books Borrowed: {m1.GetBooksBorrowed()}");
        Console.WriteLine($"{m2.Name}, Age: {m2.Age}, Level: {m2.MembershipLevel}, Books Borrowed: {m2.GetBooksBorrowed()}");
        Console.WriteLine($"{m3.Name}, Age: {m3.Age}, Level: {m3.MembershipLevel}, Books Borrowed: {m3.GetBooksBorrowed()}");

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

        while (m1.GetBooksBorrowed() > 0)
            m1.ReturnBook();
        m1.ReturnBook();

        while (m2.GetBooksBorrowed() > 0)
            m2.ReturnBook();
        m2.ReturnBook();

        while (m3.GetBooksBorrowed() > 0)
            m3.ReturnBook();
        m3.ReturnBook();

        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data

        Console.WriteLine($"{m1.Name}, Age: {m1.Age}, Level: {m1.MembershipLevel}, Books Borrowed: {m1.GetBooksBorrowed()}");
        Console.WriteLine($"{m2.Name}, Age: {m2.Age}, Level: {m2.MembershipLevel}, Books Borrowed: {m2.GetBooksBorrowed()}");
        Console.WriteLine($"{m3.Name}, Age: {m3.Age}, Level: {m3.MembershipLevel}, Books Borrowed: {m3.GetBooksBorrowed()}");

        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data

        Console.WriteLine($"Total Members: {Member.TotalMembers}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");
    }
}
