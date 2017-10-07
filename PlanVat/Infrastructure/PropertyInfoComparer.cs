using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace PlanVat.Infrastructure
{
    public class PropertyInfoComparer : IEqualityComparer<PropertyInfo>
    {
        private Func<PropertyInfo, PropertyInfo, bool> strategy;

        private PropertyInfoComparer(Func<PropertyInfo, PropertyInfo, bool> strategy)
        {
            this.strategy = strategy;
        }

        public bool Equals(PropertyInfo x, PropertyInfo y)
        {
            return strategy(x, y);
        }

        public int GetHashCode(PropertyInfo obj)
        {
            throw new NotImplementedException();
        }

        private static PropertyInfoComparer ordinalName = new PropertyInfoComparer((x, y) =>
        {
            if (x == null ^ y == null)
            {
                return false;
            }

            return x.Name == y.Name;
        });

        public static PropertyInfoComparer OrdinalName
        {
            get
            {
                return ordinalName;
            }

        }
    }
}