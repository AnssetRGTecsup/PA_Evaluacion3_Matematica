using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopVelocityHorizontal : MonoBehaviour
{
    [SerializeField] int currentModifier;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (currentModifier==1)
            {
                other.GetComponent<Rigidbody>().velocity = new Vector3(0, other.transform.position.y, 0);
            }
            if (currentModifier == 2)
            {
                other.GetComponent<Rigidbody>().velocity = new Vector3(other.transform.position.x, 0, 0);
            }
            if (currentModifier == 3)
            {
                other.GetComponent<Rigidbody>().useGravity = false;
            }
        }
    }
}
