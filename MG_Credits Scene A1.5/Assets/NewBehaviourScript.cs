using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject text = new GameObject();
		TextMesh t = text.AddComponent<TextMesh>();
		t.text = "Alaric Smith";
		t.fontSize = 300;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
