public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage

        Member member1 = new Member("Martha", 32, "Standard");
        Member member2 = new Member("Rose", 26, "Premium");
        Member member3 = new Member("River", 45, "VIP");


        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic
        //  3, 5, 10
        //  I struggled here trying to figure out what I could access, GetMaxBorrowLimit is private
        //  I didn't want to magic number and just plop them in
        //  In the end I just dropped in numbers but I think it could be bad code
        //  Would have prefered to compare to the max

        // loop 10 times, if hit max borrow limit exit
        int standardBookMax = 3;
        int premiumBookMax = 5;
        int vIPBookMax = 10;
        
        //this could or should be an array and simplified but it's 2am and I'm sleepy
        if (member1.MembershipLevel == "Standard")
        {
            for (int i = 0; i < standardBookMax; i++)
            {
                member1.BorrowBook();
            }
            Console.WriteLine($"You have borrowed all available books at this level");
        }
        else if (member1.MembershipLevel == "Premium")
        {
            for (int i = 0; i < premiumBookMax; i++)
            {
                member1.BorrowBook();
            }
            Console.WriteLine($"You have borrowed all available books at this level");
        }
        else if (member1.MembershipLevel == "VIP")
        {
            for (int i = 0; i < vIPBookMax; i++)
            {
                member1.BorrowBook();
            }
            Console.WriteLine($"You have borrowed all available books at this level");
        }
        else
        {
            Console.WriteLine($"This Member does not have an assignmed level yet");
        }

        if (member2.MembershipLevel == "Standard")
        {
            for (int i = 0; i < standardBookMax; i++)
            {
                member1.BorrowBook();
            }
            Console.WriteLine($"You have borrowed all available books at this level");
        }
        if (member2.MembershipLevel == "Premium")
        {
            for (int i = 0; i < premiumBookMax; i++)
            {
                member1.BorrowBook();
            }
            Console.WriteLine($"You have borrowed all available books at this level");
        }
        if (member2.MembershipLevel == "VIP")
        {
            for (int i = 0; i < vIPBookMax; i++)
            {
                member1.BorrowBook();
            }
            Console.WriteLine($"You have borrowed all available books at this level");
        }

        if (member3.MembershipLevel == "Standard")
        {
            for (int i = 0; i < standardBookMax; i++)
            {
                member1.BorrowBook();
            }
            Console.WriteLine($"You have borrowed all available books at this level");
        }
        if (member3.MembershipLevel == "Premium")
        {
            for (int i = 0; i < premiumBookMax; i++)
            {
                member1.BorrowBook();
            }
            Console.WriteLine($"You have borrowed all available books at this level");
        }
        if (member3.MembershipLevel == "VIP")
        {
            for (int i = 0; i < vIPBookMax; i++)
            {
                member1.BorrowBook();
            }
            Console.WriteLine($"You have borrowed all available books at this level");
        }


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"{member1.Age}{member1.MembershipLevel}{member1.GetBooksBorrowed}");
        Console.WriteLine($"{member2.Age}{member2.MembershipLevel}{member2.GetBooksBorrowed}");
        Console.WriteLine($"{member3.Age}{member3.MembershipLevel}{member3.GetBooksBorrowed}");


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine($"{Member.TotalMembers} {Member.TotalBooksBorrowed}");


        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields
        for (int i = 0; i < 11; i++)
        {
            member1.ReturnBook();
            member2.ReturnBook();
            member3.ReturnBook();
        }


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"{member1.Age}{member1.MembershipLevel}{member1.GetBooksBorrowed}");
        Console.WriteLine($"{member2.Age}{member2.MembershipLevel}{member2.GetBooksBorrowed}");
        Console.WriteLine($"{member3.Age}{member3.MembershipLevel}{member3.GetBooksBorrowed}");


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine($"{Member.TotalMembers} {Member.TotalBooksBorrowed}");

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
