using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_CameraChange : MonoBehaviour
{
    public float activationRadius = 3f;
    public bool isZoom;

    private GameObject player;
    private Camera cam;

    void Update()
    {
        if (GameObject.Find("1") != null)
        {
            player = GameObject.Find("1").gameObject;
        }
        else if (GameObject.Find("2") != null)
        {
            player = GameObject.Find("2").gameObject;
        }
        else
        {
            Debug.Log("No player is active");
        }

        if (Vector3.Distance(player.transform.position, transform.position) <= activationRadius)
        {
            cam = player.GetComponentInChildren<Camera>();
            if (isZoom)
            {
                cam.fieldOfView = 40;
            }
            else
            {
                cam.fieldOfView = 60;
            }
        }
    }
}    
