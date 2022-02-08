using GameLearnProject.ItemsComponents.Interfaces;
using UnityEngine;

namespace GameLearnProject.ItemsComponents
{
    public class Knife : MonoBehaviour, IMeleeWeapon
    {
        public string _nameWeapon = "Knife";
        public string NameWeapon => _nameWeapon;
    }
}
