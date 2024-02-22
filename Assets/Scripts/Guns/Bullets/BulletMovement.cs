using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField]
    float forceMagnitude = 10f;


    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Vector3 forceDirection = transform.forward;
        rigidBody.AddForce(forceDirection * forceMagnitude);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }

        //Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
