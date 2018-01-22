using mvvm.Models;

namespace mvvm.ViewModels
{
    class MainViewModel
    {
        DataManager dataManager = new DataManager();
        public Person currentPerson { get; set; }

        public MainViewModel()
        {
            currentPerson = dataManager.ImportantPerson;
        }
    }
}
