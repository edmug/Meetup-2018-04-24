namespace WpfSimpleBinding.Models
{
    internal class PersonWithNotifications : ObservableObject, IPerson
    {
        #region FirstName
        private string _firstName;
        public string FirstName
        {
            get => _firstName; set
            {
                SetProperty(ref _firstName, value);
                NotifyPropertyChanged(nameof(FullName));
            }
        }
        #endregion

        #region LastName
        private string _lastName;
        public string LastName
        {
            get => _lastName; set
            {
                SetProperty(ref _lastName, value);
                NotifyPropertyChanged(nameof(FullName));
            }
        }
        #endregion

        public string FullName => $"{LastName}, {FirstName}";

        #region IsActive
        private bool _isActive = true;
        public bool IsActive { get => _isActive; set => SetProperty(ref _isActive, value); }
        #endregion

        public override string ToString()
        {
            return FullName;
        }
    }
}
