using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AllienProblem
{
    public class IndirectSolution : BaseProblem
    {
        protected override void Start()
        {
            for (int i = 0; i < NumberAlliens; i++)
            {
                Allien allien = new Allien();

                //Without Flyweight - Indirect Assignment
                //Through a Function, we set a Vector 3 of new Parts done by another Function
                allien.SetEyePosition(GetBodyPartPositions());
                allien.SetLegPosition(GetBodyPartPositions());
                allien.SetArmPosition(GetBodyPartPositions());

                allAlliens.Add(allien);
            }
        }
    }
}
