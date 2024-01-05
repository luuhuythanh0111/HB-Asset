using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Bullet spawnBullet = Pooling.instance.Spawn(transform.position, Quaternion.identity);
            spawnBullet.OnInit();
        }
    }
}
