using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallController : MonoBehaviour
{
    [SerializeField] private MaterialController materialController;
    [SerializeField] private Rigidbody myRGBD;
    [SerializeField] private Transform originTransform;
    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] private Material material;
    [SerializeField] private MeshRenderer elMaterial;
    public event Action<Vector2> onLaunch;

    private void Start() {
        myRGBD = GetComponent<Rigidbody>();
        trailRenderer = GetComponent<TrailRenderer>();

        materialController.ChangeEmissionColor(MaterialChange.Normal);

        myRGBD.velocity = Vector3.zero;
        myRGBD.useGravity = false;
        trailRenderer.enabled = false;
    }

    public void LaunchSphere(Vector2 velocity){
        materialController.ChangeEmissionColor(MaterialChange.OnLaunch);

        myRGBD.velocity = velocity;
        myRGBD.useGravity = true;

        trailRenderer.enabled = true;
    }

    public void ResetPosition(){
        transform.position = originTransform.position;
        transform.rotation = Quaternion.identity;

        elMaterial.material = material;
        materialController.ChangeEmissionColor(MaterialChange.Normal);

        myRGBD.velocity = Vector3.zero;
        myRGBD.useGravity = false;
        trailRenderer.enabled = false;
    }

    //myRGBD.velocity = new Vector3(myRGBD.velocity.x, myRGBD.velocity.y, myRGBD.velocity.z);
    /*
    private void OnTriggerEnter(Collider2D collision)
    {
        if (collision.tag == "obstaculoX")
        {
            
            myRGBD.velocity = new Vector3(0, myRGBD.velocity.y, myRGBD.velocity.z);
        }
        if (collision.tag == "obstaculoY")
        {
            myRGBD.useGravity = false;
            myRGBD.velocity = new Vector3(myRGBD.velocity.x, 0, myRGBD.velocity.z);
        }
        if (collision.tag == "obstaculoGravedad")
        {
            myRGBD.useGravity = false;
        }
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obstaculoX")
        {

            myRGBD.velocity = new Vector3(0, myRGBD.velocity.y, myRGBD.velocity.z);
            elMaterial.material= other.GetComponent<MeshRenderer>().material;
        }
        if (other.tag == "obstaculoY")
        {
            myRGBD.useGravity = false;
            myRGBD.velocity = new Vector3(myRGBD.velocity.x, 0, myRGBD.velocity.z);
            elMaterial.material = other.GetComponent<MeshRenderer>().material;
        }
        if (other.tag == "obstaculoGravedad")
        {
            myRGBD.useGravity = false;
            elMaterial.material = other.GetComponent<MeshRenderer>().material;
        }
    }
}
