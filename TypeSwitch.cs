using System;
using System.Collections.Generic;

namespace dk.theng.Helpers
{
    public class TypeSwitch
    {
        Dictionary<Type, Func<object, object>> matches = new Dictionary<Type, Func<object, object>>();
        public TypeSwitch Case<T>(Func<T, T> func) { matches.Add(typeof(T), (x) => func((T)x)); return this; }
        public TypeSwitch Default<T>(Func<T, T> func) { matches.Add(typeof(object), (x) => func((T)x)); return this; }
        public object Switch(object x) { return matches[x.GetType()](x); }
    }
}
