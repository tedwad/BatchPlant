using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchPlant;
using System.Runtime.Serialization;


namespace BatchPlant
{
    [DataContract(Namespace = Namespaces.BatchPlant)]
    public class BatchPlantServerConfiguration
    {
        public BatchPlantServerConfiguration()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the object during deserialization.
        /// </summary>
        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
    }
}
