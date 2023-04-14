using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOnClink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //按下按鈕時，呼叫ClickEvent()
        GetComponent<Button> ().onClick.AddListener (() => {
            ClickEvent ();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ClickEvent()
    {
		Application.Quit();
    }
}
