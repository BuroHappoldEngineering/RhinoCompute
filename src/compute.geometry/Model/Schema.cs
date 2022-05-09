using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.RemoteCompute;
using Newtonsoft.Json;

namespace Resthopper.IO
{
    public class RestHopperInput
    {
        public RestHopperInput() { }

        [JsonProperty(PropertyName = "absolutetolerance")]
        public double AbsoluteTolerance { get; set; } = 0;

        [JsonProperty(PropertyName = "angletolerance")]
        public double AngleTolerance { get; set; } = 0;

        [JsonProperty(PropertyName = "modelunits")]
        public string ModelUnits { get; set; } = Rhino.UnitSystem.Millimeters.ToString();

        /// <summary>
        ///  Can be used to store a Base-64 encoded GH script. Heaby; prefer Pointer instead.
        /// </summary>
        [JsonProperty(PropertyName = "algo")]
        public string Script { get; set; }

        // If true on input, the solve results are cached based on this schema.
        // When true the cache is searched for already computed results and used
        [JsonProperty(PropertyName = "cachesolve")]
        public bool CacheSolve { get; set; } = false;

        // Used for nested calls
        [JsonProperty(PropertyName = "recursionlevel")]
        public int RecursionLevel { get; set; } = 0;

        [JsonProperty(PropertyName = "values")]
        public List<GrasshopperDataTree<ResthopperObject>> Data { get; set; } = new List<GrasshopperDataTree<ResthopperObject>>();

        // Return warnings from GH
        [JsonProperty(PropertyName = "warnings")]
        public List<string> Warnings { get; set; } = new List<string>();

        // Return errors from GH
        [JsonProperty(PropertyName = "errors")]
        public List<string> Errors { get; set; } = new List<string>();
    }
}
