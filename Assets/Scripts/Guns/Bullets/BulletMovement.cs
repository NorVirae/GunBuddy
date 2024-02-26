using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField]
    float forceMagnitude = 10f;

    private float startTime;

    [SerializeField]
    private ParticleSystem GunTrails;

    [SerializeField]
    private ParticleSystem DeadParticle;

    private ParticleSystem trail;
    private ParticleSystem DeadPart;


    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Vector3 forceDirection = transform.forward;
        rigidBody.AddForce(forceDirection * forceMagnitude);
        if (GunTrails != null)
        {
            trail = Instantiate(GunTrails, transform.position, Quaternion.identity);
        }
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        trail.transform.position = transform.position;
        trail.transform.rotation = transform.rotation;

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }

        //Destroy(collision.gameObject);
        Destroy(gameObject);

        Destroy(trail.gameObject);
        Destroy(DeadPart.gameObject);
    }
}
