using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSphere : MonoBehaviour
{

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleColor()
    {

        switch (Random.Range(0, 5))
        {
            case 0: rend.material.color = Color.black; break;
            case 1: rend.material.color = Color.blue; break;
            case 2: rend.material.color = Color.green; break;
            case 3: rend.material.color = Color.red; break;
            case 4: rend.material.color = Color.yellow; break;
        }
    }
}
