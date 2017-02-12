using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGF_Menu : MonoBehaviour {

    public Canvas mainCanvas;
    public Canvas optionsCanvas;

    private void Awake()
    {
        optionsCanvas.enabled = false;
    }

    public void OptionsOn()
    {
        optionsCanvas.enabled = true;
    }

}
