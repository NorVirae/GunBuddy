using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolGun : MonoBehaviour
{
    [SerializeField]
    private GameObject projectileSpawnPoint;

    [SerializeField]
    private BulletMovement Bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }


    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, projectileSpawnPoint.transform, false);
            Debug.Log("LEft button mouse click");
        }
    }
}
