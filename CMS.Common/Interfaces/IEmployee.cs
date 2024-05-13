namespace CMS.Common.Interfaces
{
    public interface IEmployee
    {
        string EmailAddress { get; set; }
        int EmployeeId { get; set; }
        string FirstName { get; set; }
        string FullName { get; }
        string LastName { get; set; }
    }
}
