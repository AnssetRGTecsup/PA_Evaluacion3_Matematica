using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidificadorManager : MonoBehaviour
{
    [SerializeField] private MaterialController materialController;
    private void OnTriggerEnter(Collider other)
    {
        if(this.gameObject.tag == "Horizontal")
        {
            Debug.Log("cambio Horizontal");
            materialController.ChangeEmissionColor(MaterialChange.OnOnlyVertical);
            other.GetComponent<BallController>().ChangeVelocityHorizontal();
            Destroy(this.gameObject);
        }
        else if (this.gameObject.tag == "Vertical")
        {
            Debug.Log("cambio Vertical");
            materialController.ChangeEmissionColor(MaterialChange.OnOnlyHorizontal);
            other.GetComponent<BallController>().ChangeVelocityVertical();
            Destroy(this.gameObject);
        }
        else if (this.gameObject.tag == "Gravity")
        {
            Debug.Log("cambio de gravedad");
            materialController.ChangeEmissionColor(MaterialChange.OnLooseGravity);
            materialController.ChangeEmissionColor(MaterialChange.Normal);
            other.GetComponent<BallController>().ChangeGravity();
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("Ningun cambio aplicado");
        }
    }
}
