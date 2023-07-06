using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitOneShowOther : MonoBehaviour
{
    //public GameObject objectToShow;

  //  private void OnCollisionEnter(Collision collision)
 //  {
   //     if (collision.gameObject == objectToShow)
   //     {
   //         gameObject.GetComponent<Renderer>().enabled = true;
   //     }
  //  }

     void OnTriggerEnter(GameObject dirt)
    {
        if (dirt == null)
            dirt = GameObject.FindWithTag("MiningDirt");
        {

            gameObject.GetComponent<Renderer>().enabled = true;
        }

    }
}





