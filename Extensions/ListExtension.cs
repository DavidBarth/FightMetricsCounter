using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MMAApp.Extensions
{
    public static class ListExtension
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> collection)
        {
            var c = new ObservableCollection<T>();
            foreach(var e in collection)
            {
                c.Add(e);
            }
            return c;
        }
    }
}
