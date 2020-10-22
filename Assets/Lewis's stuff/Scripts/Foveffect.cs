using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foveffect : MonoBehaviour
{
    public float viewRadius;
    public float ViewAngle;

    public Vector3 DirFromAngle(float angleinDegrees)
    {
        return new Vector3(Mathf.Sin(angleinDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleinDegrees * Mathf.Deg2Rad);
    }
}
