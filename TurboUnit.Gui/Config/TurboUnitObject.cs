using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboUnit.Gui
{
    public abstract class TurboUnitObject
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static T Load<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file path does not exist: " + filePath);
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath));
            }
        }

        public virtual void Save(string filePath)
        {
            string directoryPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            else
            {
                File.WriteAllText(filePath, JsonConvert.SerializeObject(this, Formatting.Indented));
            }
        }
    }
}
