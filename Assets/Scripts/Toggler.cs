using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        this.transform.rotation.Set(-90F, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float x = this.transform.rotation.x;
        float y = this.transform.rotation.y;
        float z = this.transform.rotation.z;
        float w = this.transform.rotation.w;

        x += 10;

        this.transform.rotation.Set(x, y, z, w);

        System.Console.WriteLine("Update x to " + x);
    }
}
