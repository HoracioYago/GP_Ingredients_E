using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Teleport : MonoBehaviour
{
    public Transform toTeleport;
    public bool rightOne;
    public GameObject disappearingWall;

    private void OnTriggerEnter(Collider other)
    {
        if (toTeleport!=null)
        {
            other.transform.position = toTeleport.position;
        }

        if (rightOne && disappearingWall!=null)
        {
            disappearingWall.SetActive(false);
        }
    }
}
