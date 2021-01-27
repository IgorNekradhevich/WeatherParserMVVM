
using System.ComponentModel;
namespace WpfApp14
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void Update(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        Weather weather;
        public ViewModel()
        {
            WeatherManager weatherManager = new WeatherManager(new YandexSiteParser());
            weather = new Weather(weatherManager.GetInfo(),"c:\\1\\2.png","Солнечно");

        }
    }
}
