using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.ViewModel.Helpers
{
    public static class EnumValuesToList
    {
        public static IEnumerable<KeyValuePair> GetEnum<T>()
        {
            var type = typeof(T);
            var names = Enum.GetNames(type);
            var values = Enum.GetValues(type);
            var pairs =
                Enumerable.Range(0, names.Length)
                    .Select(i => new KeyValuePair
                    {
                        Name = names.GetValue(i).ToString(),
                        Value = values.GetValue(i).ToString()
                    })
                    .OrderBy(pair => pair.Name);
            return pairs;
        }
    }
    public class KeyValuePair
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
