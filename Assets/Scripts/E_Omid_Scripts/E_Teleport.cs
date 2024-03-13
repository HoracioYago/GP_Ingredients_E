using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Teleport : MonoBehaviour
{
    public Transform toTeleport;

    private void OnTriggerEnter(Collider other)
    {
        if (toTeleport!=null)
        {
            other.transform.position = toTeleport.position;
            other.transform.rotation = toTeleport.rotation;
        }
    }
}
