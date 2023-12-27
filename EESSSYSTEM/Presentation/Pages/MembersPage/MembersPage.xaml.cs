using EESSSYSTEM.Core;
using EESSSYSTEM.Domain.Entities;
using EESSSYSTEM.Domain.Usecases;
using EESSSYSTEM.Presentation.Pages.MembersPage.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using EESSSYSTEM.Presentation.Pages.MembersPage;
using EESSSYSTEM.Presentation.Pages.MembersPage.MVVM;

namespace EESSSYSTEM.Presentation.Pages.MembersPage
{
    /// <summary>
    /// Lógica de interacción para MembersPage.xaml
    /// </summary>
    public partial class MembersPage : UserControl
    {

        private readonly MembersPageViewModel _mainViewModel;
        public MembersPage()
        {
            InitializeComponent();
            _mainViewModel = new MembersPageViewModel();
            DataContext = _mainViewModel;

            Loaded += (sender, e) =>
            {
                _mainViewModel.InitCommand.Execute(this);
            };
        }

        private void BtnDeletedMemberSelected_Click(object sender, RoutedEventArgs e)
        {

        }


        private void BtnAlphabet_Click(object sender, RoutedEventArgs e)
        {
            /*this.listMembers = this.listMembers.OrderBy(nombre => nombre.Name).ToList();
            DtgMembers.ItemsSource = null;
            DtgMembers.ItemsSource = this.listMembers;*/
        }

        private void BtnAddMember_Click(object sender, RoutedEventArgs e)
        {
             grdDialogFormRegister.Children.Clear();
             grdDialogFormRegister.Children.Add(new FormRegisterComp());
             grdMain.IsEnabled = false;
             DialogoHost1.IsOpen = true;
        }
    }
}
