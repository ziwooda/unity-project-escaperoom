using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMove : MonoBehaviour
{
    public static bool firstfloor = false;
    public static bool secondfloor = false;

    public void FirstFloorDown()
    {
        firstfloor = true;
    }
    public void FirstFloorUp()
    {
        firstfloor = false;
    }
    public void SecondFloorDown()
    {
        secondfloor = true;
    }
    public void SecondFloorUp()
    {
        secondfloor = false;
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.A) || firstfloor)
        {
            this.transform.position=new Vector3(15,0,26);
        }
        if (Input.GetKey(KeyCode.S) || secondfloor)
            this.transform.position = new Vector3(15, 31, 26);
    }
}
