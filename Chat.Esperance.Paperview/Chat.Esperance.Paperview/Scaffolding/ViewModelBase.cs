using System;
using System.Threading.Tasks;

namespace Chat.Esperance.Paperview.Scaffolding
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

        #region IDisposable members
        public void Dispose()
        {

        }
        #endregion

        public ViewModelBase()
        {

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
