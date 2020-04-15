using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Context
        {
            public MainWindowViewModel mainWindow { get; } = new MainWindowViewModel();
            public TodoTask todoTask { get; } = new TodoTask();
        }
        Context ctx = new Context();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = ctx;
            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }
        }


        #region Buttons

        //Calendar
        private void MonthlyCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            ctx.mainWindow.Calendar_SelectedDatesChanged(sender, e);
        }


        //Add button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan time = TimeSpan.Parse(this.time.Text);
            string name = this.name.Text;
            string description = this.description.Text;
            int priority = Convert.ToInt32(this.priority.Text);
            int repeat = Convert.ToInt32(this.repeat.Text);
            Category category = (Category)Enum.Parse(typeof(Category), this.type.Text);
            TodoTask task = new TodoTask(time, name, description, repeat, priority, category);
            ctx.mainWindow.AddTask(task);
        }

        #endregion

        #region Lang

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }

        }

        #endregion
    }
}
