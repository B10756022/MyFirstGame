using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateCanvasOnClick : MonoBehaviour
{
    //要產生的canvas
    public GameObject canvasPrefab;
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
		//生產canvasPrefab
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);
        if(Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
        }
    }
}
