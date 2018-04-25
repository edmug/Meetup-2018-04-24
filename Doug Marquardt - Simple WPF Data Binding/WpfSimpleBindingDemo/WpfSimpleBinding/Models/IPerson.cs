namespace WpfSimpleBinding.Models
{
    internal interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        string FullName { get; }

        bool IsActive { get; set; }
    }
}
