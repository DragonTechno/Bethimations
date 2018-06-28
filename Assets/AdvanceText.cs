using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvanceText : MonoBehaviour {
    [TextArea]
    public string[] slides;
    int index;

	// Use this for initialization
	void Start () {
        index = 0;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = slides[index];
        if(Input.GetMouseButtonDown(0))
        {
            ++index;
            if(index >= slides.Length)
            {
                index = 0;
            }
        }
	}
}
