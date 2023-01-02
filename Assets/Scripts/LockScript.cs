using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int count = 0;
    private int angle = 5;

    private void FixedUpdate()
    {

        this.transform.Rotate(new Vector3(angle, 0, 0));

        if (++count >= 40) {

            angle = angle * -1;
            count = 0;

            GameObject.Find("GameObject").transform.Rotate(new Vector3(10, 0, 0));

            //GameObject.Find("GameObject").BroadcastMessage
        }
    }
}
