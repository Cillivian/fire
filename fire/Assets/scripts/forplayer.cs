using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class forplayer : MonoBehaviour
{
    public Text loseText;
    // Use this for initialization
    void Start()
    {
       
    }

    private void SetCountText()
    {
        loseText.text = "you lose!!!";
        //text lose
    }


    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {

        // ..and if the game object we intersect has the tag 'npc' assigned to it..
        if (other.gameObject.name == "npc")
        {
            // Make the other game object (the npc) inactive, to make it disappear

            other.gameObject.SetActive(false);
            SetCountText();

        }
        if (other.gameObject.name == "goodman")
        {
            // Make the other game object (the npc) inactive, to make it disappear

            other.gameObject.SetActive(false);
            SetCountText();

        }

    }
}