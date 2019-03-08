using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))][RequireComponent(typeof(PerformanceAnalyzer))]
public class PerformanceView : MonoBehaviour {

    [SerializeField]
    private Text performanceView;

    [SerializeField]
    private PerformanceAnalyzer performanceAnalyzer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        performanceView.text = "Performance : " + performanceAnalyzer.fps + "/" + Application.targetFrameRate + " fps";
	}
}
