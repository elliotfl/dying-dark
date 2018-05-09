using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {

	public Rigidbody rb;

	public bool ShowCursor;
	public float SensitivityXaxis;
	public float SensitivityYaxis;
	// Update is called once per frame
	void Start()
	{
		rb = GetComponent<Rigidbody>();

		if(ShowCursor == false)
		{
			Cursor.visible = false;
		}
	}

	void Update()
	{
		float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * SensitivityXaxis;
		float newRotationX = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * SensitivityYaxis;

		gameObject.transform.localEulerAngles = new Vector3(newRotationX, newRotationY, 0);

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis ("Vertical") * Time.deltaTime * 9.0f;

		transform.Rotate (0, x, 0);
		transform.Translate (0, 0, z);
	}
}