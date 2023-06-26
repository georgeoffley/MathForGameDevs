using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class RadialTrigger : MonoBehaviour
{
    public Transform objTf;

    [Range(0f, 4f)]
    public float radius = 1f;

    #if UNITY_EDITOR // Used for conditionally compiling code
    private void OnDrawGizmos() // Drawing gizmos helps us test this stuff visually
    {
        Vector2 objPos = objTf.position;
        Vector2 origin = transform.position;

        // Conventional implementation for getting distance
        // float dist = Vector2.Distance(objPos, origin);
        // bool isInside = dist < radius;

        // Alternative approach to take out Distance checks and calculating manually

        // Going from origin of trigger to the object we're checking the distance to
        Vector2 disp = objPos - origin;
        // This is a cheaper way to square values. Built in: Mathf.Pow(disp.x, 2)
        float distSq = disp.x * disp.x + disp.y * disp.y;

        // This would also give us the squared distance
        // float distq = disp.sqrMagnitude;

        // We need to square the radius since we're not getting the square root
        // of the distSq. We're only squaring it giving us the square of the distance
        bool isInside = distSq < radius * radius;


        Handles.color = isInside ? Color.green : Color.red;
        Handles.DrawWireDisc(origin, new Vector3(0, 0, 1), radius);
    }
    #endif
}
