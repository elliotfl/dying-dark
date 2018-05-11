using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

	public int Collection = 0;
	public GameObject Cube;

	// Update is called once per frame
	void Update () 
	{
		
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

	void OnTriggerEnter(Collider Col)
	{
		if (Collection == 4) 
		{
			if (Col.gameObject.name == "Cube") 
			{
				SceneManager.LoadScene("differentScene");
			}
		}
	}
}
