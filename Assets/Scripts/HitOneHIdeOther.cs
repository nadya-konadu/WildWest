using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitOneHIdeOther : MonoBehaviour
{
    public GameObject dirt;
    // Start is called before the first frame update
   // void Start()
   // {
   //     if (dirt == null)
   //         dirt = GameObject.FindWithTag("MiningDirt");

   //     Destroy(dirt);
   // }

    // Update is called once per frame
   // void Update()
   // {
        
   // }

    void OnTriggerEnter(GameObject dirt)
    {
        if (dirt == null)
            dirt = GameObject.FindWithTag("MiningDirt");

        Destroy(dirt);
    }

    //void OnTriggerEnter(Collider other)
   // {
      //  if (other.gameObject.CompareTag("MiningDirt"))
      //  {
          //  Destroy(other.gameObject);
       // }
   // }

    //void OnTriggerEnter(Collider collision)
   // {
       // if (collision.gameObject.CompareTag("MiningDirt"))
      //  {
        //    Destroy(collision.gameObject);
      //  }
  //  }

   // void OnTriggerEnter(Collider target)
    //{
       // if(target.tag == "MiningDirt")
      //  {
          //  Destroy(target.gameObject);
      //  }
  //  }

    //if game object is triggered then tagged game object becomes visible
}
