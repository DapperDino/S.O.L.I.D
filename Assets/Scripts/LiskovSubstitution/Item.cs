using UnityEngine;

namespace SOLID.LiskovSubstitution
{
    public abstract class Item : MonoBehaviour
    {
        [SerializeField] private new string name = "New Item Name";
        [SerializeField] private string description = "New Item Description";

        public string Name => name;
        public string Description => description;

        public abstract void DisplayText();
    }
}
