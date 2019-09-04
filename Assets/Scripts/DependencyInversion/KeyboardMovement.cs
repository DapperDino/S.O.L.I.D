using UnityEngine;

namespace SOLID.DependencyInversion
{
    public class KeyboardMovement : MonoBehaviour, IMovementInputGetter
    {
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }

        private void Update() => GetInput();

        private void GetInput()
        {
            Horizontal = Input.GetAxisRaw("Horizontal");
            Vertical = Input.GetAxisRaw("Vertical");
        }
    }
}