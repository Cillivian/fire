
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class cameraforcs : MonoBehaviour
{
    public GameObject newObject;
    // Use this for initialization

    void Start()
    {
     

    }

   
    public Text winText;
    public int count;
    int speed = 5;
    int total = 0;

    float nexttime = 0.0f;
    float firetima = 0.2f;
    void SetwinText()
    {
        winText.text = "You win!!!";
    }
    void SetloseText()
    {
        winText.text = "You lose!!!";
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x, 0, z);
        print(x);
        if (Input.GetButton("Fire1") && nexttime < Time.time)
        {
            nexttime = firetima + Time.time;
            GameObject go = Instantiate(newObject, transform.position, transform.rotation) as GameObject;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            go.GetComponent<Rigidbody>().AddForce(fwd * 1500);
            //fire the ball
            Destroy(go, 2.0f);
            //ball destroy after 2 seconds
            total += 1;
            // add the total(ball)

            GameObject.Find("Result").GetComponent<Text>().text = "Total:" + total;

        }

      /*  if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -25 * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 25 * Time.deltaTime, 0, Space.Self);

        }*/

      /*  if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(-25 * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(25 * Time.deltaTime, 0, 0, Space.Self);

        }*/
        //up or down the camera
        if (Input.GetKey(KeyCode.H))
        {
            transform.Translate(0, 5 * Time.deltaTime, 0);

        }
        if (Input.GetKey(KeyCode.N))
        {

            transform.Translate(0, -5 * Time.deltaTime, 0);


        }

    }
    void OnTriggerEnter(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Pick Up"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
            other.gameObject.SetActive(false);

            // Add one to the score variable 'count'
            count = count + 1;
            GameObject.Find("Result1").GetComponent<Text>().text = "Goals:" + count;
            if (count >= 7)
            {

                SetwinText();
            }


        }

     

    }
    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.name == "goodman")
        {
            // Make the other game object (the npc) inactive, to make it disappear

            collision.gameObject.SetActive(false);
            SetloseText();

        }

    }
}