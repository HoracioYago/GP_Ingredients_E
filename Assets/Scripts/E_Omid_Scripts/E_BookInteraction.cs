using System.Collections;
using UnityEngine;
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

    IEnumerator ShowAndHideText()
    {
        interactiveText.CrossFadeAlpha(1f, 1f, false);
        yield return new WaitForSeconds(3f);

        interactiveText.CrossFadeAlpha(0f, 1f, false);
    }
}
