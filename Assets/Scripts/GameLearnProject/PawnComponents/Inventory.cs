using System;
using System.Collections.Generic;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.LoaderScripts.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PawnComponents
{
    public class Inventory : MonoBehaviour
    {
        private ILoader _loader;

        private Dictionary<Guid, IItem> _items;
        
        [Inject]
        private void Constructor(ILoader loader)
        {
            /*_loader = loader;

            var items = _loader.GetItems();
            _items = new Dictionary<Guid, IItem>();
            foreach (var item in items)
            {
                _items.Add(item.GetGuid(), item);
            }*/
        }

        public IItem GetItem(Guid itemGuid)
        {
            return _items.TryGetValue(itemGuid, out var item) ? item : null;
        }
    }
}
