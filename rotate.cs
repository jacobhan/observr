using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class rotate : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
	public float speed = 50f;
	public bool isRotating = false;

	void Update ()
	{
		//if (Input.GetKey(KeyCode.Y))
		//transform.RotateAround(transform.localPosition, -Vector3.up, speed * Time.deltaTime);
		//if (Input.GetKey(KeyCode.T))
		//transform.Rotate(Vector3.up * speed * Time.deltaTime);
		//transform.RotateAround(transform.localPosition, Vector3.up, speed * Time.deltaTime);
		if (isRotating) {
			transform.RotateAround (transform.localPosition, -Vector3.up, speed * Time.deltaTime);
		}
	}

	public void OnPointerDown(PointerEventData data)
     {
     	isRotating = true;
		//transform.RotateAround(transform.localPosition, -Vector3.up, speed * 2);
     }

	public void OnPointerUp(PointerEventData data)
     {
     	isRotating = false;
		//transform.RotateAround(transform.localPosition, -Vector3.up, speed * 2);
     }
}
