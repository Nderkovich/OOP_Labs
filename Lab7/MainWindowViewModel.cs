using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace Lab7
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TodoDate> dates = new ObservableCollection<TodoDate>();
        private ObservableCollection<TodoTask> tasks = new ObservableCollection<TodoTask>();
        private TodoTask task;
        private TodoDate selectedDate;
        XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<TodoDate>));


        #region GetterSetter
        public List<TodoDate> Dates { get; set; }

        public TodoTask Task { 
            get => task;
            set
            {
                task = value;
                OnPropertyChanged("Task");
            }
        }

        public TodoDate SelectedDate { 
            get => selectedDate;
            set
            {
                selectedDate = value;
                SelectionError = false;
                OnPropertyChanged("SelectedDate");
                OnPropertyChanged("Sort");
                Tasks = selectedDate.Tasks;
            }
        }

        public ObservableCollection<TodoTask> Tasks
        {
            get => tasks;
            set { 
                tasks = value;
                OnPropertyChanged("Tasks");
            }
        }

        //Selected index
        private int _recordIndex;

        public int RecordIndex
        {
            get { return _recordIndex; }
            set
            {
                _recordIndex = value;
                OnPropertyChanged("RecordIndex");
            }
        }

        private bool selectionError = true;

        public bool SelectionError
        {
            get { return selectionError;  }
            set
            {
                selectionError = value;
                OnPropertyChanged("SelectionError");
            }
        }

        #endregion

        #region Commands
        private RelayCommand deleteCommand;
        private RelayCommand sort;
        private RelayCommand saveToXML;

        public RelayCommand Sort
        {
            get
            {
                if (selectedDate != null)
                    return sort ??
                      (sort = new RelayCommand(obj =>
                      {
                          Category categor = (Category)Enum.Parse(typeof(Category), obj.ToString());
                          Tasks = new ObservableCollection<TodoTask>(selectedDate.Tasks.Where(p => p.Category == categor));
                          OnPropertyChanged("Tasks");
                      }));
                else
                    return null;
            }
        }

        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                    (deleteCommand = new RelayCommand(obj =>
                    {
                        tasks.RemoveAt(RecordIndex);
                        OnPropertyChanged("Tasks");
                    }));
            }
        }

        public RelayCommand SaveToXML
        {
            get
            {
                return saveToXML ??
                    (saveToXML = new RelayCommand(obj =>
                    {
                        using (FileStream fs = new FileStream("labaratory.xml", FileMode.Create))
                        {
                            formatter.Serialize(fs, dates);
                        }
                    }));
            }
        }
        #endregion

        #region Helpers

        public void Calendar_SelectedDatesChanged(object sender,
                                                  SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;
            if (calendar.SelectedDate.HasValue)
            {
                var date = new TodoDate(calendar.SelectedDate.Value);
                SelectedDate = GetTodoDate(date);
                OnPropertyChanged("SelectedDate");
            }
        }

        public void AddTask(TodoTask task)
        {
            if (selectedDate != null)
            {
                if (!selectedDate.Tasks.Contains(task))
                {
                    selectedDate.AddTask(task);
                    if (task.RepeatPeriod > 0)
                    {
                        var date = new TodoDate(SelectedDate.Date.AddDays(task.RepeatPeriod));
                        GetTodoDate(date).AddTask(new TodoTask(task.Time, task.Name, task.Description, 0, task.Priority, task.Category));
                    }
                }
            }
        }

        //Check if date is in the list
        private TodoDate GetTodoDate(TodoDate date)
        {
            if (!dates.Contains(date))
            {
                dates.Add(date);
            }
            return dates[dates.IndexOf(date)];
        }
        #endregion


        //INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
