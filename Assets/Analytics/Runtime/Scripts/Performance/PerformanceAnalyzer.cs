using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformanceAnalyzer : MonoBehaviour {

    public int fps { get; set; }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        fps = (int)(1 / Time.deltaTime);
	}

}
