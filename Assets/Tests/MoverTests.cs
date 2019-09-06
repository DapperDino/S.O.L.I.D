using Moq;
using NUnit.Framework;
using SOLID.DependencyInversion;
using SOLID.Mocking;
using UnityEngine;

namespace Tests
{
    public class MoverTests
    {
        [Test]
        [TestCase(1f)]
        [TestCase(61.7f)]
        [TestCase(-2312)]
        public void MovingTransformHorizontal_MovesCorrectly(float speed)
        {
            var transform = new GameObject().transform;
            var inputGetterMock = new Mock<IMovementInputGetter>();
            inputGetterMock.Setup(x => x.Horizontal).Returns(1f);

            var mover = new MockingMover(speed, transform, inputGetterMock.Object);
            mover.Move();

            Assert.AreEqual(transform.position, new Vector3(Time.deltaTime * speed, 0f, 0f));
        }

        [Test]
        [TestCase(1f)]
        [TestCase(61.7f)]
        [TestCase(-2312)]
        public void MovingTransformVertical_MovesCorrectly(float speed)
        {
            var transform = new GameObject().transform;
            var inputGetterMock = new Mock<IMovementInputGetter>();
            inputGetterMock.Setup(x => x.Vertical).Returns(1f);

            var mover = new MockingMover(speed, transform, inputGetterMock.Object);
            mover.Move();

            Assert.AreEqual(transform.position, new Vector3(0f, 0f, Time.deltaTime * speed));
        }

        [Test]
        public void MovingTransformBothAxis_MovesCorrectly()
        {
            var transform = new GameObject().transform;
            var inputGetterMock = new Mock<IMovementInputGetter>();
            inputGetterMock.Setup(x => x.Horizontal).Returns(1f);
            inputGetterMock.Setup(x => x.Vertical).Returns(-1f);

            var mover = new MockingMover(1f, transform, inputGetterMock.Object);
            mover.Move();

            Assert.AreEqual(transform.position, new Vector3(1, 0f, -1).normalized * Time.deltaTime);
        }
    }
}
