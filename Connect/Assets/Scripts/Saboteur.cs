using UnityEngine;
using System.Collections;

public class Saboteur : MonoBehaviour 
{
    void OnMouseDrag() 
    {
        Vector3[] FlyDear = {
            Vector3.up,
            Vector3.down,
            Vector3.forward,
        };
        float Speed = Random.Range(1, 10);
        rigidbody.AddForce( FlyDear[Random.Range(0, FlyDear.Length)] * Speed ,ForceMode.VelocityChange);
    }
}
