using UnityEngine;
using TMPro;
using System.Collections;

public class DisplayText : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public string[] sentences;
    public float typingSpeed = 0.05f;

    private void Start()
    {
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (string sentence in sentences)
        {
            textBox.text = ""; // Clear text before displaying the next sentence
            textBox.fontSize = 0.3f; // Set the initial font size
            foreach (char letter in sentence)
            {
                textBox.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
            yield return new WaitForSeconds(2f); // Delay between sentences
        }
    }
}
