using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TurboUnit.Gui
{
    public class AssemblyFilterPreset : TurboUnitObject
    {
        public const string Extension = "turbofilter";

        // Non-serializable members
        [JsonIgnore]
        public List<FileData> AllAssemblies = new List<FileData>();
        [JsonIgnore]
        public List<FileData> MatchingAssemblies = new List<FileData>();
        
        // Serializable properties
        public List<string> Directories { get; set; }
        public BuildConfigOption BuildConfig { get; set; }
        public List<Regex> PositiveFilters { get; set; }
        public List<Regex> NegativeFilters { get; set; }
        
        // Other properties
        [JsonIgnore]
        public bool DoPositiveFilter
        {
            get
            {
                return PositiveFilters != null && PositiveFilters.Count > 0 && PositiveFilters.Any(r => r != null);
            }
        }
        [JsonIgnore]
        public bool DoNegativeFilter
        {
            get
            {
                return NegativeFilters != null && NegativeFilters.Count > 0 && PositiveFilters.Any(r => r != null);
            }
        }

        // Constructors
        public AssemblyFilterPreset()
        {
            PositiveFilters = new List<Regex>();
            NegativeFilters = new List<Regex>();
            Directories = new List<string>();
        }

        // Public methods
        public void LoadAssemblies()
        {
            LoadAssemblies(false);
        }

        public void LoadAssemblies(bool forceFileRescan)
        {
            if (forceFileRescan || AllAssemblies.Count == 0)
            {
                AllAssemblies = GetAssemblyFilesFromDirectories(Directories);
            }

            MatchingAssemblies = AllAssemblies.Where(a => AssemblyPassesRegexFilters(a)).ToList();
        }

        public static AssemblyFilterPreset Load(string filePath)
        {
            return TurboUnitObject.Load<AssemblyFilterPreset>(filePath);
        }

        #region Helpers

        private List<FileData> GetAssemblyFilesFromDirectories(List<string> directories)
        {
            ConcurrentDictionary<string, FileData> allAssemblies = new ConcurrentDictionary<string, FileData>();
            
            ParallelOptions parallelOptions = new ParallelOptions();
            if (Directories.Count == 1)
            {
                parallelOptions.MaxDegreeOfParallelism = 1;
            }

            Parallel.ForEach(directories, directory =>
            {
                foreach (FileData assembly in FastDirectoryEnumerator.EnumerateFiles(directory, "*.dll", System.IO.SearchOption.AllDirectories))
                {
                    allAssemblies.TryAdd(assembly.Path, assembly);
                }
            });

            return allAssemblies.Values.ToList();
        }
        
        private bool AssemblyPassesRegexFilters(FileData assemblyFile)
        {
            if (assemblyFile == null)
            {
                throw new ArgumentNullException("Cannot filter a null assembly file");
            }

            if (DoPositiveFilter)
            {
                foreach (Regex regex in PositiveFilters)
                {
                    if (!regex.IsMatch(assemblyFile.Path))
                    {
                        return false;
                    }
                }
            }
            if (DoNegativeFilter)
            {
                foreach (Regex regex in NegativeFilters)
                {
                    if (regex.IsMatch(assemblyFile.Path))
                    {
                        return false;
                    }
                }
            }

            // TODO: Work with BuildOption here

            return true;
        }

	    #endregion
    }
}
