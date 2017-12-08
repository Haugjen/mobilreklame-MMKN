using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobilReklame.BaseClasses
{
/// <summary>
    /// This class is intended to be a base class for a MasterDetails 
    /// view model classes. A domain-specific class must inherit from
    /// this class, and call its constructor with a domain-specific 
    /// catalog object and a domain-specific factory object.
    /// </summary>
    public abstract class MasterDetailsViewModelBase<TData,T, TKey> : INotifyPropertyChanged
    where TKey : IKey<TKey>
    where T : TKey, new()
    {
        #region Instance fields
        private CatalogBase<TData, T, TKey> _catalog;
        private ViewModelFactoryBase<TData, T, TKey> _factory;
        private ItemViewModelBase<TKey> _itemViewModelSelected;
        private TData _dataPackage;
        private DeleteCommandBase<TData,T, TKey> _deleteCommand;
        private CreateCommandBase<TData,T, TKey> _createCommand;
        #endregion

        #region Constructor
        /// <summary>
        /// Create the MasterDetails view model object, with 
        /// references to a catalog object and a factory object
        /// </summary>
        protected MasterDetailsViewModelBase(
            CatalogBase<TData, T, TKey> catalog,
            ViewModelFactoryBase<TData, T, TKey> factory)
        {
            _catalog = catalog;
            _factory = factory;
            _itemViewModelSelected = null;
            _deleteCommand = new DeleteCommandBase<TData,T, TKey>(_catalog, this);
            _createCommand = new CreateCommandBase<TData,T, TKey>(_catalog, _dataPackage);
            //_editCommand = new EditCommandBase<TDomainClass, MasterDetailsViewModelBase<TDomainClass>>(_catalog, this);
        }
        #endregion

        #region Properties for Data Binding
        /// <summary>
        /// Deletion command property. The view can bind 
        /// to this property.
        /// </summary>
        public ICommand DeletionCommand
        {
            get { return _deleteCommand; }
        }
        public ICommand CreateCommand
        {
            get { return _createCommand; }
        }
        /// <summary>
        /// Get a collection of item view models.
        /// The view can bind to this property
        /// </summary>
        public List<ItemViewModelBase<TKey>> ItemViewModelCollection
        {
            get { return _factory.GetItemViewModelCollection(_catalog); }
        }
        /// <summary>
        /// The item view model currently selected.
        /// The view can bind to this property
        /// </summary>
        public ItemViewModelBase<TKey> ItemViewModelSelected
        {
            get { return _itemViewModelSelected; }
            set
            {
                _itemViewModelSelected = value;
                //_deleteCommand.RaiseCanExecuteChanged();
                OnPropertyChanged();
            }
        }

        public TData DataPackage {
            get => _dataPackage;
            set => value = _dataPackage;
        }
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
