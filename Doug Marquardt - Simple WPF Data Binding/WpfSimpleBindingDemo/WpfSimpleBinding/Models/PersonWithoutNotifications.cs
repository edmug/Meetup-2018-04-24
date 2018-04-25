namespace WpfSimpleBinding.Models
{
    internal class PersonWithoutNotifications : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{LastName}, {FirstName}";

        public bool IsActive { get; set; } = true;

        public override string ToString()
        {
            return FullName;
        }
    }
}
