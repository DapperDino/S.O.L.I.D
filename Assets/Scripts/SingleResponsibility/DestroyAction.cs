using UnityEngine;

namespace SOLID.SingleResponsibility
{
    public class DestroyAction : MonoBehaviour
    {
        public void Trigger() => Destroy(gameObject);
    }
}
