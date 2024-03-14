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
    public partial class ImageCell : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public ImageCell()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee
            {
                DisplayName = "Monke Da Manke",
                Position = "President",
                Image = "https://play-lh.googleusercontent.com/G0HLFaMWBv9HRz0-tz-dRNQ7KAv7Woi7izS1GYvDcU0L_d3o0MZfohHVSQRN2ZkKYU4=w2560-h1440-rw   "
            });

            employees.Add(new Employee
            {
                DisplayName = "Huh Da Catto",
                Position = "Lazy Catto",
                Image = "https://i.kym-cdn.com/entries/icons/original/000/046/895/huh_cat.jpg"
            });

            employees.Add(new Employee
            {
                DisplayName = "Doge Da Boi",
                Position = "Good Boi",
                Image = "https://www.cnet.com/a/img/resize/61c44c6765cb6b8529df884935ad7aefc622aeec/hub/2021/11/03/3c2a7d79-770e-4cfa-9847-66b3901fb5d7/c09.jpg?auto=webp&fit=crop&height=675&width=1200"
            });

            employees.Add(new Employee
            {
                DisplayName = "Capy the Capybro",
                Position = "Chill Guy",
                Image = "https://i.ytimg.com/vi/UftvAlBiahE/sddefault.jpg"
            });

            employees.Add(new Employee
            {
                DisplayName = "Dolphin The Swole",
                Position = "Gymbro",
                Image = "https://static.wikia.nocookie.net/zendikar/images/9/9c/Dolphin_Muscle_by_ripped_saurian.jpg/revision/latest?cb=20100103080316"
            });
        }
    }
}