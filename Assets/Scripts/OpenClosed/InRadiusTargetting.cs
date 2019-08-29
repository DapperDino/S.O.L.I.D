using System.Collections.Generic;
using UnityEngine;

namespace SOLID.OpenClosed
{
    public class InRadiusTargetting : MonoBehaviour, ITargetGetter
    {
        [SerializeField] private float radius = 5f;

        public List<Transform> GetTargets(Transform transform)
        {
            var targets = new List<Transform>();

            Collider[] collidersInRadius = Physics.OverlapSphere(transform.position, radius);

            foreach (var collider in collidersInRadius)
            {
                targets.Add(collider.transform);
            }

            return targets;
        }
    }
}
