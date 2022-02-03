using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using UnityEngine.AI;
using Zenject;

namespace GameLearnProject.PawnComponents
{
    public class Movement : MonoBehaviour, IMovement
    {
        private NavMeshAgent _navMeshAgent;

        [Inject]
        private void Constructor(NavMeshAgent navMeshAgent)
        {
            _navMeshAgent = navMeshAgent;
        }
        
        public void Move()
        {
            
        }
    }
}
