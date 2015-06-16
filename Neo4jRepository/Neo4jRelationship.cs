using Newtonsoft.Json;

namespace Neo4jRepository
{
    public class Neo4jRelationship
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonIgnore]
        public string Name { get; set; }

        public Neo4jRelationship()
        {
        }
    }
}
