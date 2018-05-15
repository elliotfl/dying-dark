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
		if (col.gameObject.name == "gemstone.green")
		{
			Destroy (col.gameObject);
			++Collection;
		}

		if (col.gameObject.name == "gemstone.red")
		{
			Destroy (col.gameObject);
			++Collection;
		}

		if (col.gameObject.name == "gemstone.hotpink")
		{
			Destroy (col.gameObject);
			++Collection;
		}

		if (col.gameObject.name == "gemstone.silver")
		{
			Destroy (col.gameObject);
			++Collection;
		}

		if (col.gameObject.name == "gemstone.yellow")
		{
			Destroy (col.gameObject);
			++Collection;
		}

		if (col.gameObject.name == "gemstone.blue")
		{
			Destroy (col.gameObject);
			++Collection;
		}


	}

	void OnTriggerEnter(Collider Col)
	{
		if (Collection == 6) 
		{
			if (Col.gameObject.name == "Cube") 
			{
				SceneManager.LoadScene("Credits");
			}
		}
	}
}
