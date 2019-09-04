using UnityEngine;

namespace SOLID.DependencyInversion
{
    public class MoverGood : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;

        private IMovementInputGetter movementInputGetter = null;

        private void Awake() => movementInputGetter = GetComponent<IMovementInputGetter>();

        private void Update()
        {
            Vector3 movement = new Vector3
            {
                x = movementInputGetter.Horizontal,
                y = 0f,
                z = movementInputGetter.Vertical,
            }.normalized;

            movement *= speed * Time.deltaTime;

            transform.Translate(movement);
        }
    }
}

