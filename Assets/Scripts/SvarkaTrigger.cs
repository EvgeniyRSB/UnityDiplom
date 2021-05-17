using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SvarkaTrigger : MonoBehaviour
{
    public Transform sparks_clone;
    public Transform Sparks;
    public GameObject Gun;
    public GameObject Detal;
    public GameObject Model;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Svarka")
        {
            sparks_clone = Instantiate(Sparks, transform.position, Quaternion.identity);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Svarka")
        {

            Vector3 gun_pos = Gun.transform.position;
            Gun.SetActive(false);
            Detal.SetActive(false);
            Model.transform.position = new Vector3(Gun.transform.position.x, Gun.transform.position.y, Gun.transform.position.z);
            Model.transform.rotation.Set(360, -358, 150, Model.transform.rotation.w);
            Destroy(Gun);
            Destroy(Detal);
            Destroy(sparks_clone.gameObject);       
        }
    }
}
