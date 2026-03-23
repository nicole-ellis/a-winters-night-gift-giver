using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject memoryPanel;
    public Image memoryImage;
    public Text memoryText;

    void Awake()
    {
        Instance = this;
        memoryPanel.SetActive(false);
    }

    public void ShowMemory(ItemData item)
    {
        memoryImage.sprite = item.icon;
        memoryText.text = item.memoryText;
        memoryPanel.SetActive(true);

        // Optional: play audio
        // AudioSource.PlayClipAtPoint(item.memoryAudio, Vector3.zero);
    }

    public void CloseMemory()
    {
        memoryPanel.SetActive(false);
    }
}