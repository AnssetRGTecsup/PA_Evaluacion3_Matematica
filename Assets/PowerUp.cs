using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        myRGBD = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            myRGBD.velocity = velocity * (-1);
            myRGBD.useGravity = false;


        }
    }
}
