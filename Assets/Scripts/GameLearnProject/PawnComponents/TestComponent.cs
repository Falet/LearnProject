using GameLearnProject.ItemsComponents.Weapons;
using GameLearnProject.LoaderScripts.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PawnComponents
{
    public class TestComponent : MonoBehaviour
    {
        [Inject]
        private void Constructor(Knife asd, ILoader loader)
        {
            Debug.Log(1);
        }
    }
}