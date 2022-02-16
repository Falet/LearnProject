using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameLearnProject.ReferenceTypeForSerializedData
{
    [CreateAssetMenu(fileName = "ContainerOfItems", menuName = "SerializedData/ContainerOfItems")]
    public class ContainerData : ScriptableObject
    {
        public AssetReference _prefabContainer;

        public List<ItemData> Items;
    }
}