using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopVelocityHorizontal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Rigidbody>().velocity = new Vector3(0, other.transform.position.y, 0) ;

        }
    }
}
