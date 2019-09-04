using UnityEngine;

namespace SOLID.DependencyInversion
{
    public class MoverBad : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;

        private void Update()
        {
            Vector3 movement = new Vector3
            {
                x = Input.GetAxisRaw("Horizontal"),
                y = 0f,
                z = Input.GetAxisRaw("Vertical")
            }.normalized;

            movement *= speed * Time.deltaTime;

            transform.Translate(movement);
        }
    }
}

