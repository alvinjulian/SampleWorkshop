using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SampleWorkshop
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<MSP> pemain = new ObservableCollection<MSP>();

        public MainPage()
        {
            this.InitializeComponent();

            pemain.Add(new MSP
            {
                Foto = "Photos/De Gea.jpg",
                Nama = "Muhamad Iqbal",
                Klub = "Universitas Gunadarma",
                Deskripsi = "lalalalalalalalalalalalalala"
            });
            pemain.Add(new MSP
            {
                Foto = "Photos/Juan Mata.jpg",
                Nama = "Alvin Julian",
                Klub = "Surya University",
                Deskripsi = "huehuhuehuehuheheuheuheueueu"
            });

            pemain.Add(new MSP
            {
                Foto = "Photos/Luke Shaw.jpg",
                Nama = "Deni Pramulia",
                Klub = "Universitas Indonesia",
                Deskripsi = "jajajajajajajajajjajaja"
            });

            this.listview_item.ItemsSource = pemain;
        }

        private void listview_item_ItemClick(object sender, ItemClickEventArgs e)
        {
            MSP data = (SampleWorkshop.MSP)e.ClickedItem;
            Frame.Navigate(typeof(DetailView), data);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }
    }
}
