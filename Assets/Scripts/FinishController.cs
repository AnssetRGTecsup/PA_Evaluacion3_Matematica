using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishController : MonoBehaviour
{    
    [SerializeField] private int CurrentLevls;
    
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("GANO!1");
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            SceneManager.LoadScene(CurrentLevls);
            Debug.Log("GANO!2");
        }
    }
}
