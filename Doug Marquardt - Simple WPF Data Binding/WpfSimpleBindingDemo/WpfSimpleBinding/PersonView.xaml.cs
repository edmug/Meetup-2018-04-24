using System.Windows;

namespace WpfSimpleBinding
{
    internal partial class PersonView
    {
        public PersonView()
        {
            InitializeComponent();
        }

        #region FirstName

        public static readonly DependencyProperty FirstNameProperty = DependencyProperty.Register(
            "FirstName", typeof(string), typeof(PersonView), new PropertyMetadata(default(string)));

        public string FirstName
        {
            get => (string) GetValue(FirstNameProperty);
            set => SetValue(FirstNameProperty, value);
        }

        #endregion

        #region LastName

        public static readonly DependencyProperty LastNameProperty = DependencyProperty.Register(
            "LastName", typeof(string), typeof(PersonView), new PropertyMetadata(default(string)));

        public string LastName
        {
            get => (string) GetValue(LastNameProperty);
            set => SetValue(LastNameProperty, value);
        }

        #endregion

        #region IsActive

        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register(
            "IsActive", typeof(bool), typeof(PersonView), new PropertyMetadata(default(bool)));

        public bool IsActive
        {
            get => (bool) GetValue(IsActiveProperty);
            set => SetValue(IsActiveProperty, value);
        }

        #endregion
    }
}
