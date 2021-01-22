using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject gameObject;

    bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered)
        {
            gameObject.SetActive(false);
            triggered = true;
        }
    }
}
