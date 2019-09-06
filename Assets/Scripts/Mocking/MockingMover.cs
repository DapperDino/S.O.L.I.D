using UnityEngine;
using SOLID.DependencyInversion;

namespace SOLID.Mocking
{
    public class MockingMover
    {
        private readonly float speed = 0f;
        private readonly Transform transformToMove = null;
        private readonly IMovementInputGetter inputGetter = null;

        public MockingMover(float speed, Transform transformToMove, IMovementInputGetter inputGetter)
        {
            this.speed = speed;
            this.transformToMove = transformToMove;
            this.inputGetter = inputGetter;
        }

        public void Move()
        {
            Vector3 movement = new Vector3
            {
                x = inputGetter.Horizontal,
                y = 0f,
                z = inputGetter.Vertical,
            }.normalized;

            movement *= speed * Time.deltaTime;

            transformToMove.Translate(movement);
        }
    }
}
