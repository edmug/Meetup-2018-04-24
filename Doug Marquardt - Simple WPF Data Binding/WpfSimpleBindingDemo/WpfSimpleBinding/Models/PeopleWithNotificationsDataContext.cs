using System.Collections.ObjectModel;
using System.Linq;

namespace WpfSimpleBinding.Models
{
    internal class PeopleWithNotificationsDataContext : ObservableObject
    {
        #region SelectedPerson
        private PersonWithNotifications _selectedPerson;
        public PersonWithNotifications SelectedPerson { get => _selectedPerson; set => SetProperty(ref _selectedPerson, value); }
        #endregion

        public ObservableCollection<PersonWithNotifications> People { get; } = new ObservableCollection<PersonWithNotifications>();

        private int _personCounter;

        public void AddPerson()
        {
            _personCounter++;
            People.Add(new PersonWithNotifications { FirstName = $"<LastName {_personCounter}>", LastName = $"<FirstName {_personCounter}>" });
            SelectedPerson = People.Last();
        }
    }
}
