using UnityEngine;

namespace SOLID.OpenClosed
{
    public class TargettingSystemGood : MonoBehaviour
    {
        private ITargetGetter targetGetter = null;

        private void Start()
        {
            targetGetter = GetComponent<ITargetGetter>();

            if (targetGetter == null) { return; }

            var targets = targetGetter.GetTargets(transform);

            foreach (Transform target in targets)
            {
                Debug.Log(target.name);
            }
        }
    }
}
