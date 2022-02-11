using GameLearnProject.ItemsComponents.ItemContainer.Interfaces;
using GameLearnProject.PawnComponents;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ItemsComponents.ItemContainer
{
    public class Box : MonoBehaviour, IContainer
    {
        private Inventory _inventory;

        [Inject]
        private void Constructor(Inventory inventory)
        {
            _inventory = inventory;
        }
    }
}