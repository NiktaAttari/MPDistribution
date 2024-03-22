using TMPro;
using UnityEngine;

public class CanvasTextManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI title;
    [SerializeField] private TextMeshProUGUI content;

    private Camera main;

    private void Awake()
    {
        main = Camera.main;
    }

    public void UpdateText(string titleText, string contentText)
    {
        title.text = titleText;
        content.text = contentText;
    }

    private void Update()
    {
        Vector3 targetDirection = (main.transform.position -  transform.position).normalized;
        targetDirection = new Vector3 (targetDirection.x, 0f, targetDirection.z);
        transform.forward = -targetDirection;
    }
}
