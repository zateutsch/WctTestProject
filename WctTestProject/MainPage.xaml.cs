using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WctTestProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<ListItem> Items = new ObservableCollection<ListItem>();
        public ListItem currentItem;
        public double initialListMaxHeight = Window.Current.Bounds.Height;
        public double initialListMaxWidth = Window.Current.Bounds.Width;

        public MainPage()
        {
            this.InitializeComponent();
            RegisterEventHandler();
            for(int i = 0; i < 1000; i++)
            {
                Items.Add(new ListItem("test string"));
            }
        }

        private void RegisterEventHandler()
        {
            myList.MaxHeight = Window.Current.Bounds.Height;
            myList.MaxWidth = Window.Current.Bounds.Width;
            test.SizeChanged += new SizeChangedEventHandler(this.List_SizeChanged);
        }

        private void List_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            myList.MaxHeight = Window.Current.Bounds.Height;
            myList.MaxWidth = Window.Current.Bounds.Width;
        }
    }

    public class ListItem
    {
        public string text;
        public ListItem(string txt)
        {
            this.text = txt;
        }
    }
}
