using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VectorThing : MonoBehaviour
{
    public Transform aTf;
    public Transform bTf;
    public float abDist;

    void OnDrawGizmos()
    {
        // Calculating Distance between 2 vectors
        Vector2 a = aTf.position;
        Vector2 b = bTf.position;

        Gizmos.DrawLine(a, b);
        abDist = Vector2.Distance(a, b);
        Vector2 pt = transform.position;

        //float length = pt.magnitude;

        // Vector2.Distance(a, b);

        // Vector Normalization
        Vector2 dirToPt = pt / pt.magnitude; // Manual way
        // Vector2 dirToPt = pt.normalized;  // Simple way
        Gizmos.DrawLine(Vector2.zero, dirToPt); //
    }
}
