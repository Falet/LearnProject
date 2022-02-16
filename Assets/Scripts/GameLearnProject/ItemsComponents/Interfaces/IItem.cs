using System;
using GameLearnProject.ReferenceTypeForSerializedData;

namespace GameLearnProject.ItemsComponents.Interfaces
{
    public interface IItem
    {
        Guid GetGuid();

        void SetData(ItemSerializedData data);
    }
}