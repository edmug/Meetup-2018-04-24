namespace WpfSimpleBinding.Models
{
    internal class PeopleDataContext
    {
        public PeopleDataContext()
        {
            for (var i = 0; i < 5; i++)
            {
                WithoutNotifications.AddPerson();
                WithNotifications.AddPerson();
            }
        }

        public PeopleWithNotificationsDataContext WithNotifications { get; } = new PeopleWithNotificationsDataContext();
        public PeopleWithoutNotificationsDataContext WithoutNotifications { get; } = new PeopleWithoutNotificationsDataContext();
    }
}
