using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGun : MonoBehaviour
{
    [SerializeField]
    private GameObject projectileSpawnPoint;

    [SerializeField]
    private BulletMovement Bullet;

    [SerializeField]
    private ParticleSystem MuzzlePuff;

    private CinemachineImpulseSource impulseScript;


    // Start is called before the first frame update
    void Start()
    {
        impulseScript = GetComponent<CinemachineImpulseSource>();
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
            Instantiate(MuzzlePuff, projectileSpawnPoint.transform, false);
            if (impulseScript != null)
            {
                CameraShakeManager.Instance.shakeCamera(impulseScript);
            }
            
            Debug.Log("LEft button mouse click");
        }
    }
}
