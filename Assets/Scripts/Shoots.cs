using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoots : MonoBehaviour
{
    public float speed = 40;
    public GameObject Bullet;
    public Transform barrel;
    
    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(Bullet, barrel.position, barrel.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
        Destroy(spawnedBullet, 2);
    }
}
