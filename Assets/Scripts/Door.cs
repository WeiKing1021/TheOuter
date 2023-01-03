using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Animator>().SetInteger("isOpen", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
