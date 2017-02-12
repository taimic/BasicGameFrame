using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BGF_MenuManager : MonoBehaviour {

    
    public List<Canvas> canvasList;

	// Use this for initialization
	void Start () {
        EnableCanvas(canvasList[0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnableCanvas(Canvas canvas)
    {
        HideAll();
        canvas.gameObject.SetActive(true);
        canvas.enabled = true;
        Button button = canvas.GetComponentInChildren<Button>();
        if (button != null)
        {
            EventSystem.current.SetSelectedGameObject(button.gameObject);
        }
    }

    private void HideAll()
    {
        foreach(Canvas canvas in canvasList)
        {
            canvas.enabled = false;
            canvas.gameObject.SetActive(false);
        }
    }
}
