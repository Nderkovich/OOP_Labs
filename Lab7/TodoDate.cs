using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    [Serializable]
    public class TodoDate: INotifyPropertyChanged
    {
        private DateTime date;
        private ObservableCollection<TodoTask> tasks;

        public TodoDate() { }

        public TodoDate(DateTime date)
        {
            Date = date;
            tasks = new ObservableCollection<TodoTask>();
        }


        #region GetterSetter
        public DateTime Date { 
            get => date; 
            set {
                date = value;
                OnPropertyChanged("Date");
            } 
        }

        public ObservableCollection<TodoTask> Tasks { 
            get => tasks;
            set
            {
                tasks = value;
                OnPropertyChanged("Tasks");
            }
        }
        #endregion


        #region WorkWithCollection
        public void AddTask(TodoTask task)
        {
            tasks.Add(task);
            OnPropertyChanged("Tasks");
        }

        public void RemoveTask(TodoTask task)
        {
            tasks.Remove(task);
        }
        #endregion



        public override bool Equals(object obj)
        {
            TodoDate date = obj as TodoDate;
            return Equals(this.Date, date.Date);
        }

        public override int GetHashCode()
        {
            return date.GetHashCode();
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
