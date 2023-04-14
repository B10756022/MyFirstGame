using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCanvasOnClick : MonoBehaviour
{
    //要移除的canvas
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        //按下按鈕後，呼叫ClickEvent()
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
        //刪掉canvas
        Destroy (canvas);
        if(Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }
}
