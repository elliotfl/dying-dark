using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

	public int Collection = 0;
	public GameObject Sphere;

	// Update is called once per frame
	void Update () 
	{
		if (Collection == 4) 
		{
			Sphere.SetActive (false);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Wall_1")
		{
			Destroy (col.gameObject);
			++Collection;
		}

		if (col.gameObject.name == "Wall_2")
		{
			Destroy (col.gameObject);
			++Collection;
		}

		if (col.gameObject.name == "Wall_3")
		{
			Destroy (col.gameObject);
			++Collection;
		}

		if (col.gameObject.name == "Wall_4")
		{
			Destroy (col.gameObject);
			++Collection;
		}
	}
}
