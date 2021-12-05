using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Awake Method Called even before Start Function Called
    // Awake is like Start but it is called before Start function called
    private void Awake()
    {
        Debug.Log("First Script Start Function..");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Script Start Function..");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("Input F pressed...");
        }

        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Input F Hold...");
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("Input F Released..");
        }
        //Debug.Log("First Script Update Function..");
    }

    // LateUpdate will called after Update method got executed
    // This will execute at some frequency but it is primarily used for Physics
    private void LateUpdate()
    {
        
    }

    // 
    private void OnDestroy()
    {

    }
}
