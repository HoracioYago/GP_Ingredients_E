using System.Collections;
using UnityEngine;

public class E_WallBreak : Interactive
{
    public GameObject deletedWall, deletedFlag, lightOrb;
    public ParticleSystem particles;

    public override void OnInteraction()
    {
        Instantiate(particles);
        Destroy(deletedWall);
        Destroy(deletedFlag);
    }
}



