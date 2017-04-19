using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public float speed;
	private  Rigidbody rb;
	public Text scoreText;
	float score;
	void Start()
	{
		rb = GetComponent<Rigidbody> ();

	}
			
	void FixedUpdate ()
	{ 
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}
		
	void OnTriggerEnter(Collider other)
		{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive (false);
			score = score + 10;
			scoreText.text = "Score : " + score;

			}
		}
		

	}

