using System.Collections.Generic;
using GameLearnProject.ItemsComponents.Interfaces;

namespace GameLearnProject.LoaderScripts.Interfaces
{
    public interface ILoader
    {
        List<IItem> GetItems();
    }
}