using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AllienProblem
{
    public class DirectSolution : BaseProblem
    {
        protected override void Start()
        {
            for (int i = 0; i < NumberAlliens; i++)
            {
                Allien allien = new Allien();

                //Without Flyweight - Direct Assignment
                //We assign a Vector 3 of already created Parts to each one
                allien.eyePositions = GetBodyPartPositions();
                allien.legPositions = GetBodyPartPositions();
                allien.armPositions = GetBodyPartPositions();

                allAlliens.Add(allien);
            }
        }
    }
}