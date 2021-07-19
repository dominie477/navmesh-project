using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressurepad : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    bool isopened = false;
    
    void Update()
    {
        
    }

    
    void OnTriggerEnter(Collider other)
    {
        if(isopened == false) {
            isopened = true;
        door.transform.position += new Vector3(0, 4, 0);
        }
    }
}
