using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class forball : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
		
	}
   // public Text loseText;
	// Update is called once per frame
	void Update () {
		
	}
  
   /* void SetloseText()
    {
        loseText.text = "You lose!!!";
    }*/
    void OnCollisionEnter(Collision other)
    {
        
            // ..and if the game object we intersect has the tag 'npc' assigned to it..
            if (other.gameObject.name == "npc")
            {
            // Make the other game object (the npc) inactive, to make it disappear
           
            other.gameObject.SetActive(false);
          
        }
       if (other.gameObject.name == "goodman")
        {
            // Make the other game object (the goodman) inactive, to make it disappear

            other.gameObject.SetActive(false);
            //SetloseText();

        }

    }
}
