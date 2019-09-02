using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public class Player : ICharacter, IDamageable, IManaUser, IMoveable
    {
        public string Name => throw new System.NotImplementedException();

        public int Health => throw new System.NotImplementedException();

        public int MaxHealth => throw new System.NotImplementedException();

        public int Mana => throw new System.NotImplementedException();

        public int MaxMana => throw new System.NotImplementedException();

        public int Speed => throw new System.NotImplementedException();

        public Vector3 Position => throw new System.NotImplementedException();

        public void DealDamage(int damageToDeal)
        {
            throw new System.NotImplementedException();
        }

        public void Move(Vector3 direction)
        {
            throw new System.NotImplementedException();
        }

        public void SpendMana(int manaToSpend)
        {
            throw new System.NotImplementedException();
        }
    }
}
