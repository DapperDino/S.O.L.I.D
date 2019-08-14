using UnityEngine;

namespace SOLID.SingleResponsibility
{
    public class AreaDamage : MonoBehaviour
    {
        [SerializeField] private float explosionRadius = 5f;
        [SerializeField] private int damageToDeal = 10;

        public void Trigger()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

            foreach (var collider in colliders)
            {
                if (collider.GetComponent<Enemy>() != null)
                {
                    collider.GetComponent<Enemy>().DealDamage(damageToDeal);
                }
            }
        }
    }
}
