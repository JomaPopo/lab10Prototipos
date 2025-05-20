using System.Collections.Generic;
using UnityEngine;


public abstract class SimpleFlyweight : BaseProblem
{
    protected List<Vector3> eyePositions;
    protected List<Vector3> legPositions;
    protected List<Vector3> armPositions;

    protected override void Start()
    {
        eyePositions = GetBodyPartPositions();
        legPositions = GetBodyPartPositions();
        armPositions = GetBodyPartPositions();

        //Debug.Log("Call from: SimpleFlyweight");
    }
}
