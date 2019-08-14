using System.Collections;
using UnityEngine;

namespace SOLID.SingleResponsibility
{
    public class Bomb : MonoBehaviour
    {
        [SerializeField] private float secondsUntilDetonation = 3f;
        [SerializeField] private float explosionRadius = 5f;
        [SerializeField] private int damageToDealToEachUnit = 10;
        [SerializeField] private LayerMask explodeOnContactLayermask = new LayerMask();

        private void Start() => StartCoroutine(Timer());

        private void OnTriggerEnter(Collider other)
        {
            if (((1 << other.gameObject.layer) & explodeOnContactLayermask) != 0)
            {
                Detonate();
            }
        }

        private void Detonate()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

            foreach (var collider in colliders)
            {
                if (collider.GetComponent<Enemy>() != null)
                {
                    collider.GetComponent<Enemy>().DealDamage(damageToDealToEachUnit);
                }
            }

            Destroy(gameObject);
        }

        private IEnumerator Timer()
        {
            yield return new WaitForSeconds(secondsUntilDetonation);

            Detonate();
        }
    }
}
