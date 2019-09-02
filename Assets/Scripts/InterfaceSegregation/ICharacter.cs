using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public interface ICharacter
    {
        string Name { get; }
    }

    public interface IDamageable
    {
        int Health { get; }
        int MaxHealth { get; }
        void DealDamage(int damageToDeal);
    }

    public interface IManaUser
    {
        int Mana { get; }
        int MaxMana { get; }
        void SpendMana(int manaToSpend);
    }

    public interface IMoveable
    {
        int Speed { get; }
        Vector3 Position { get; }
        void Move(Vector3 direction);
    }
}
