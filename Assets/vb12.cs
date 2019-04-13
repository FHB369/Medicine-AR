using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb12 : MonoBehaviour, Vuforia.IVirtualButtonEventHandler
{

    private GameObject vButtonObject;
    // Use this for initialization
    void Start()
    {
        vButtonObject = GameObject.Find("NutVb");
        vButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Hello");
        Application.LoadLevel("another");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }


}
