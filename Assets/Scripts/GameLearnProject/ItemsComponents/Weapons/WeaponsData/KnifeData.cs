using GameLearnProject.ReferenceTypeForSerializedData;
using UnityEngine;

namespace GameLearnProject.ItemsComponents.Weapons.WeaponsData
{
    [CreateAssetMenu(fileName = "KnifeData", menuName = "SerializedData/KnifeData")]
    public class KnifeData : ItemSerializedData
    {
        public string NameWeapon = "Knife";
    }
}