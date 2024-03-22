using System.Collections;
using UnityEngine;

public class E_WallBreak : Interactive
{
    public GameObject deletedWall, deletedFlag, lightOrb;
    public float lerpDuration = 5f;

    public override void OnInteraction()
    {
        StartCoroutine(Flash());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Flash());
        }
    }
    public IEnumerator Flash()
    {
        float elapsedTime = 0;

        while (elapsedTime < lerpDuration)
        {
            elapsedTime += Time.deltaTime;
            lightOrb.GetComponent<Light>().intensity = Mathf.Lerp(1, 100, elapsedTime / lerpDuration);
            yield return null;
        }

        elapsedTime = 0;


        while (elapsedTime < lerpDuration)
        {
            elapsedTime += Time.deltaTime;
            lightOrb.GetComponent<Light>().intensity = Mathf.Lerp(100, 1, elapsedTime / lerpDuration);
            yield return null;
        }

        Destroy(deletedWall);
        Destroy(deletedFlag);


    }
}

