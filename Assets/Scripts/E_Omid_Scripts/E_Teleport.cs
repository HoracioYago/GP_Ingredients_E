using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Teleport : MonoBehaviour
{
    public Transform toTeleport;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = toTeleport.position;
    }
}
