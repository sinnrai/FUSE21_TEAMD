using UnityEngine;
using System.Collections;

public class Saboteur : MonoBehaviour 
{
    public float MaxSpeed;
    public float MinSpeed;

    private bool IsFlying = false;

    void OnMouseDrag() 
    {
        IsFlying = true;
        float x = Random.Range(-1, 1);
        float y = Mathf.Abs(Random.Range(1 / 2, 1));
        float z = Random.Range(-1, 1);
        Vector3 FlyDear = new Vector3(x, y, z);
        float Speed = Random.Range(MinSpeed, MaxSpeed);
        rigidbody.AddForce(FlyDear * Speed, ForceMode.VelocityChange);
    }

    void Update()
    {
        if (IsFlying)
        {
            transform.rotation = Quaternion.Euler( new Vector3(Time.time, Time.time, Time.time));
        }
    }
}
