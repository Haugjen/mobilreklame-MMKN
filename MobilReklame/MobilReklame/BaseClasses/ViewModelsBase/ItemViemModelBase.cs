using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.BaseClasses
{
/// <summary>
    /// A domain-specific item view model class 
    /// must inherit from this class
    /// </summary>
    /// <typeparam name="TDomainClass">Type of domain class</typeparam>
    public abstract class ItemViewModelBase<TDomainClass>
        where TDomainClass : class
    {
        /// <summary>
        /// A derived class must call this constructor
        /// </summary>
        /// <param name="obj">Enclosed domain object</param>
        protected ItemViewModelBase(TDomainClass obj)
        {
            DomainObject = obj;
        }

        /// <summary>
        /// The domain object enclosed by the
        /// item view model object
        /// </summary>
        public TDomainClass DomainObject;
    }
}
