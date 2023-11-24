using System;

class ChurchMember
{
    // Fields
    private int memberId;
    private string name;
    private string emailAddress;
    private DateTime joinDate;

    // Properties
    public int MemberId => memberId;
    public string Name => name;
    public string EmailAddress => emailAddress;
    public DateTime JoinDate => joinDate;

    // Enum for member status
    enum MemberStatus
    {
        Active,
        Inactive
    }

    // Delegate for member status change notification
    delegate void ChangeMemberStatus(int memberId, MemberStatus newStatus);

    // Interface for member management
    interface IMemberManager
    {
        void AddMember(ChurchMember member);
        void UpdateMemberInfo(ChurchMember member);
        void RemoveMember(int memberId);
        void ChangeMemberStatus(int memberId, MemberStatus newStatus);
        bool IsMemberActive(int memberId);
    }

    // Methods

    public void UpdateEmailAddress(string newEmailAddress)
    {
        emailAddress = newEmailAddress;
        Console.WriteLine($"{name}'s email address has been updated to {emailAddress}");
    }
    public void Donate(double amount)
    {
        Console.WriteLine($"{name} donated {amount}Naira to the church.");
    }

    // Constructor
    public ChurchMember(int memberId, string name, string emailAddress, DateTime joinDate)
    {
        this.memberId = memberId;
        this.name = name;
        this.emailAddress = emailAddress;
        this.joinDate = joinDate;
    }

    // Destructor
    ~ChurchMember()
    {
        Console.WriteLine($"{name}'s record has been released");
    }


}

class Program
{
    static void Main(string[] args)
    {
        // Create a new church member
        ChurchMember newMember = new ChurchMember(1234, "Emmanuel Temi", "temiemmanuel@gmail.com", DateTime.Now);

        Console.WriteLine($"{newMember.Name} is a new member of our church \nHis Email Address is {newMember.EmailAddress} \nHe joined {newMember.JoinDate}");

        // Update member email address
        newMember.UpdateEmailAddress("temiemma@gmail.com");

        // Make a donation
        newMember.Donate(1500000.00);

        //Show member details
        Console.WriteLine($"The Latest Record of {newMember.Name} are:");
        Console.WriteLine($"\tMember ID: {newMember.MemberId}");
        Console.WriteLine($"\tEmail Address: {newMember.EmailAddress}");
        Console.WriteLine($"\tJoin Date: {newMember.JoinDate}");

    }
}