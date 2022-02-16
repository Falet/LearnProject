using GameLearnProject.ReferenceTypeForSerializedData;
using UnityEngine;

namespace GameLearnProject.ItemsComponents.Weapons.WeaponsData
{
    [CreateAssetMenu(fileName = "BowData", menuName = "SerializedData/BowData")]
    public class BowData : ItemSerializedData
    {
        public string NameWeapon = "Bow";
    }
}