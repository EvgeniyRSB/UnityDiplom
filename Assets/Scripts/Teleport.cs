using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{ 
    public GameObject Gun;

    public void OnButtonDown()
    {
        Gun.transform.position = new Vector3(0.344162f, 0.9391f, -0.4647f);
        Gun.transform.rotation.Set(88.18301f, 0, 0, Gun.transform.rotation.w);
    }
}