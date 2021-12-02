using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintLetters : MonoBehaviour
{
    public Text text;
    private void Start()
    {
        StartCoroutine(RevealText());
    }

    IEnumerator RevealText()
    {
        var originalString = text.text;
        text.text = "";

        var numCharsRevealed = 0;
        while (numCharsRevealed < originalString.Length)
        {
            ++numCharsRevealed;
            text.text = originalString.Substring(0, numCharsRevealed);

            yield return new WaitForSeconds(0.07f);
        }
    }
    
}
