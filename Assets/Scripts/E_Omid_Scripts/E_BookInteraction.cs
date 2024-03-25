using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class E_BookInteraction : MonoBehaviour
{
    public Text bookTextObject;
    public GameObject interactiveText;
    public string bookText;
    public float activationRadius = 4f;

    private bool isClickable;
    private GameObject player;
    private void Awake()
    {
        bookTextObject.text = "";
        bookTextObject.CrossFadeAlpha(0f, 0f, false);

    }
    private void OnMouseEnter()
    {
        isClickable = true;
    }
    private void OnMouseExit()
    {
        isClickable = false;
        interactiveText.SetActive(false);
    }

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
            if (isClickable && Input.GetKeyDown(KeyCode.Mouse0))
            {
                StartCoroutine(ShowAndHideText());
                bookTextObject.text = bookText;
            }
            if (isClickable)
            {
                interactiveText.SetActive(true);
            }
            else
            {
                interactiveText.SetActive(false);
            }
        }


    }

    IEnumerator ShowAndHideText()
    {
        bookTextObject.CrossFadeAlpha(1f, 1f, false);
        yield return new WaitForSeconds(3f);
        bookTextObject.CrossFadeAlpha(0f, 1f, false);
    }
}
