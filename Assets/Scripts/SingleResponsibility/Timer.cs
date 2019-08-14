using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace SOLID.SingleResponsibility
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private float duration = 1f;
        [SerializeField] private bool detonateOnDestroy = false;
        [SerializeField] private UnityEvent onTimerEnd = new UnityEvent();

        private void Start() => StartCoroutine(StartTimer());

        private void OnDestroy()
        {
            if (detonateOnDestroy)
            {
                onTimerEnd?.Invoke();
            }
        }

        public void DetonateEarly()
        {
            onTimerEnd?.Invoke();
            StopAllCoroutines();
        }

        private IEnumerator StartTimer()
        {
            yield return new WaitForSeconds(duration);

            onTimerEnd?.Invoke();
        }
    }
}