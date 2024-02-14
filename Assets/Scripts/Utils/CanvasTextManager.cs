using TMPro;
using UnityEngine;

public class CanvasTextManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI title;
    [SerializeField] private TextMeshProUGUI content;
    [SerializeField] private Transform gredPlayer;
    
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
        if (gredPlayer != null && gredPlayer.gameObject.activeSelf)
        {
            Vector3 vectorToGred = gredPlayer.position - transform.position;
            transform.forward = -vectorToGred;
        }
        else transform.forward = main.transform.forward;
    }
}
