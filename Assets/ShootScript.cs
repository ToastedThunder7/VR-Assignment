using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform origin;
    public float bulletSpeed = 5;
    public ParticleSystem muzzleFlash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, origin.position, origin.rotation);
        muzzleFlash.Play();
        bullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
    }
}
