using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorOptionPattern
{
    public class MySettings
    {
        public string StringSetting { get; set; }
        public int IntSetting { get; set; }
        public List<string> ListSetting { get; set; }
        public Dictionary<string, string> DictionarySetting { get; set; }
        public FruitEnum EnumSetting { get; set; }

        // セッターが未定義 or privateの場合はバインドできずnullになる
        public string NonSetter { get; }
        public string NonPublicSetter { get; private set; }
    }

    public enum FruitEnum
    {
        Apple,
        Orange,
        Meron,
        Peach
    }
}
