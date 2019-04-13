using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript11 : MonoBehaviour, Vuforia.IVirtualButtonEventHandler
{

    private GameObject vButtonObject;
    // Use this for initialization
    void Start()
    {
        vButtonObject = GameObject.Find("FamVb");
        vButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Hello");
        Application.LoadLevel("DataMining5");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }


}
