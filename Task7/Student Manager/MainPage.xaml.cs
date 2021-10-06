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
using Student_Manager.models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Student_Manager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<studentlist> Studentlists;
        public MainPage()
        {
            this.InitializeComponent();
            Studentlists = new ObservableCollection<studentlist>();
            Studentlists.Add(new studentlist { Name = "Đông", YearofBirth = "2002" , AvatarPath = "https://zemahair.com/wp-content/uploads/2021/03/kieu-toc-cho-nguoi-map-mat-tron.jpg" });
            Studentlists.Add(new studentlist { Name = "Đông", YearofBirth = "2002" , AvatarPath = "https://zemahair.com/wp-content/uploads/2021/03/kieu-toc-cho-nguoi-map-mat-tron.jpg" });
            Studentlists.Add(new studentlist { Name = "Đông", YearofBirth = "2002" , AvatarPath = "https://zemahair.com/wp-content/uploads/2021/03/kieu-toc-cho-nguoi-map-mat-tron.jpg" });
            Studentlists.Add(new studentlist { Name = "Đông", YearofBirth = "2002" , AvatarPath = "https://zemahair.com/wp-content/uploads/2021/03/kieu-toc-cho-nguoi-map-mat-tron.jpg" });

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Studentlists.Add(new studentlist { Name = addName.Text, YearofBirth = adđYear.Text, AvatarPath = addAvt.Text });
            AddStudent.Hide();
        }
    }
}
