using GameLearnProject.ItemsComponents.Interfaces;
using UnityEngine;

namespace GameLearnProject.ItemsComponents
{
    public class Bow : MonoBehaviour, IRangeWeapon
    {
        public string NameWeapon { get; }
    }
}