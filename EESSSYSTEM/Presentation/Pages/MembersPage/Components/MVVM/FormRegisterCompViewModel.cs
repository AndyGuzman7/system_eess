using EESSSYSTEM.Presentation.Pages.MembersPage.Components.Validators;
using EESSSYSTEM.Presentation.Pages.MembersPage.MVVM;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace EESSSYSTEM.Presentation.Pages.MembersPage.Components.MVVM
{
    public class FormRegisterCompViewModel : ViewModelBase
    {
        private string _name;
        private string _phone;
        private GenderModel _gender;
        private BaptismModel _baptism;
        private DateTime _dateBirthDay = DateTime.Now;
        private string _errorMessage;
        private bool _isViewVisible = true;
        private List<GenderModel> _genders;
        private List<BaptismModel> baptisms;
        private bool _isFormValid;
        public bool IsFormValid
        {
            get { return _isFormValid; }
            set
            {
                if (_isFormValid != value)
                {
                    _isFormValid = value;
                    OnPropertyChanged(nameof(IsFormValid));
                }
            }
        }
        



        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        public DateTime DateBirthDay
        {
            get => _dateBirthDay;
            set
            {
                _dateBirthDay = value;
                OnPropertyChanged(nameof(DateBirthDay));
            }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public bool IsViewVisible
        {
            get => _isViewVisible;
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        // Commands

        private ICommand _registerCommand;

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public ICommand RegisterCommand
        {
            get
            {
                return _registerCommand ?? (_registerCommand = new RelayCommand(RegisterMember));
            }
        }

        public List<GenderModel> Genders { get => _genders; set => _genders = value; }
        public List<BaptismModel> Baptisms { get => baptisms; set => baptisms = value; }
        public GenderModel Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }
        public BaptismModel Baptism
        {
            get => _baptism;
            set
            {
                _baptism = value;
                OnPropertyChanged(nameof(Baptism));
            }
        }

        //public bool HasErrors => throw new NotImplementedException();

        private bool CanExecuteMyCommand(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Name)
         && !string.IsNullOrWhiteSpace(Phone)
         && DateBirthDay != DateTime.Now;
        }

        private void RegisterMember(object param)
        {
            if (ValidateForm())
            {
                MessageBox.Show("Validado");
            }
        }


        private bool ValidateForm()
        {
            // Utiliza el NameValidator directamente
            NameValidator validator = new NameValidator();
            ValidationResult result = validator.Validate(Name, CultureInfo.CurrentCulture);

            // Actualiza la propiedad IsFormValid
            IsFormValid = result.IsValid;

            // Puedes acceder al mensaje de error si lo necesitas
            string errorMessage = result.ErrorContent as string;
            return IsFormValid;
        }

        public IEnumerable GetErrors(string? propertyName)
        {
            throw new NotImplementedException();
        }

        public FormRegisterCompViewModel()
        {
            Genders = new List<GenderModel>()
            {
                new GenderModel("Masculino", 1),
                new GenderModel("Femenino", 0)
            };
            Baptisms = new List<BaptismModel>()
            {
                new BaptismModel("Bautisado", 1),
                new BaptismModel("No Bautizado", 0)
            };
        }



       


    }



    public class EdadValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is int edad)
            {
                if (edad < 1 || edad > 150)
                {
                    return new ValidationResult(false, "La edad debe estar entre 1 y 150.");
                }
                else
                {
                    return ValidationResult.ValidResult;
                }
            }

            return new ValidationResult(false, "Valor no válido para la edad.");
        }
    }
}
