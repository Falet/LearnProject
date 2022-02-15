using System.Collections.Generic;
using GameLearnProject.ItemsComponents;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.LoaderScripts.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.LoaderScripts
{
    public class Loader : MonoBehaviour, ILoader
    {
        [SerializeField] private List<GameObject> _prefabsItem;
        
        private IFactory<Object, IItem> _factoryItem;
        private List<IItem> _items;
        private IParser _parser;

        [Inject]
        private void Constructor(IFactory<Object, IItem> factoryItem, IParser parser)
        {
            _parser = parser;

            _factoryItem = factoryItem;
            if (_prefabsItem == null)
            {
                return;
            }

            _items = new List<IItem>();
            foreach (var gameObjectItem in _prefabsItem)
            {
                var item = _factoryItem.Create(gameObjectItem);

                Debug.Log($"{item.GetGuid()}");

                ItemData data = new ItemData
                {
                    GuidWeapon = item.GetGuid()
                };
                _items.Add(item);
                _parser.Serialize(data);
            }
        }

        public List<IItem> GetItems()
        {
            return _items;
        }

        #region Factory

        public class FactoryItems : IFactory<Object, IItem>
        {
            private readonly DiContainer _container;
        
            public FactoryItems(DiContainer container)
            {
                _container = container;
            }

            public IItem Create(Object prefab)
            {
                return _container.InstantiatePrefabForComponent<IItem>(prefab);
            }
        }

        #endregion
    }
}