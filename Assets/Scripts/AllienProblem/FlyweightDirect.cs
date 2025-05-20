using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AllienProblem
{
    public class FlyweightDirect : SimpleFlyweight
    {
        protected override void Start()
        {
            base.Start();

            for (int i = 0; i < NumberAlliens; i++)
            {
                Allien allien = new Allien();

                //With Flyweight - Direct Assignment
                //We assign a Vector 3 of new Parts to each one
                allien.eyePositions = eyePositions;
                allien.legPositions = legPositions;
                allien.armPositions = armPositions;

                allAlliens.Add(allien);
            }

            //Debug.Log("Call from: FlyweightDirect");
        }
    }
}