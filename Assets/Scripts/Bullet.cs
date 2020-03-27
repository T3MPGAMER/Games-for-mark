using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletClass;
    Vector3 spawnPosition;
    Quaternion spawnRotation;
    public int bulletCount = 8;
    const float rateOfFire = 2f;
    const float speed = 2000f;
    float fireDelay;
    public int A=1;

    void FixedUpdate()
    {
        if (A ==1&& Time.time > fireDelay && bulletCount > 0)
        {
            spawnPosition = transform.position;
            spawnRotation = transform.rotation; fireDelay = Time.time + rateOfFire;
            GameObject bulletInstance = Instantiate(bulletClass, spawnPosition, spawnRotation);
            bulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
            bulletCount--;
        }
    }

}


