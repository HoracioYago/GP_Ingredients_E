using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class E_BookInteraction : Interactive
{
    public Text interactiveText;
    public string bookText;
    private void Awake()
    {
        interactiveText.text = "";
        interactiveText.CrossFadeAlpha(0f, 0f, false);
    }
    public override void OnInteraction()
    {
        StartCoroutine(ShowAndHideText());
        interactiveText.text = bookText;
    }

    void Update()
    {
        Debug.Log(Time.time);
    }

    IEnumerator ShowAndHideText()
    {
        interactiveText.CrossFadeAlpha(1f, 1f, false);
        yield return new WaitForSeconds(1f);
        Debug.Log("Hide");
        interactiveText.CrossFadeAlpha(0f, 1f, false);
    }
}
