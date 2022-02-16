using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameLearnProject.ReferenceTypeForSerializedData
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "SerializedData/ItemData")]
    public class ItemData : ScriptableObject
    {
        public AssetReference PrefabItem;

        public ItemSerializedData ItemSerializedData;
    }
}
