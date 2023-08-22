using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed = 10.0f;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start(){
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountTest();
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("PickUp")){
			other.gameObject.SetActive(false);
			count += 1;
			SetCountTest();
		}
	}

	void SetCountTest(){
		countText.text = "Count: " + count.ToString();
		if (count >= 8) {
			winText.text = "You win!";
		}
	}

}
