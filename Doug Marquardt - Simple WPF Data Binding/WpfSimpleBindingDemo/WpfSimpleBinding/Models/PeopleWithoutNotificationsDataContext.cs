using System.Collections.ObjectModel;
using System.Linq;

namespace WpfSimpleBinding.Models
{
    internal class PeopleWithoutNotificationsDataContext : ObservableObject
    {
        public PersonWithoutNotifications SelectedPerson { get; set; }

        //#region SelectedPerson
        //private PersonWithoutNotifications _selectedPerson;
        //public PersonWithoutNotifications SelectedPerson { get => _selectedPerson; set => SetProperty(ref _selectedPerson, value); }
        //#endregion

        public ObservableCollection<PersonWithoutNotifications> People { get; } = new ObservableCollection<PersonWithoutNotifications>();

        private int _personCounter;

        public void AddPerson()
        {
            _personCounter++;
            People.Add(new PersonWithoutNotifications { FirstName = $"<LastName {_personCounter}>", LastName = $"<FirstName {_personCounter}>" });
            SelectedPerson = People.Last();
        }
    }
}
