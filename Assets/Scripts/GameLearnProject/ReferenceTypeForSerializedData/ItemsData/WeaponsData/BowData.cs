using UnityEngine;

namespace GameLearnProject.ReferenceTypeForSerializedData.ItemsData.WeaponsData
{
    [CreateAssetMenu(fileName = "BowData", menuName = "SerializedData/BowData")]
    public class BowData : ItemSerializedData
    {
        public string NameWeapon = "Bow";
    }
}