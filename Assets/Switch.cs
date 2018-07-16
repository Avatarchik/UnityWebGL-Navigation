using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
    public GameObject floor3;
    public GameObject floor2;
    public GameObject floor1;
    public GameObject camPivot;
    // Use this for initialization

    public void SwitchTo3()
    {
        camPivot.transform.SetPositionAndRotation(floor3.transform.position, Quaternion.identity);
    }
    public void SwitchTo2()
    {
        camPivot.transform.SetPositionAndRotation(floor2.transform.position, Quaternion.identity);
    }
    public void SwitchTo1()
    {
        camPivot.transform.SetPositionAndRotation(floor1.transform.position, Quaternion.identity);
    }
}
