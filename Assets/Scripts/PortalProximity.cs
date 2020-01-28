using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalProximity : MonoBehaviour
{
    public GameObject Portal1;
    public GameObject Portal2;
    public GameObject Portal3;
    public GameObject Portal4;
    //Load our Portal game objects into Unity

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entering Portal");
        //Outputs to the Unity console
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exiting Portal");
        //Outputs to the Unity console
    }
}//End of script
