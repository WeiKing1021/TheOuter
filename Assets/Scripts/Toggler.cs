using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggler : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {

        this.transform.Rotate(new Vector3(1, 0, 0));
    }
}
