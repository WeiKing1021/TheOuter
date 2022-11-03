using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        //this.transform.position = Vector3.zero; // (0,0,0)
       // this.transform.rotation = Quaternion.Euler(0, 90, 0);
    }



    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {

        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }









}