using UnityEngine;

namespace SOLID.LiskovSubstitution
{
    public class Consumable : Item
    {
        [SerializeField] private string useText = "Drink Me!";

        public string UseText => useText;

        public override void DisplayText()
        {
            Debug.Log($"{Name} : Press E To {UseText}");
        }
    }
}
