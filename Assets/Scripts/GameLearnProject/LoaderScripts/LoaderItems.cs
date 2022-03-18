using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.LoaderScripts.Interfaces;
using GameLearnProject.ReferenceTypeForSerializedData.ItemsData;
using UnityEngine;
using Zenject;

namespace GameLearnProject.LoaderScripts
{
    public class LoaderItems : MonoBehaviour, ILoader
    {
        [SerializeField] private List<ItemData> _dataItems;
        
        private IFactory<ItemData, UniTask<IItem>> _factoryItem;
        private List<IItem> _items;
        private UniTask _creatingItems;

        [Inject]
        private void Constructor(IFactory<ItemData, UniTask<IItem>> factoryItem)
        {
            _factoryItem = factoryItem;

            _items = new List<IItem>();
            CreateItems();
        }

        private async UniTaskVoid CreateItems()
        {
            if (_dataItems == null)
            {
                return;
            }

            foreach (var itemData in _dataItems)
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

        public class FactoryItems<TTypeResultItem, TData> : IFactory<TData, UniTask<TTypeResultItem>> 
            where TData : ItemData
        {
            private readonly DiContainer _container;

            public FactoryItems(DiContainer container)
            {
                _container = container;
            }

            public async UniTask<TTypeResultItem> Create(TData assetReference)
            {
                var gameObjectItem = await assetReference.PrefabItem.InstantiateAsync();
                
                var gameObjectContext = gameObjectItem.GetComponent<GameObjectContext>();
                
                gameObjectContext.Install(_container, new object[]
                {
                    assetReference.ItemSerializedData
                });

                return gameObjectItem.GetComponent<TTypeResultItem>();
            }
        }

        #endregion
    }
}