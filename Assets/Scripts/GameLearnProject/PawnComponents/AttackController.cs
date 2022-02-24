using GameLearnProject.LoaderScripts.Interfaces;
using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PawnComponents
{
    public class AttackController : MonoBehaviour, IAttack
    {
        private ILoader _loader;

        [Inject]
        private void Constructor(/*ILoader loader, Inventory inventory*/)
        {
            //_loader = loader;
        }
        
        public void Attack()
        {
            
        }
    }
}
