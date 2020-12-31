using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MoveTest
    {
        [UnityTest]
        public IEnumerator MoveRight()
        {
            var gameObject = new GameObject();
            var square = gameObject.AddComponent<ControlMove>();
            double oldlocation = square.vec.x;
            Debug.Log(oldlocation);

            yield return new WaitForSeconds(5);

            double moveRightLocation = square.MoveRight();
            Debug.Log(moveRightLocation);

            Assert.IsTrue(oldlocation < moveRightLocation );
        }






        [UnityTest]
        public IEnumerator MoveLeft()
        {
            var gameObject = new GameObject();
            var square = gameObject.AddComponent<ControlMove>();
            double oldlocation = square.vec.x;

            yield return new WaitForSeconds(5);

            double moveLeftLocation = square.MoveLeft();

            Assert.IsTrue(oldlocation > moveLeftLocation);
        }
        [UnityTest]
        public IEnumerator MoveUp()
        {
            var gameObject = new GameObject();
            var square = gameObject.AddComponent<ControlMove>();
            float oldlocation = square.vec.y;

            yield return new WaitForSeconds(5);

            float moveUpLocation = square.MoveUp();

            Assert.IsTrue(oldlocation < moveUpLocation);
        }
        [UnityTest]
        public IEnumerator MoveDown()
        {
            var gameObject = new GameObject();
            var square = gameObject.AddComponent<ControlMove>();
            double oldlocation = square.vec.y;

            yield return new WaitForSeconds(5);

           double moveDownLocation = square.MoveDown();

            Assert.IsTrue(oldlocation > moveDownLocation);
        }
    }
}
