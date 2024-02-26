using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Chest_Appear : Interactive
{
    Animator animator;

    public override void OnInteraction()
    {
        animator.SetTrigger("Open");
    }
}
