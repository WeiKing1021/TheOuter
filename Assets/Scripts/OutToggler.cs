using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutToggler : MonoBehaviour
{
    private static string STATUS_PARAMETER = "on";

    [Tooltip("Door object")]
    public GameObject doorObject;

    [Tooltip("Toggler on")]
    public bool on;

    private int count = 0;


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
        //if (count++ > 200) {

        //    count = 0;

        //    toggle();
        //    print("Toggler is set to " + this.isOn() + "!");
        //}

        if (GetComponent<Animator>().GetBool(STATUS_PARAMETER) != isOn())
        {

            GetComponent<Animator>().SetBool(STATUS_PARAMETER, isOn());

            if (this.doorObject != null)
            {

                this.doorObject.GetComponent<OuterDoor>().toggleOpen();
            }
        }
    }

    public void set(bool isOn)
    {

        on = isOn;
    }

    public bool isOn()
    {

        return on;
    }

    public void toggle()
    {

        set(!isOn());
    }
}
