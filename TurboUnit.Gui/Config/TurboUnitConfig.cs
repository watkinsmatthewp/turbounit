using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboUnit.Gui
{
    public class TurboUnitConfig : TurboUnitObject
    {
        [JsonIgnore]
        public const string Extension = "turboconfig";
        
        public bool IsFirstRun { get; set; }
        public string ConfigFilePath { get; set; }
        public string NunitConsolePath { get; set; }
        public string MsTestConsolePath { get; set; }

        public List<string> RecentAssemblyFilterPaths { get; set; }

        public void Save()
        {
            base.Save(ConfigFilePath);
        }

        public static TurboUnitConfig Load(string filePath)
        {
            return TurboUnitObject.Load<TurboUnitConfig>(filePath);
        }
    }
}
