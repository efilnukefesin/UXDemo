using NET.efilnukefesin.Apps.UXDemo.ViewModelLocator.Attributes;
using NET.efilnukefesin.Apps.UXDemo.ViewModelLocator.Interfaces;
using NET.efilnukefesin.Implementations.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.ViewModelLocator
{
    public class VMLocator : ILocator
    {
        #region Properties

        private Dictionary<string, object> registeredInstances = new Dictionary<string, object>();

        #endregion Properties

        #region Construction

        public VMLocator()
        {
            this.findViewModels();
        }

        #endregion Construction

        #region Methods

        #region Register
        public void Register(string name, object o)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            if (!registeredInstances.ContainsKey(name))
            {
                this.registeredInstances.Add(name, o);
            }
            else
            {
                throw new Exception(String.Format("Instance with name '{0}' already registered", name));
            }
        }
        #endregion Register

        #region GetInstance
        public object GetInstance(string name)
        {
            if (registeredInstances.ContainsKey(name))
            {
                return registeredInstances[name];
            }
            return null;
        }
        #endregion GetInstance

        public object this[string name]
        {
            get
            {
                return GetInstance(name);
            }
        }

        #region findViewModels
        private void findViewModels()
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly currentAssembly in assemblies)
            {
                foreach (Type currentType in currentAssembly.GetTypes())
                {
                    foreach (object customAttribute in currentType.GetCustomAttributes(true))
                    {
                        LocatorAttribute locAttribute = customAttribute as LocatorAttribute;
                        if (locAttribute != null)
                        {
                            if (!registeredInstances.ContainsKey(locAttribute.Name))
                            {
                                object instance = DiManager.GetInstance().Resolve(currentType);
                                registeredInstances.Add(locAttribute.Name, instance);
                            }
                        }
                    }
                }
            }
        }
        #endregion findViewModels

        #endregion Methods
    }
}
