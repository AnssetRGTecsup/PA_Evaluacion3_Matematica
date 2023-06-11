using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] private GameDataScriptableObject currentData;

    public UnityEvent onUpdatePhysics;

    private void Awake() {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdatePhysics();
    }

    public void UpdatePhysics(bool useGravity = true){
        int multplierGravity = useGravity? 1 : 0;

        Physics.gravity = new Vector3(currentData.xAcceleration,currentData.gravity * multplierGravity + currentData.yAcceleration,0f);

        onUpdatePhysics?.Invoke();
    }
}
