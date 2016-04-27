using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Autofac;
using Chat.Esperance.PaperviewApi.Interfaces;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi.Scaffolding
{
    public abstract class ViewModelBase<TNavigationParameter> : ViewModelBase
    {
        public new TNavigationParameter NavigationParameter => (TNavigationParameter)base.NavigationParameter;
    }

    public class ViewModelBase : PropertyChangedBase, IDisposable
    {
        /// <summary>
        /// When IsGhosted is set to true, the navigator will not create a page but instead
        /// expect the ViewModel to call Show(ViewModel) after some logic operations are carried out.
        /// This is promarily designed for the bootup process so that the BootViewModel can determine which page
        /// to navigate to.
        /// </summary>
        public bool IsGhosted { get; set; }

        public virtual void OnStart() { }
        public virtual void OnSleep() { }
        public virtual void OnResume() { }

        private ICommand _masterDetailCommand;

        public ICommand MasterDetailCommand
        {
            get { return _masterDetailCommand; }
            set { _masterDetailCommand = value; RaisePropertyChanged(); }
        }

        #region IDisposable members
        public void Dispose()
        {

        }
        #endregion

        public ViewModelBase()
        {
            this.MasterDetailCommand = new Command((p) =>
            {
                using (var scope = DI.Container.BeginLifetimeScope())
                {
                    var service = scope.Resolve<INavigationService>();

                    service.MasterDetailAction.Invoke(service.MasterDetailIsOpen);
                }
            });
        }

        public virtual Task Initialize()
        {
            return Task.FromResult(true);
        }

        public virtual Task Initialize(object navigationParameter)
        {
            NavigationParameter = navigationParameter;
            return Initialize();
        }

        public object NavigationParameter { get; private set; }

        public bool IsInitialized { get; set; }

        public virtual void OnAppear()
        {

        }


    }
}
