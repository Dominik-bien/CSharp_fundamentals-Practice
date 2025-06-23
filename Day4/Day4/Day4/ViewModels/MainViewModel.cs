using Day4.Commands;
using Day4.Models;
using Day4.Models.Wrappers;
using Day4.Views;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Day4.ViewModels
{
    public class MainViewModel :ViewModelBase
    {



        public ICommand AddPatientCommand { get; set; }
        public ICommand EditPatientCommand { get; set; }
        public ICommand DeletePatientCommand { get; set; }
        public ICommand RefreshPatientsCommand { get; set; }

        public MainViewModel()
        {

            using (var context = new ApplicationDbContext())
            {
                var patients = context.Patients.ToList();
            }

                AddPatientCommand = new RelayCommand(AddEditPatient);
            EditPatientCommand = new RelayCommand(AddEditPatient, CanEditDeleteStudent);
            DeletePatientCommand = new AsyncRelayCommand(DeletePatient, CanEditDeleteStudent);
            RefreshPatientsCommand = new RelayCommand(RefreshPatients);

            RefreshDiary();

            InitGenders();

        }

    



        //Bindings 
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








        private PatientWrapper _selectedPatient;

        public PatientWrapper SelectedPatient
        {
            get { return _selectedPatient; }
            set
            {
                _selectedPatient = value;
                OnPropertyChanged();
            }
        }




        private ObservableCollection<PatientWrapper> _patients;

        public ObservableCollection<PatientWrapper> Patients
        {
            get { return _patients; }
            set
            {
                _patients = value;
                OnPropertyChanged();
            }
        }












        //Methods
        private bool CanEditDeleteStudent(object obj)
        {
            return SelectedPatient != null;
        }

        private async Task DeletePatient(object obj)
        {
            var metroWindow = Application.Current.MainWindow as MetroWindow;
            var dialog = await metroWindow.ShowMessageAsync("Remove Patient", $"Do you want to remove Patient:" +
                $" {SelectedPatient.FirstName} {SelectedPatient.LastName}?", 
                MessageDialogStyle.AffirmativeAndNegative);

            if (dialog != MessageDialogResult.Affirmative)
                return; 

                    //Remove Patient from database
        }

      

        private void AddEditPatient(object obj)
        {
            var addEditPatientWindow = new AddEditPatient(obj as  PatientWrapper);
            addEditPatientWindow.Closed += AddEditPatientWindow_Closed;
            addEditPatientWindow.ShowDialog();
        }

        private void AddEditPatientWindow_Closed(object sender, EventArgs e)
        {
            RefreshDiary();
        }

        private void RefreshPatients(object obj)
        {
            RefreshDiary();
        }



        private void InitGenders()
        {
            Genders = new ObservableCollection<GenderWrapper>
            {
                new GenderWrapper { Id = 0, Name = "All" },
                new GenderWrapper { Id = 1, Name = "Male" },
                new GenderWrapper { Id = 2, Name = "Female" }
            };
            }


        private void RefreshDiary()
        {
            Patients = new ObservableCollection<PatientWrapper>
            {
                new PatientWrapper
                {
                    FirstName = "Dominik",
                    LastName="Bień",
                    Gender = new GenderWrapper {Id = 1 }
                },
                 new PatientWrapper
                {
                    FirstName = "Jan",
                    LastName="Nowak",
                    Gender = new GenderWrapper {Id = 1 }
                },
                  new PatientWrapper
                {
                    FirstName = "Barbara",
                    LastName="Kowalska",
                    Gender = new GenderWrapper {Id = 2 }
                }
            };
        }





        //Example how to work Binding
        //private string _test = "XXXX";

        //public string Test
        //{
        //    get { return _test; }
        //    set
        //    {
        //        _test = value;
        //        OnPropertyChanged();
        //    }
        //}
       

        //private bool CanRefreshPatients(object obj)
        //{
          //can not click button - return false 

         ///  return true;
       //}

    }
}
