using MVVMSample2.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMSample2
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public Person CurrentPerson { get; set; }
        public MainPage()
        {
            InitializeComponent();
            LoadData();

            BindingContext = CurrentPerson;

            //txtName.BindingContext = CurrentPerson;
            //txtName.SetBinding(Entry.TextProperty, "Name");

            //Binding personBinding = new Binding();
            //personBinding.Source = CurrentPerson;
            //personBinding.Path = "Name";
            
            //txtName.SetBinding(Entry.TextProperty, personBinding):

        }

        private void LoadData()
        {
            //Connecting to Web Service
            CurrentPerson = new Person
            {
                Name = "Hector",
                Phone = "99999",
                Address = "X Address"
            };
            //txtName.Text = CurrentPerson.Name;
            //txtPhone.Text = CurrentPerson.Phone;
            //txtAddress.Text = CurrentPerson.Address;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Saving", "Saving Data", "Ok");
            //CurrentPerson.Name = "Juan";
            //CurrentPerson.Phone = "0000000";
            //CurrentPerson.Address = "Z Adress";
            CurrentPerson = new Person
            {
                Name = "Juan",
                Phone = "000000",
                Address = "Z Address"
            };
        }
    }
}
