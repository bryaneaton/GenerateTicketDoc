﻿using System;
using System.ComponentModel;

namespace GenerateTicketDoc
{
    public class Ticket : INotifyPropertyChanged
    {
        private string _firstName;
        public string firstName
        {
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("firstName"));
                }
            }
            get
            {
                return _firstName;
            }
        }

        private string _lastName;
        public string lastName
        {
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("lastName"));
                }
            }
            get
            {
                return _lastName;
            }
        }
        public string name
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        private string _phoneNumber;
        public string phoneNumber
        {
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("phoneNumber"));
                }
            }
            get
            {
                return _phoneNumber;
            }
        }

        private string _email;
        public string eMail
        {
            set
            {
                if (_email != value)
                {
                    _email = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("eMail"));
                }
            }
            get
            {
                return _email;
            }
        }

        private string _ticketNumber;
        public string ticketNumber
        {
            set
            {
                _ticketNumber = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("ticketNumber"));
            }
            get
            {
                return _ticketNumber;
            }
        }

        private string _date = String.Format("{0:d}", DateTime.Now);
        public string date
        {
            set
            {
                _date = value;
            }
            get
            {
                return _date;
            }
        }

        private string _systemAffected1;
        public string systemAffected1
        {
            set
            {
                if (_systemAffected1 != value)
                {
                    _systemAffected1 = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("systemAffected1"));
                }
            }
            get
            {
                return _systemAffected1;
            }
        }
        private string _systemAffected2;
        public string systemAffected2
        {
            set
            {
                if (_systemAffected2 != value)
                {
                    _systemAffected2 = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("systemAffected2"));
                }
            }
            get
            {
                return _systemAffected2;
            }
        }

        private string _rollback1;
        public string rollBack1
        {
            set
            {
                if (_rollback1 != value)
                {
                    _rollback1 = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("rollback1"));
                }
            }
            get
            {
                return _rollback1;
            }
        }

        private string _rollback2;
        public string rollBack2
        {
            set
            {
                if (_rollback2 != value)
                {
                    _rollback2 = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("rollback2"));
                }
            }
            get
            {
                return _rollback2;
            }
        }

        private string _description;
        public string description
        {
            set
            {
                if (_description != value)
                {
                    _description = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("description"));
                }
            }
            get
            {
                return _description;
            }
        }

        private string _testingDescription;
        public string testingDescription
        {
            set
            {
                if (_testingDescription != value)
                {
                    _testingDescription = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("testingDescription"));
                }
            }
            get
            {
                return _testingDescription;
            }
        }

        private string _analystName;
        public string analystName
        {
            set
            {
                if (_analystName != value)
                {
                    _analystName = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("analystName"));
                }
            }
            get
            {
                return _analystName;
            }
        }

        private string _applicationName;
        public string applicationName
        {
            set
            {
                if (_applicationName != value)
                {
                    _applicationName = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("applicationName"));
                }
            }
            get
            {
                return _applicationName;
            }
        }

        private string _department;
        public string department {
            set
            {
                if (_department != value)
                {
                    _department = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("department"));
                }
            }
            get
            {
                return _department;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }

    }
}