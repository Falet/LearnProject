using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.LoaderScripts.Interfaces;
using GameLearnProject.ReferenceTypeForSerializedData;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Zenject;

namespace GameLearnProject.LoaderScripts
{
    public class LoaderItems : MonoBehaviour, ILoader
    {
        [SerializeField] private List<ItemData> _prefabsItem;
        
        private IFactory<AssetReference, UniTask<IItem>> _factoryItem;
        private List<IItem> _items;

        [Inject]
        private async UniTaskVoid Constructor(IFactory<AssetReference, UniTask<IItem>> factoryItem)
        {
            _factoryItem = factoryItem;
            
            _items = new List<IItem>();
            if (_prefabsItem == null)
            {
                return;
            }
            
            foreach (var itemData in _prefabsItem)
            {
                var item = await _factoryItem.Create(itemData.PrefabItem);
                
                item.SetData(itemData.ItemSerializedData);

                _items.Add(item);
            }
        }

        public List<IItem> GetItems()
        {
            return _items;
        }

        #region Factory

        public class FactoryItems : IFactory<AssetReference, UniTask<IItem>>
        {
            private readonly DiContainer _container;
        
            public FactoryItems(DiContainer container)
            {
                _container = container;
            }

            public async UniTask<IItem> Create(AssetReference assetReference)
            {
                if (assetReference.Asset == null && assetReference.IsValid() == false)
                {
                    await assetReference.LoadAssetAsync<GameObject>();
                }
                else if(assetReference.IsValid())
                {
                    await assetReference.OperationHandle;
                }

                var gameObjectItem = assetReference.Asset;
                return _container.InstantiatePrefabForComponent<IItem>(gameObjectItem);
            }
        }

        #endregion
    }
}