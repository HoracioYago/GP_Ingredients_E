using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlashDissolve : MonoBehaviour
{
    public GameObject deletedWall, deletedFlag, lightOrb;
    public float lerpDuration = 5f;

    public void StartDissolver()
    {
        StartCoroutine(Flash());
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartDissolver();
        }
    }

    public IEnumerator  Flash()
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
