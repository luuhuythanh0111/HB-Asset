using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGatlingGun : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {  
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * speed);
        }
    }
}
