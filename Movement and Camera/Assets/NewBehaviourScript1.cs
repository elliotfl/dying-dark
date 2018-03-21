using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
	
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	public bool ShowCursor;
	public float Sensitivity;
	
	// Update is called once per frame
	void Start()
	{
		if(ShowCursor == false)
		{
			Cursor.visible = false;
		}
	}

	void Update () 
	{

		float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * Sensitivity;
		float newRotationX = transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * Sensitivity;

		gameObject.transform.localEulerAngles = new Vector3(newRotationX, newRotationY, 0);

		if (Input.GetKey ("w")) 
		{
			rb.AddForce (0, 0, forwardForce * Time.deltaTime);
		}

		if (Input.GetKey ("d")) 
		{
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey ("a")) 
		{
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey ("s")) 
		{
			rb.AddForce (0, 0, -forwardForce * Time.deltaTime);
		}


	}
}
