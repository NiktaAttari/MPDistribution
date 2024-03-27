using UnityEngine;
using TMPro;
using System.Collections;

public class DisplayText : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public string[] sentences;
    public float typingSpeed = 0.05f;

    private int currentSentenceIndex = 0; // Track the current sentence index

    private void OnEnable()
    {
        ResetText();
    }

    private void ResetText()
    {
        currentSentenceIndex = 0; // Reset the current sentence index
        StopAllCoroutines(); // Stop any ongoing coroutine
        StartCoroutine(TypeText()); // Start typing from the beginning
    }

    IEnumerator TypeText()
    {
        while (currentSentenceIndex < sentences.Length) // Loop until all sentences are displayed
        {
            string sentence = sentences[currentSentenceIndex];
            textBox.text = ""; // Clear text before displaying the next sentence
            textBox.fontSize = 0.1f; // Set the initial font size
            foreach (char letter in sentence)
            {
                textBox.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
            yield return new WaitForSeconds(2f); // Delay between sentences
            currentSentenceIndex++; // Move to the next sentence
        }
    }
}
