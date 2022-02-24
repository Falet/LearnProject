using GameLearnProject.ReferenceTypeForSerializedData.ItemsData;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameLearnProject.ReferenceTypeForSerializedData
{
    [CreateAssetMenu(fileName = "ContainerOfItems", menuName = "SerializedData/ContainerOfItems")]
    public class ContainerData : ScriptableObject
    {
        public AssetReference _prefabContainer;

        public ItemData[] Items;
    }
}