using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Door_Open : Interactive
{
    public Animator animator;
    public override void OnInteraction()
    {
        animator.SetTrigger("Open");
    }
}

