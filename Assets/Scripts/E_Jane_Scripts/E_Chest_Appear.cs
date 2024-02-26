using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class E_Chest_Appear : Interactive
{
    public Animator animator;
    public GameObject key;
    bool Opened;
    public override void OnInteraction()
    {
        animator.SetTrigger("Open");
        Opened = true;
        if (Opened == true)
        {
            key.SetActive(true);
        }
        else
        {
            key.SetActive(false);
        }
    }
}
