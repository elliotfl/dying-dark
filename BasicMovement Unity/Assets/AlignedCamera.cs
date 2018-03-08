using UnityEngine;

public class AlignedCamera : MonoBehaviour {

	public Transform player; 
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = player.position;
	}
}
