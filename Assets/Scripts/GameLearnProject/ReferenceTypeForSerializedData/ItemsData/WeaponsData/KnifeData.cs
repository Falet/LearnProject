using UnityEngine;

namespace GameLearnProject.ReferenceTypeForSerializedData.ItemsData.WeaponsData
{
    [CreateAssetMenu(fileName = "KnifeData", menuName = "SerializedData/KnifeData")]
    public class KnifeData : ItemSerializedData
    {
        public string NameWeapon = "Knife";
    }
}