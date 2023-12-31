using GFA.TPS.MatchSystem;
using GFA.TPS.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace GFA.TPS.AI.Behaviour
{
    [CreateAssetMenu(menuName = "AI/Basic AI Behaviour")]
    public class BasicAIBehaviour : AIBehaviour
    {
        [SerializeField]
        private float _acceptanceRadius;

        [SerializeField]
        private MatchInstance _matchInstance;

        public override void Begin(AIController controller)
        {
        }

        protected override void Execute(AIController controller)
        {
            var player = _matchInstance.Player;

            var movement = controller.GetComponent<CharacterMovement>();

            var dist = Vector3.Distance(player.transform.position, controller.transform.position);
            if (dist < _acceptanceRadius)
            {
                movement.MovementInput = Vector3.zero;

            }
            else
            {


            }
            var dir = (player.transform.position - controller.transform.position).normalized;

            movement.MovementInput = new Vector2(dir.x, dir.z);
        }

        public override void End(AIController controller)
        {
        }
    }
}

