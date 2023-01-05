using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterDoor : MonoBehaviour
{
    private static string OPEN_STATUS_PARAMETER = "isOpen";

    [Tooltip("Door opening status")]
    public bool open;

    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Animator>().SetBool(OPEN_STATUS_PARAMETER, isOpen());
    }

    // Update is called once per frame
    void Update()
    {

        if (GetComponent<Animator>().GetBool(OPEN_STATUS_PARAMETER) != isOpen())
        {

            GetComponent<Animator>().SetBool(OPEN_STATUS_PARAMETER, isOpen());
        }
    }

    public void setOpen(bool isOpen)
    {

        open = isOpen;
    }

    public bool isOpen()
    {

        return open;
    }

    public void toggleOpen()
    {

        setOpen(!isOpen());
    }
}
