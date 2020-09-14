using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spacebargame : MonoBehaviour
{

    public int myScore = 0; 
    public int scoreVictory = 20; 

    // Start is called before the first frame update
    void Start() {
        
        Debug.Log("DEBUG");
        print ("this is print? yikes");
        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            
            myScore++; 
            print ("spacebar pressed");

        }
    }
}
