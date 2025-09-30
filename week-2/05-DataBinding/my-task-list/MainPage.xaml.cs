using my_task_list.ViewModel;

namespace my_task_list
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage(MainVieModel vm)
        {
            InitializeComponent();
            BindingContext = vm;

        }

       
    }

}
