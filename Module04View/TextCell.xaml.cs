using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class TextCell : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        public TextCell()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Monke Da Manke", Position = "President", Image = "https://play-lh.googleusercontent.com/G0HLFaMWBv9HRz0-tz-dRNQ7KAv7Woi7izS1GYvDcU0L_d3o0MZfohHVSQRN2ZkKYU4=w2560-h1440-rw" });
            employees.Add(new Employee { DisplayName = "Huh Da Catto", Position = "Lazy Catto", Image = "" });
            employees.Add(new Employee { DisplayName = "Doge Da Boi", Position = "Good Boi", Image = "" });
            employees.Add(new Employee { DisplayName = "Capy the Capybro", Position = "Chill Guy", Image = "" });
            employees.Add(new Employee { DisplayName = "Dolphin The Swole", Position = "Gymbro", Image = "" });
        }
        public void Menu_Delete(Object sender, EventArgs e)
        {
            DisplayAlert("Delete", "Are you sure", "OK");
        }
        public void Menu_More(Object sender, EventArgs e)
        {
            DisplayAlert("More", "More info", "OK");

        }

       }
    }