using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Bai_1
{
    internal class MemberModel
    {
        private string _fullName = "";
        private string _phone = "";
        private string _package = "Theo tháng";
        private DateTime _startDate = DateTime.Today;
        private decimal _fee;

        public string MemberId { get; set; } = "";

        public string FullName
        {
            get => _fullName;
            set { _fullName = value; OnPropertyChanged(nameof(FullName)); }
        }

        public string Phone
        {
            get => _phone;
            set { _phone = value; OnPropertyChanged(nameof(Phone)); }
        }

        public string Package
        {
            get => _package;
            set { _package = value; OnPropertyChanged(nameof(Package)); }
        }

        public DateTime StartDate
        {
            get => _startDate;
            set { _startDate = value; OnPropertyChanged(nameof(StartDate)); }
        }

        public decimal Fee
        {
            get => _fee;
            set { _fee = value; OnPropertyChanged(nameof(Fee)); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
