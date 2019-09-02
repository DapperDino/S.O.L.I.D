namespace SOLID.InterfaceSegregation
{
    public class Enemy : ICharacter, IDamageable
    {
        public string Name => throw new System.NotImplementedException();

        public int Health => throw new System.NotImplementedException();

        public int MaxHealth => throw new System.NotImplementedException();

        public void DealDamage(int damageToDeal)
        {
            throw new System.NotImplementedException();
        }
    }
}
