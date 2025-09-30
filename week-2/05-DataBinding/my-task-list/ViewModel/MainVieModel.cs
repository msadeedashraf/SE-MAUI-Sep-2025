using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace my_task_list.ViewModel
{
    public partial class MainVieModel : ObservableObject
    {
        public MainVieModel() {

            Items = new ObservableCollection<string>();
        
        }


        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;


        
        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;


            Items.Add(Text);
            Text = string.Empty;

        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
            { 
                Items.Remove(s);
            } 
        }


    }
}
