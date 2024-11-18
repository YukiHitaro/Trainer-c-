using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TypingTrainer.Utils
{
    public class BindableBase : INotifyPropertyChanged
    {
        // A dictionary that holds all properties here which makes it easier to undo/redo things I hope.
        // We could save the previous state of this Dictionary in some way to get undo capabilities.
        // however we also need a global order or changes then. Since each class inheriting from BinableBase has their own Dictionary we need something more.
        private Dictionary<string, object> _properties = new Dictionary<string, object>();

        /// <summary>
        /// Gets the value of a property (a tad bit faster but more verbose)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        protected T Get<T>([CallerMemberName] string name = null)
        {
            Debug.Assert(name != null, "name != null");
            if (_properties.TryGetValue(name, out object value))
                return value == null ? default(T) : (T)value;
            return default(T);
        }

        /// <summary>
        /// Gets the value of a property (slower but less verbose, however if we call this with an enum that is not set it returns null which is does not work for enums..)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        //protected dynamic Get([CallerMemberName] string name = null)
        //{
        //    CountGets++;
        //    Debug.Assert(name != null, "name != null");
        //    _properties.TryGetValue(name, out object value);
        //    return value;
        //}

        /// <summary>
        /// Sets the value of a property
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <remarks>Use this overload when implicitly naming the property</remarks>
        protected void Set<T>(T value, [CallerMemberName] string name = null)
        {
            Debug.Assert(name != null, "name != null");
            if (Equals(value, Get<T>(name))) return;

            _properties[name] = value;
            OnPropertyChanged(name);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
