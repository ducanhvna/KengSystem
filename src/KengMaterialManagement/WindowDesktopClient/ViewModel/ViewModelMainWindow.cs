using CommonNS.Helpers;
using CommonNS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowDesktopClientNS.KengServiceReference;

namespace WindowDesktopClientNS.ViewModel
{
    class ViewModelMainWindow : ViewModelBase
    {
        Service1Client m_client = new Service1Client();
        private string m_Message;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public ViewModelMainWindow()
        {
            Message = m_client.GetData(9);
            ListStoreSupported abcd = new ListStoreSupported
            {
                
            };
            var abc = m_client.GetListStoreSupported(abcd);
            // Initalize create new store command
            CreateNewStoreCommand = new RelayCommand(CreateNewStore);
        }
        #endregion

        #region Dumy Data
        /// <summary>
        /// Message
        /// </summary>
        public string Message
        {
            get {
                return  m_Message;
            }
            private set
            {
                if(m_Message != value)
                {
                    m_Message = value;
                    RaisePropertyChanged("Message");
                }
            }
        }
        #endregion

        #region Create new Container
        public RelayCommand CreateNewStoreCommand { get; private set; }

        private void CreateNewStore(object param)
        {

        }
        #endregion
    }
}
