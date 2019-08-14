using UnityEngine;
using UnityEngine.Events;

namespace SOLID.SingleResponsibility
{
    public class TriggerOverlap : MonoBehaviour
    {
        [SerializeField] private UnityEvent onTrigger = new UnityEvent();
        [SerializeField] private LayerMask layerMask = new LayerMask();

        private void OnTriggerEnter(Collider other)
        {
            if (((1 << other.gameObject.layer) & layerMask) != 0)
            {
                onTrigger?.Invoke();
            }
        }
    }
}
