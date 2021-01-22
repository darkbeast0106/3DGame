using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject triggerObject;

    bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered)
        {
            triggerObject.SetActive(false);
            triggered = true;
        }
    }
}
