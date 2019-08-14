using UnityEngine;

namespace SOLID.SingleResponsibility
{
    public class Enemy : MonoBehaviour
    {
        private int health = 100;

        public void DealDamage(int damageToDeal)
        {
            health = Mathf.Max(0, health - damageToDeal);
            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
