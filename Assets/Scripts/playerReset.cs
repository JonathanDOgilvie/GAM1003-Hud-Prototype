using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerReset : MonoBehaviour
{

    public Transform spawn = null;
    public CharacterController player;

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
        if (player.tag == "Player")
        {
            player.enabled = false;
            other.transform.position = spawn.position;
            player.enabled = true;
            Debug.Log("Player reset");
        }    
    }
}//end of script
