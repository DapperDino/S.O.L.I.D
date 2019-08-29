using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.OpenClosed
{
    public interface ITargetGetter
    {
        List<Transform> GetTargets(Transform transform);
    }
}
