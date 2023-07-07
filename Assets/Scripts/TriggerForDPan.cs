using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForDPan : MonoBehaviour
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
        GameObject dirtPan = GameObject.FindWithTag("DirtPan");
        dirtPan.gameObject.GetComponent<Renderer>().enabled = true;
    }
}
