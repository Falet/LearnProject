using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.LoaderScripts.Interfaces;
using GameLearnProject.ReferenceTypeForSerializedData.ItemsData;
using GameLearnProject.ZenjectScripts.GameObjectInstallers;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Zenject;

namespace GameLearnProject.LoaderScripts
{
    public class LoaderItems : MonoBehaviour, ILoader
    {
        [SerializeField] private List<ItemData> _prefabsItem;
        
        private IFactory<ItemData, UniTask<IItem>> _factoryItem;
        private List<IItem> _items;
        private ItemData[] _dateItems;

        [Inject]
        private async void Constructor(IFactory<ItemData, UniTask<IItem>> factoryItem)
        {
            _factoryItem = factoryItem;
            
            _items = new List<IItem>();
            await CreateItems();
        }

        private async UniTask CreateItems()
        {
            if (_prefabsItem == null)
            {
                return;
            }

            foreach (var itemData in _prefabsItem)
            {
                var item = await _factoryItem.Create(itemData);

                _items.Add(item);
            }
        }

        public List<IItem> GetItems()
        {
            return _items;
        }

        #region Factory

        public class FactoryItems : IFactory<ItemData, UniTask<IItem>>
        {
            private readonly DiContainer _container;

            public FactoryItems(DiContainer container)
            {
                _container = container;
            }

            public async UniTask<IItem> Create(ItemData assetReference)
            {
                var gameObjectItem = await assetReference.PrefabItem.InstantiateAsync();
                
                var item = gameObjectItem.GetComponent<IItem>();

                _container.Inject(item, new object[]
                {
                    assetReference.ItemSerializedData
                });

                return item;
            }
        }

        #endregion
    }
}