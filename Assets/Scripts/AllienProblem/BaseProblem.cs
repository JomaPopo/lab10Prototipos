using UnityEngine;
using System.Collections.Generic;
public abstract class BaseProblem : MonoBehaviour
{
    [Header("Allien Problem")]
    [SerializeField] protected int NumberAlliens = 50;
    [SerializeField] protected int NumberBodyParts = 50;

    protected List<Allien> allAlliens = new List<Allien>();

    protected abstract void Start();

    protected List<Vector3> GetBodyPartPositions()
    {
        List<Vector3> bodyPartPositions = new List<Vector3>();

        for (int i = 0; i < NumberBodyParts; i++)
        {
            bodyPartPositions.Add(new Vector3());
        }

        return bodyPartPositions;
    }
}

public class Allien
{
    public List<Vector3> eyePositions;
    public List<Vector3> legPositions;
    public List<Vector3> armPositions;

    public Allien()
    {

    }

    public void SetEyePosition(List<Vector3> positions)
    {
        eyePositions = positions;
    }

    public void SetLegPosition(List<Vector3> positions)
    {
        legPositions = positions;
    }

    public void SetArmPosition(List<Vector3> positions)
    {
        armPositions = positions;
    }
}