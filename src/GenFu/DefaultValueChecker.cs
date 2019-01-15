﻿using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace GenFu
{
    public class DefaultValueChecker
    {
        internal static bool HasValue(object instance, PropertyInfo property)
        {
            var value = property.GetValue(instance, null);
            if (property.PropertyType.GetTypeInfo().IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                return value != null;
            }
            
            if (value == null)
                return false;
            if (property.PropertyType == typeof(Int32) && (Int32)value == default(Int32))
                return false;
            else if (property.PropertyType == typeof(Int16) && (Int16)value == default(Int16))
                return false;
            else if (property.PropertyType == typeof(double) && (double)value == default(double))
                return false;
            else if (property.PropertyType == typeof(decimal) && (decimal)value == default(decimal))
                return false;
            else if (property.PropertyType == typeof(float) && (float)value == default(float))
                return false;
            else if (property.PropertyType == typeof(Guid) && (Guid)value == default(Guid))
                return false;
            else if (property.PropertyType == typeof(long) && (long)value == default(long))
                return false;
            else if (property.PropertyType == typeof(ulong) && (ulong)value == default(ulong))
                return false;
            else if (property.PropertyType == typeof(uint) && (uint)value == default(uint))
                return false;
            else if (property.PropertyType == typeof(ushort) && (ushort)value == default(ushort))
                return false;
            else if (property.PropertyType == typeof(bool) && (bool)value == default(bool))
                return false;
            else if (property.PropertyType == typeof(string) && (string)value == default(string))
                return false;
            else if (property.PropertyType == typeof(DateTime) && ((DateTime)value).Equals(default(DateTime)))
                return false;
            else if (property.PropertyType == typeof(DateTimeOffset) && ((DateTimeOffset)value).Equals(default(DateTimeOffset)))
                return false;
            else if (property.PropertyType.GetTypeInfo().BaseType == typeof(System.Enum) && IsDefaultEnum(property.PropertyType, value))
                return false;
            else if (property.PropertyType.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IEnumerable)) && !(value as IEnumerable).GetEnumerator().MoveNext())
                return false;
            return true;
        }


        private static bool IsDefaultEnum(Type type, object value)
        {
            var t = Enum.GetUnderlyingType(type);
            if (t == typeof(byte)) return ((byte)value) == 0;
            if (t == typeof(int)) return ((int)value) == 0;
            if (t == typeof(long)) return ((long)value) == 0;
            if (t == typeof(sbyte)) return ((sbyte)value) == 0;
            if (t == typeof(short)) return ((short)value) == 0;
            if (t == typeof(uint)) return ((uint)value) == 0;
            if (t == typeof(ulong)) return ((ulong)value) == 0;
            if (t == typeof(ushort)) return ((ushort)value) == 0;
            return false;

        }
    }
}
