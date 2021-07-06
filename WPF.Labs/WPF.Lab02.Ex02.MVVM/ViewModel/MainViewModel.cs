using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WPF.Lab02.Ex01.MVVM.Model;
using System.Windows;
using System.Windows.Input;

namespace WPF.Lab02.Ex01.MVVM.ViewModel
{
    public class MainViewModel
    {
        #region Properties
        /// <summary>
        /// Get or set people.
        /// </summary>
        public PeopleModel People { get; set; }
        #endregion
        
        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        public MainViewModel()
        {
            People = new PeopleModel
            {
                FirstName = "First name",
                LastName = "Last name"
            };
        }
        #endregion

      
    }
}
