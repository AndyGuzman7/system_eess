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

namespace EESSSYSTEM.Presentation.Pages.MembersPage.Components
{
    /// <summary>
    /// Lógica de interacción para FormRegisterComp.xaml
    /// </summary>
    public partial class FormRegisterComp : UserControl, IManejadorEvento
    {
        public FormRegisterComp()
        {
            InitializeComponent();
        }

        public event EventHandler MiEvento;
        protected virtual void OnMiEvento()
        {
            MiEvento?.Invoke(this, EventArgs.Empty);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }

    public interface IManejadorEvento
    {
        event EventHandler MiEvento;
    }
}
