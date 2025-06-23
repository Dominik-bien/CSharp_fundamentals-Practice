using Day4.Commands;
using Day4.Models;
using Day4.Models.Wrappers;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Day4.ViewModels
{
    public class AddEditPatientViewModel : ViewModelBase
    {

        public ICommand CloseCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }

        public AddEditPatientViewModel(PatientWrapper patient = null)
        {
            CloseCommand = new RelayCommand(Close);
            ConfirmCommand = new RelayCommand(Confirm);

            if (patient == null)
            {
                Patient = new PatientWrapper();
                IsUpdate = false;
            }
            else
            {
                Patient = patient;
                IsUpdate = true;
            }

            InitGenders();
        }


        //Bindings 

        private PatientWrapper _patient;

        public PatientWrapper Patient
        {
            get { return _patient; }
            set {
                _patient = value;
                OnPropertyChanged();
            }
        }



        private bool _isUpdate;

        public bool IsUpdate
        {
            get { return _isUpdate; }
            set
            {
                _isUpdate = value;
                OnPropertyChanged();
            }
        }
        private int _selectedGenderId;

        public int SelectedGenderId
        {
            get { return _selectedGenderId; }
            set
            {
                _selectedGenderId = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<GenderWrapper> _genders;

        public ObservableCollection<GenderWrapper> Genders
        {
            get { return _genders; }
            set
            {
                _genders = value;
                OnPropertyChanged();
            }
        }



        private void InitGenders()
        {
            Genders = new ObservableCollection<GenderWrapper>
            {
                new GenderWrapper { Id = 0, Name = "-- None --" },
                new GenderWrapper { Id = 1, Name = "Male" },
                new GenderWrapper { Id = 2, Name = "Female" }
            };

            Patient.Gender.Id = 0;
        }



        private void Confirm(object obj)
        {
            if (!IsUpdate)
                AddPatient();
            else
                UpdatePatient();


                CloseWindow(obj as Window);
        }

        private void UpdatePatient()
        {
           //DataBase
        }

        private void AddPatient()
        {
            //Database
        }

        private void Close(object obj)
        {
            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }
    }
}
