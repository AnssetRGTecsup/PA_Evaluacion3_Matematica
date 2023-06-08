using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopVelocityHorizontal : MonoBehaviour
{
    [SerializeField] int currentModifier;
    [SerializeField] MaterialController _materialController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (currentModifier==1)
            {
                other.GetComponent<Rigidbody>().velocity = new Vector3(0, other.transform.position.y, 0);
                _materialController.ChangeEmissionColor(MaterialChange.OnOnlyVertical);
            }
            if (currentModifier == 2)
            {
                other.GetComponent<Rigidbody>().velocity = new Vector3(other.transform.position.x, 0, 0);
                _materialController.ChangeEmissionColor(MaterialChange.OnOnlyHorizontal);
            }
            if (currentModifier == 3)
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                _materialController.ChangeEmissionColor(MaterialChange.OnLooseGravity);
            }
        }
    }
}
