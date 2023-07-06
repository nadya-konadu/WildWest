using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StillTrigger : MonoBehaviour
{
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
        GameObject dirtt = GameObject.FindWithTag("MiningDirt");
        dirtt.gameObject.GetComponent<Renderer>().enabled = true;
    }
}