using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iskry : MonoBehaviour
{
    public Transform sparks_clone;
    public Transform Sparks;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Svarka")
        {
            sparks_clone = Instantiate(Sparks, transform.position, Quaternion.identity);
        }
    }

        // Update is called once per frame
        public void OnTriggerExit(Collider other)
        {
            if (other.tag == "Svarka")
            {
                Destroy(sparks_clone.gameObject);
            }
        }
}
