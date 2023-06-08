using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarGravity : MonoBehaviour
{
    [SerializeField] GameManager gamemanager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gamemanager.GetComponent<GameManager>().QuitarGrativy();
        }
    }
}
