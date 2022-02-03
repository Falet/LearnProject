using UnityEngine;
using Zenject;

namespace GameLearnProject.ItemsComponents.ItemContainer
{
    public class Box : MonoBehaviour
    {
        private Inventory _inventory;

        [Inject]
        private void Constructor(Inventory inventory)
        {
            _inventory = inventory;
        }
    }
}