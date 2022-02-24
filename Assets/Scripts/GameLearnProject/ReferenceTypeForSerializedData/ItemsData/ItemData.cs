using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameLearnProject.ReferenceTypeForSerializedData.ItemsData
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "SerializedData/ItemData")]
    public class ItemData : ScriptableObject
    {
        public AssetReference PrefabItem;

        public ItemSerializedData ItemSerializedData;
    }
}
