using Day4.Models;
using Day4.Models.Wrappers;
using Day4.ViewModels;
using MahApps.Metro.Controls;


namespace Day4.Views
{
    /// <summary>
    /// Interaction logic for AddEditPatient.xaml
    /// </summary>
    public partial class AddEditPatient : MetroWindow
    {
        public AddEditPatient(PatientWrapper patient = null)
        {
            InitializeComponent();
            DataContext = new AddEditPatientViewModel(patient);
        }
    }
}
