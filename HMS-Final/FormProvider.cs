using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Final
{
    internal class FormProvider
    {
        public static Login LoginForm
        {
            get
            {
                if (_loginForm == null)
                {
                    _loginForm = new Login();
                }
                return _loginForm;
            }
        }
        public static Home HomeForm
        {
            get
            {
                if (_home == null)
                {
                    _home = new Home();
                }
                return _home;
            }
        }
        public static MainForm MainForm
        {
            get
            {
                if (_mainform == null)
                {
                    _mainform = new MainForm();
                }
                return _mainform;
            }
        }
        public static Doctor Doctor
        {
            get
            {
                if (_doctor == null)
                {
                    _doctor = new Doctor();
                }
                return _doctor;
            }
        }
        public static Patient Patient
        {
            get
            {
                if (_patient == null)
                {
                    _patient = new Patient();
                }
                return _patient;
            }
        }
        public static Appointment Appointment
        {
            get
            {
                if (_appointment == null)
                {
                    _appointment = new Appointment();
                }
                return _appointment;
            }
        }
        public static Prescription Prescription
        {
            get
            {
                if (_prescription == null)
                {
                    _prescription = new Prescription();
                }
                return (_prescription);
            }
        }
        public static Department Department
        {
            get
            {
                if (_department == null)
                {
                    _department = new Department();
                }
                return _department;
            }
        }
        public static Department _department;
        public static Prescription _prescription;
        public static Appointment _appointment;
        public static Patient _patient;
        public static Doctor _doctor;
        public static MainForm _mainform;
        public static Home _home;
        public static Login _loginForm;
    }
}
