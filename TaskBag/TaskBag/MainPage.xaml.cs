using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TaskBag
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            noteslist.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Note selectedNote = (Note)e.SelectedItem;
            NotePage notePage = new NotePage();
            notePage.BindingContext = selectedNote;
            await Navigation.PushAsync(notePage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateNote(object sender, EventArgs e)
        {
            Note note = new Note();
            NotePage notePage = new NotePage();
            notePage.BindingContext = note;
            await Navigation.PushAsync(notePage);
        }
    }
}
