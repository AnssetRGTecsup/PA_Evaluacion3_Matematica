using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidificadorManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(this.gameObject.tag == "Horizontal")
        {
            Debug.Log("cambio Horizontal");
            other.GetComponent<BallController>().ChangeVelocityHorizontal();
            Destroy(this.gameObject);
        }
        else if (this.gameObject.tag == "Vertical")
        {
            Debug.Log("cambio Vertical");
            other.GetComponent<BallController>().ChangeVelocityVertical();
            Destroy(this.gameObject);
        }
        else if (this.gameObject.tag == "Gravity")
        {
            Debug.Log("cambio de gravedad");
            other.GetComponent<BallController>().ChangeGravity();
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("Ningun cambio aplicado");
        }
    }
}
