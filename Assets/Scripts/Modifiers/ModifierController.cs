using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifierController : MonoBehaviour
{
    [Header("Aesthetic Components")]
    [SerializeField] private Vector3 rotationAngles;
    [SerializeField] private Color materialColor;
    [SerializeField] private Color emissionlColor;
    [Header("Modifier Attributes")]
    [SerializeField] private MaterialChange currentModifier;
    [SerializeField] private Vector3 speedModifier;

    private void Start() {
        Material[] materials = GetComponent<MeshRenderer>().materials;
        materials[0].SetColor("_baseColor", materialColor);
        materials[0].SetColor("_emissionColor", emissionlColor);
        
        GetComponent<MeshRenderer>().materials = materials;


        switch (currentModifier)
        {
            case MaterialChange.OnOnlyVertical:
            speedModifier = new Vector3(0,1,0);
            break;
            case MaterialChange.OnOnlyHorizontal:
            speedModifier = new Vector3(1f,0,1f);
            break;
            default:
            speedModifier = new Vector3(1f,1f,1f);
            break;
        }
    }

    private void Update() {
        transform.Rotate(rotationAngles);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            other.GetComponent<BallController>().ModifyPhysics(currentModifier, speedModifier);
        }
    }
}
