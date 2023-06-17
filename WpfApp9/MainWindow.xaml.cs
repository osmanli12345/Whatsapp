using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<MessageItem> messages;
        public MainWindow()
        {
            InitializeComponent();
            messages=new ObservableCollection<MessageItem>();
            ListBox.ItemsSource=messages;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message=TextBox.Text;
            string timeStamp = DateTime.Now.ToString("HH:mm");
            MessageItem item = new MessageItem { Message=message, TimeStamp=timeStamp };
            messages.Add(item);
            //ListBox.Items.Add(message);
            TextBox.Text = "";
        }
        public class MessageItem
        {
            public string Message { get; set; }
            public string TimeStamp { get; set; }

        }
    }
}
