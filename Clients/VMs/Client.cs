using Clients.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Clients.VMs
{
    class Client : VMContext, INotifyPropertyChanged
    {
        int? id;
        string name;
        string lastname;
        string patronymic;
        DateTime dateOfBirth;
        int gender;
        string passportSeries;
        string passportNumber;
        string placeOfBirth;
        City cityFactResidence;
        string adressFactResidence;
        string homePhone;
        string mobilePhone;
        string eMail;
        string placeOfWork;
        string position;
        City cityOfRegistration;
        string placeOfResidence;
        FamilyPosition familyPosition;
        Citizenship citizenship;
        Disability disability;
        bool pensioner;
        decimal monthlyIncome;
        bool liableForMilitary;

        public int? Id { get => id; set { id = value; OnPropertyChanged(); } }
        public string Name { get => name; set { name = value; OnPropertyChanged(); } }
        public string Lastname { get => lastname; set { lastname = value; OnPropertyChanged(); } }
        public string Patronymic { get => patronymic; set { patronymic = value; OnPropertyChanged(); } }
        public DateTime DateOfBirth { get => dateOfBirth; set { dateOfBirth = value; OnPropertyChanged(); } }
        public int Gender { get => gender; set { gender = value; OnPropertyChanged(); } }
        public string PassportSeries { get => passportSeries; set { passportSeries = value; OnPropertyChanged(); } }
        public string PassportNumber { get => passportNumber; set { passportNumber = value; OnPropertyChanged(); } }
        public string PlaceOfBirth { get => placeOfBirth; set { placeOfBirth = value; OnPropertyChanged(); } }
        public string AdressFactResidence { get => adressFactResidence; set { adressFactResidence = value; } }
        public string HomePhone { get => homePhone; set { homePhone = value; OnPropertyChanged(); } }
        public string MobilePhone { get => mobilePhone; set { mobilePhone = value; OnPropertyChanged(); } }
        public string EMail { get => eMail; set { eMail = value; OnPropertyChanged(); } }
        public string PlaceOfWork { get => placeOfWork; set { placeOfWork = value; OnPropertyChanged(); } }
        public string Position { get => position; set { position = value; OnPropertyChanged(); } }
        public string PlaceOfResidence { get => placeOfResidence; set { placeOfResidence = value; OnPropertyChanged(); } }
        public bool Pensioner { get => pensioner; set { pensioner = value; OnPropertyChanged(); } }
        public decimal MonthlyIncome { get => monthlyIncome; set { monthlyIncome = value; OnPropertyChanged(); } }
        public bool LiableForMilitary { get => liableForMilitary; set { liableForMilitary = value; OnPropertyChanged(); } }
        public City CityFactResidence { get => cityFactResidence; set {cityFactResidence = value; OnPropertyChanged(); } }
        public City CityOfRegistration { get => cityOfRegistration; set { cityOfRegistration = value; OnPropertyChanged(); } }
        public FamilyPosition FamilyPosition { get => familyPosition; set { familyPosition = value; OnPropertyChanged(); } }
        public Citizenship Citizenship { get => citizenship; set { citizenship = value; OnPropertyChanged(); } }
        public Disability Disability { get => disability; set { disability = value; OnPropertyChanged(); } }
    }
}
