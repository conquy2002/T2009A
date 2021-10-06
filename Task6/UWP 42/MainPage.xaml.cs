using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWP_42.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_42
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<Contact> Contacts;
        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "https://i.imgur.com/e121Kzu.jpg" });
            Icons.Add(new Icon { IconPath = "https://i.imgur.com/e121Kzu.jpg" });
            Icons.Add(new Icon { IconPath = "https://i.imgur.com/e121Kzu.jpg" });
            Icons.Add(new Icon { IconPath = "https://i.imgur.com/e121Kzu.jpg" });
            Icons.Add(new Icon { IconPath = "https://i.imgur.com/e121Kzu.jpg" });
            Icons.Add(new Icon { IconPath = "https://i.imgur.com/e121Kzu.jpg" });

            Contacts = new ObservableCollection<Contact>();
        }

        private void NewContactButoon_Click(object sender, RoutedEventArgs e)
        {
            string avt = ((Icon)AvtComboBox.SelectedValue).IconPath;
            Contacts.Add(new Contact { FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text , AvatarPath = avt });
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            AvtComboBox.SelectedIndex = -1;
        }
    }
}
