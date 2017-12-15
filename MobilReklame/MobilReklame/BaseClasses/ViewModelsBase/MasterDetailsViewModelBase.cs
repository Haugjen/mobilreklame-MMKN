using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobilReklame
{
    public abstract class MasterDetailsViewModelBase<TData, T, TKey> : INotifyPropertyChanged
    // where TKey : IKey<TKey>
    where TData : IKey<TKey>, new()
    where T : IKey<TKey>, new()
    {
        #region Instance fields
        protected CatalogBase<TData, T, TKey> _catalog;
        private T _obj;
        protected ViewModelFactoryBase<TData, T, TKey> _factory;
        protected ItemViewModelBase<T, TKey> _itemViewModelSelected;
        protected TData _dataPackage;
        protected DeleteCommandBase<TData, T, TKey> _deleteCommand;
        protected CreateCommandBase<TData, T, TKey> _createCommand;
        protected EditCommandBase<TData, T, TKey> _editCommand;
        #endregion

        #region Constructor
        protected MasterDetailsViewModelBase(
            CatalogBase<TData, T, TKey> catalog,
            ViewModelFactoryBase<TData, T, TKey> factory)
        {
            _catalog = catalog;
            _factory = factory;
            _itemViewModelSelected = null;
            _dataPackage = new TData();
            _deleteCommand = new DeleteCommandBase<TData, T, TKey>(_catalog, this);
            _createCommand = new CreateCommandBase<TData, T, TKey>(_catalog, this);
            _editCommand = new EditCommandBase<TData, T, TKey>(_catalog, this);
            _catalog.Load();
        }
        #endregion
        #region Properties for Data Binding
        #region Commands
        public ICommand DeletionCommand
        {
            get { return _deleteCommand; }
        }
        public ICommand CreateCommand
        {
            get { return _createCommand; }
        }
        public ICommand EditCommand
        {
            get{ return _editCommand; }
        }
        #endregion
        public List<ItemViewModelBase<T,TKey>> ItemViewModelCollection
        {
            get { return _factory.GetItemViewModelCollection(_catalog); }
        }
  
        public ItemViewModelBase<T, TKey> ItemViewModelSelected
        {
            get { return _itemViewModelSelected; }
            set
            {
                _itemViewModelSelected = value;
                _deleteCommand.RaiseCanExecuteChanged();
                _editCommand.RaiseCanExecuteChanged();
                OnPropertyChanged();
            }
        }
        public TData DataPackage {
            get => _dataPackage;
            set => _dataPackage = value;
        }
        protected T Obj { get => _obj; set => _obj = value; }
        #endregion

        #region Methods
        public void RefreshItemViewModelCollection()
        {
            OnPropertyChanged(nameof(ItemViewModelCollection));
        }
        #endregion
        #region OnPropertyChanged code
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
