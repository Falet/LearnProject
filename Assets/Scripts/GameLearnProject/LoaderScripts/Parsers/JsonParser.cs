using GameLearnProject.LoaderScripts.Interfaces;
using Newtonsoft.Json;
using UnityEngine;

namespace GameLearnProject.LoaderScripts.Parsers
{
    public class JsonParser : IParser
    {
        private readonly ISaverSerializeData _saverSerializeData;

        public JsonParser(ISaverSerializeData saverSerializeData)
        {
            _saverSerializeData = saverSerializeData;
        }

        public string Serialize(object objectForSerialize)
        {
            var jsonData = JsonConvert.SerializeObject(objectForSerialize);
            Debug.Log(jsonData);

            return jsonData;
        }

        public void Deserialize<T>(string jsonData)
        {
            var deserializeData = JsonConvert.DeserializeObject<T>(jsonData);
            Debug.Log(deserializeData);
        }
    }
}