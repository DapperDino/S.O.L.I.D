using System.Collections.Generic;
using UnityEngine;

namespace SOLID.OpenClosed
{
    public class SelfTargetting : MonoBehaviour, ITargetGetter
    {
        public List<Transform> GetTargets(Transform transform)
        {
            return new List<Transform>() { transform };
        }
    }
}
