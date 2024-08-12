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
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Boolean:
                    defaultValue = (T)(object)false;
                    break;
                case TypeCode.Byte:
                    defaultValue = (T)(object)(byte)0;
                    break;
                case TypeCode.Int32:
                    defaultValue = (T)(object)0;
                    break;
                case TypeCode.String:
                    defaultValue = (T)(object)String.Empty;
                    break;
                case TypeCode.Char:
                    defaultValue = (T)(object)(char)0;
                    break;
                case TypeCode.DateTime:
                    defaultValue = (T)(object)DateTime.MinValue;
                    break;
                //case TypeCode.DBNull:
                //    break;
                case TypeCode.Decimal:
                    defaultValue = (T)(object)(decimal)0;
                    break;
                case TypeCode.Double:
                    defaultValue = (T)(object)0d;
                    break;
                case TypeCode.Empty:
                    defaultValue = (T)(object)null;
                    break;
                case TypeCode.Int16:
                    defaultValue = (T)(object)(Int16)0;
                    break;
                case TypeCode.Int64:
                    defaultValue = (T)(object)(Int64)0;
                    break;
                case TypeCode.Object:
                    defaultValue = (T)(object)null;
                    break;
                case TypeCode.SByte:
                    defaultValue = (T)(object)(byte)0;
                    break;
                case TypeCode.Single:
                    defaultValue = (T)(object)0f;
                    break;
                case TypeCode.UInt16:
                    defaultValue = (T)(object)(UInt16)0;
                    break;
                case TypeCode.UInt32:
                    defaultValue = (T)(object)(UInt32)0;
                    break;
                case TypeCode.UInt64:
                    defaultValue = (T)(object)(UInt64)0;
                    break;
                default:
                    defaultValue = (T)(object)null;
                    break;
            }
            return defaultValue;
        }
    }
}