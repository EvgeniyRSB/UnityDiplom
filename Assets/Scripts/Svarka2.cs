using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Svarka2 : MonoBehaviour
{
    public Transform sparks_clone;
    public Transform Sparks;
    public GameObject Weapon;
    public GameObject Detal1;
    public GameObject Detal2;
    public GameObject Mod;
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
            Vector3 gun_pos = Weapon.transform.position;
            Weapon.SetActive(false);
            Detal1.SetActive(false);
            Detal2.SetActive(false);
            Mod.transform.position = new Vector3(Weapon.transform.position.x, Weapon.transform.position.y, Weapon.transform.position.z);
            Mod.transform.rotation.Set(360, -358, 150, Mod.transform.rotation.w);
            Destroy(Weapon);
            Destroy(Detal1);
            Destroy(Detal2);
            Destroy(sparks_clone.gameObject);
        }
    }
}
