using System;
using System.ComponentModel;

namespace TriggerUpdateDemo.Data
{
    public class MyData : INotifyPropertyChanged
    {
        // Declare the PropertyChanged event required for the INotifyPropertyChanged interface.
        public event PropertyChangedEventHandler PropertyChanged;

        private string colorName = "Orange";
                
        public string ColorName
        {
            get
            {
                return this.colorName;
            }
            set
            {
                // Check that the incoming value is different,
                // to prevent unnecessary change notifications.
                if (this.colorName != value)
                {
                    this.colorName = value;
                    // Call the OnPropertyChanged method whenever the
                    // property is updated.
                    OnPropertyChanged("ColorName");
                }
            }
        }

        // Create the OnPropertyChanged method to raise the event.
        protected void OnPropertyChanged(string name)
        {
            var handler = this.PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}