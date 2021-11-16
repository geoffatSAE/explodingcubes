using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{

    public GameObject p1, p2, p3, p4;

    public GameObject brokenPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Bat") { 
            Debug.Log("Collision has happened with " + collision.transform.gameObject.name);


            Debug.Log(collision.impulse);

            //
            //Rigidbody myRigidBody = GetComponent<Rigidbody>();
            //myRigidBody.AddForce(collision.impulse * 100);



            //replace the object with the smaller objects 
            
            //this could be instantiate instead https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
            //example
            //Instantiate(brokenPrefab, new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z), Quaternion.identity);
            //...
            p1.transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
            p2.transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z + 0.5f);
            p3.transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
            p4.transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z - 0.5f);




            // add the forces to those objects (multiplied)
            Rigidbody p1r = p1.gameObject.GetComponent<Rigidbody>();
            p1r.AddForce(collision.impulse * 10000);
            Rigidbody p2r = p2.gameObject.GetComponent<Rigidbody>();
            p2r.AddForce(collision.impulse * 10000);
            Rigidbody p3r = p3.gameObject.GetComponent<Rigidbody>();
            p3r.AddForce(collision.impulse * 10000);
            Rigidbody p4r = p4.gameObject.GetComponent<Rigidbody>();
            p4r.AddForce(collision.impulse * 10000);

            //get rid of the big cube
            GameObject.Destroy(gameObject);

        }
    }
}
