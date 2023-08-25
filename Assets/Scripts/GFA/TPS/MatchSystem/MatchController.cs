using UnityEngine;

namespace GFA.TPS.MatchSystem
{
    public class MatchController : MonoBehaviour
    {
        [SerializeField]
        private MatchInstance _matchInstance;

        private void Update()
        {
            _matchInstance.AddTime(Time.deltaTime);
        }
    }
}
