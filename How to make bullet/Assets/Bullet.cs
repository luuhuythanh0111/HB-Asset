using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward;
    }

    public void OnInit()
    {
        Invoke(nameof(OnDespawn), 1f);
    }

    public void OnDespawn()
    {
        this.gameObject.SetActive(false);
    }

}
