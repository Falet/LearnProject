using System.Collections.Generic;
using GameLearnProject.ItemsComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject
{
    public class Inventory : MonoBehaviour
    {
        private List<IItem> _items;
        
        [Inject]
        private void Constructor(List<IItem> items)
        {
            _items = items;
        }
    }
}
