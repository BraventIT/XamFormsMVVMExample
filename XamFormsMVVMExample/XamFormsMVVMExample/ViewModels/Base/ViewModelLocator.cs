using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace XamFormsMVVMExample.ViewModels.Base
{
    public class ViewModelLocator
    {
        readonly IUnityContainer _container;

        public ViewModelLocator()
        {
            _container = new UnityContainer();
            #region Viewmodels
            _container.RegisterType<MainPageViewModel>();
            #endregion
        }

        public MainPageViewModel MainPageViewModel
        {
            get { return _container.Resolve<MainPageViewModel>(); }
        }

    }
}
