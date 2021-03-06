using System.Collections.Generic;

namespace NodeGenerator.Models
{
    public class EndpointModel
    {
        public string EndpointUrl { get; init; }
        public bool UseSecurity { get; init; }
        public IReadOnlyCollection<NodeModel> OpcNodes { get; init; }

        public override string ToString()
        {
            return EndpointUrl;
        }
    }
}
