using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SOLID.OpenClosed
{
    public class AllTargetting : MonoBehaviour, ITargetGetter
    {
        public List<Transform> GetTargets(Transform transform)
        {
            return FindObjectsOfType<Transform>().ToList();
        }
    }
}
