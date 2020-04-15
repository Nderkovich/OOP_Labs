using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab7
{

    public enum Category
    {
        HOME,
        WORK,
        STUDY,
        REST
    }

    [Serializable]
    public class TodoTask: IDataErrorInfo, INotifyPropertyChanged
    {
        private TimeSpan time;
        private String name;
        private String description;
        private int repeatPeriod;
        private int priority;
        private Category category;

        public TodoTask(TimeSpan time, string name, string description, int repeatPeriod, int priority, Category category)
        {
            this.time = time;
            this.name = name;
            this.description = description;
            this.repeatPeriod = repeatPeriod;
            this.priority = priority;
            this.category = category;
        }

        public TodoTask() {
            name = String.Empty;
            description = String.Empty;
        }


        #region GetterSetter
        public TimeSpan Time
        {
            get => time;
            set
            {
                time = value;
                OnPropertyChanged("Time");
            }
        }

        public string Name { 
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Description
        {
            get => description;
            set { 
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public int RepeatPeriod
        {
            get => repeatPeriod;
            set { 
                repeatPeriod = value;
                OnPropertyChanged("RepeatPeriod");
            }
        }

        public int Priority { 
            get => priority;
            set { 
                priority = value;
                OnPropertyChanged("Priority");
            }
        }

        public Category Category
        {
            get => category;
            set { 
                category = value;
                OnPropertyChanged("Category");
            }
        }

        #endregion


        #region Validation
        private string _error;

        public string Error
        {
            get => _error;
            set
            {
                if (_error != value)
                {
                    _error = value;
                    OnPropertyChanged("Error");
                }
            }
        }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Name":
                        if (Name.Length < 4 )
                        {
                            error = "Name length cant be less than 4";
                        }
                        break;
                    case "Description":
                        if (Description.Length < 4)
                        {
                            error = "Description length cant be less than 4";
                        }
                        break;
                    case "RepeatPeriod":
                        if (RepeatPeriod > 365 || RepeatPeriod < 0)
                        {
                            error = "Repeat period must be between 0 and 365";
                        }
                        break;
                    case "Priority":
                        if (Priority < 0 || Priority > 3)
                        {
                            error = "Priority must be between 0 and 3";
                        }
                        break;
                }
                if (error == String.Empty)
                {
                    Error = null;
                }
                else
                {
                    Error = error;
                }
                return error;
            }
        }
        #endregion


        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                TodoTask task = obj as TodoTask;
                if (task != null)
                    return Equals(this.name, task.name);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        //INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
