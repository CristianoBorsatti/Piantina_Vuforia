using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Piantina : MonoBehaviour {
    //public GameObject plan;
        Text percentageText; 

	// Use this for initialization
	void Start () {
        //plan.SetActive(false);
        percentageText = GetComponent<Text>();
		
	}
    
    // Update is called once per frame
    public void Update(float value) {
     
        var id = Mathf.RoundToInt(value * 100);
        percentageText.text = Mathf.RoundToInt(value * 100).ToString();
		
	}
}
