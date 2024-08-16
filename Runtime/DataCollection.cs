using System;
using System.Collections.Generic;

namespace com.trashpandaboy.datastructures
{
    public class DataCollection
    {
        /// <summary>
        /// The data dictionary.
        /// </summary>
        Dictionary<string, object> _data;

        /// <summary>
        /// Add data to the collection.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void AddData(string name, object value)
        {
            if (_data == null)
                _data = new Dictionary<string, object>();
            _data[name] = value;
        }

        /// <summary>
        /// Remove data from the collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="resultValue"></param>
        /// <returns></returns>
        public bool TryGetData<T>(string name, out T resultValue)
        {
            if (_data != null && _data.ContainsKey(name))
            {
                if (_data[name].GetType() == typeof(T))
                {
                    resultValue = (T)_data[name];
                    return true;
                }
            }
            resultValue = GetDefaultValue<T>();
            return false;
        }

        /// <summary>
        /// Get data from the collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public T GetData<T>(string name)
        {
            if (_data != null && _data.ContainsKey(name))
            {
                if (_data[name] is T value)
                {
                    return value;
                }
            }
            return GetDefaultValue<T>();
        }

        /// <summary>
        /// Get the default value for the type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public virtual T GetDefaultValue<T>()
        {            
            T defaultValue;
            
            if (typeof(T).IsValueType)
            {
                defaultValue = default(T);
            }
            else if(typeof(T) == typeof(string))
            {
                defaultValue = (T)(object)string.Empty;
            }
            else
            {
                defaultValue = (T)(object)null;
            }

            return defaultValue;
        }
    }
}