using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button), typeof(Image))]
public class SocialButton : MonoBehaviour
{
    [SerializeField] private string url;
    [SerializeField] private Sprite icon;

    private Button _button;
    private Image  _image;

    void Awake()
    {
        _button = GetComponent<Button>();
        _image  = GetComponent<Image>();

        _image.sprite = icon;
        _button.onClick.AddListener(Open);
    }

    public void Open()
    {
        if (!string.IsNullOrEmpty(url))
            Application.OpenURL(url);
    }
}
