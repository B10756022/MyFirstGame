using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
        //Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);
        Time.timeScale = 0f;
    }
}
