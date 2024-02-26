using UnityEngine;
using UnityEngine.PlayerLoop;

public class WallTorch : Interactive
{
    public GameObject chest;
    public static int litTorchesCount = 0;
    public override void OnInteraction()
    {
        //If I want to do the base OnInteraction anyway first
        //base.OnInteraction();
        //Activate light and fire
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        litTorchesCount++;
        if (litTorchesCount == 3)
        {
            chest.SetActive(true);
        }
    }
}
