using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button _button;
    public Image _image;
    public void Start()
    {
        _button = GetComponent<Button>();
    }

    private void ColorChange()
    {
        //_button.onClick.AddListener(delegate {ColorChange(color)});
    }
}
