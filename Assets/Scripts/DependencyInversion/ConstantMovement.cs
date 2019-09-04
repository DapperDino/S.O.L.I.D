using UnityEngine;

namespace SOLID.DependencyInversion
{
    public class ConstantMovement : MonoBehaviour, IMovementInputGetter
    {
        public float Horizontal => 1f;
        public float Vertical => 5f;
    }
}