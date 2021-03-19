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
using System.Text.RegularExpressions;
using System.IO;


namespace Hesla
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        Regex regex = new Regex("^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{6,}$");
        string jmeno;
        string heslo;
        
        List<string> jmenaList = new List<string>();
        private void buttonHotovo_Click(object sender, RoutedEventArgs e)
        {
            jmeno = textJmeno.Text;
            heslo = textHeslo.Text;
            bool isPassword(string _heslo)
            {
                if (regex.IsMatch(heslo)) 
                    return true;
                else
                    return false;
            }


            if(!jmenaList.Contains(jmeno))
            {
                if ((isPassword(heslo)) && (jmeno != ""))
                {

                    MessageBox.Show("Můžete zavřít aplikaci", "Registrace proběhla úspěšně!", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window.WindowStyle = WindowStyle.SingleBorderWindow;
                    jmenaList.Add(jmeno);
                }
                else               
                    MessageBox.Show("Heslo musí mít alespoň 6 znaků a obsahovat minimálně jednu číslici", "Chybně zadané heslo nebo uživatelské jméno", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
            else
                MessageBox.Show("Toto jméno je zabrané", "Vyberte jiné uživatelské jméno", MessageBoxButton.OK, MessageBoxImage.Error);
        }
       
    }
}
